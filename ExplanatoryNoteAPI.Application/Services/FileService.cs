using System.IO.Hashing;
using Amazon.S3;
using Amazon.S3.Model;
using ExplanatoryNoteAPI.Application.Contracts;
using ExplanatoryNoteAPI.Application.Interfaces;
using ExplanatoryNoteAPI.Application.Options;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Core.Entities.TextBlockEntities;
using Microsoft.Extensions.Options;

namespace ExplanatoryNoteAPI.Application.Services
{
	public class FileService : IFileService
	{
		private readonly IAmazonS3 _s3Client;

		private readonly string _bucketName;

		private readonly IGenericDataService _genericDataService;

		public FileService(IAmazonS3 s3Client,
			IOptions<S3Options> options,
			IGenericDataService genericDataService)
		{
			_s3Client = s3Client;
			_bucketName = options.Value.BucketName;
			_genericDataService = genericDataService;
		}

		public async Task<Guid> Upload(FileDTO fileDTO)
		{
			var buckets = await _s3Client.ListBucketsAsync();
			if (buckets.Buckets == null  || !buckets.Buckets.Any(x => x.BucketName == _bucketName))
			{
				var putBucketRequest = new PutBucketRequest
				{
					BucketName = _bucketName
				};
				try
				{
					await _s3Client.PutBucketAsync(_bucketName);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
				
			}
			var id = Guid.NewGuid();
			var key = id.ToString() + fileDTO.FileName;
			var streamCopy = new MemoryStream();
			fileDTO.Stream.CopyTo(streamCopy);
			var putRequest = new PutObjectRequest
			{
				BucketName = _bucketName,
				Key = key,
				InputStream = fileDTO.Stream,
				ContentType = fileDTO.ContentType
			};
			await _s3Client.PutObjectAsync(putRequest);
			streamCopy.Position = 0;
			var crc = new Crc32();
			crc.Append(streamCopy);
			var hash = crc.GetCurrentHashAsUInt32().ToString("X8");

			var file = new ExplanatoryNoteAPI.Core.Entities.File
			{
				Id = id,
				FileName = fileDTO.FileName,
				FileFormat = fileDTO.FileName.Split('.').Last(),
				FileRelativePath = key,
				FileChecksum = hash
			};
			await _genericDataService.CreateAsync(file.GetType(), file);

			return id;
		}

		public async Task<bool> Upload(ImageDTO imageDTO)
		{
			var obj = await _genericDataService.GetByIdAsync(typeof(TextBlock), imageDTO.TextBlockId);
			if (obj != null && obj is TextBlock textBlock)
			{
				using var memoryStream = new MemoryStream();
				imageDTO.Stream.CopyTo(memoryStream);
				var bytes = memoryStream.ToArray();
				var base64 = Convert.ToBase64String(bytes);
				var image = new TextBlockImage
				{
					ImageData = base64,
					Type = imageDTO.FileName.Split('.').Last(),
					Comment = imageDTO.Comment,
					Order = imageDTO.Order
				};
				var elements = textBlock.Elements;
				elements.Add(image);
				textBlock.Elements = elements;
				return await _genericDataService.UpdateAsync(typeof(TextBlock), textBlock);
			}
			return false;
		}

		public async Task<FileDTO?> Download(Guid id)
		{
			var obj = await _genericDataService.GetByIdAsync(typeof(ExplanatoryNoteAPI.Core.Entities.File), id);
			if (obj == null)
			{
				return null;
			}
			if (obj is ExplanatoryNoteAPI.Core.Entities.File file)
			{
				var getRequest = new GetObjectRequest
				{
					BucketName = _bucketName,
					Key = file.FileRelativePath
				};
				var response = await _s3Client.GetObjectAsync(getRequest);
				return new FileDTO
				{
					ContentType = response.Headers.ContentType,
					FileName = file.FileName!,
					Stream = response.ResponseStream,
				};
			}
			throw new InvalidDataException();
		}
	}
}
