using ExplanatoryNoteAPI.Core.Interfaces;
using Microsoft.Extensions.Caching.Distributed;

namespace ExplanatoryNoteAPI.Utilities.Cache
{
	public class RedisCache : ICache
	{
		IDistributedCache cache;
		public RedisCache(IDistributedCache distributedCache)
		{
			cache = distributedCache;
		}

		public async Task<int?> GetVerificationCode(string email)
		{
			var verificationString = await cache.GetStringAsync(email);

			int verificationCode;
			if (int.TryParse(verificationString, out verificationCode))
			{
				return verificationCode;
			}
			return null;
		}

		public async Task SaveVerificationCode(string email, string verificationCode)
		{
			await cache.SetStringAsync(email, verificationCode, new DistributedCacheEntryOptions
			{
				AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
			});
		}
	}
}
