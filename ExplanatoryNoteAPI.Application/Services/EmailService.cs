using System.Net;
using System.Net.Mail;
using ExplanatoryNoteAPI.Application.Options;
using Microsoft.Extensions.Options;

namespace ExplanatoryNoteAPI.Application.Services
{
	public interface IEmailService
	{
		Task<bool> Send(string email, string title, string content);
	}

	public class EmailService : IEmailService
	{
		private readonly SmtpOptions _smtpOptions;

		public EmailService(IOptions<SmtpOptions> options)
		{
			_smtpOptions = options.Value;
		}

		public async Task<bool> Send(string email, string title, string content)
		{
			using var client = BuildClient();
			var message = new MailMessage();
			message.From = new MailAddress(_smtpOptions.Address, _smtpOptions.Name);
			message.Subject = title;
			message.Body = content;
			message.To.Clear();
			message.To.Add(new MailAddress(email));
			try
			{
				await client.SendMailAsync(message);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}
		}

		private SmtpClient BuildClient()
		{
			var client = new SmtpClient(_smtpOptions.Host, _smtpOptions.Port);
			client.Credentials = new NetworkCredential(_smtpOptions.Name, _smtpOptions.Password);
			client.EnableSsl = true;
			return client;
		}
	}
}
