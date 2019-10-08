using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using MimeKit;
using NETCore.MailKit.Core;
using System.Threading.Tasks;

namespace ASPNETCore21Authentication.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        private ILogger<EmailSender> _logger;
        IEmailService _emailService;

        public EmailSender(ILogger<EmailSender> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {

            await _emailService.SendAsync(email, subject, message);
            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress("Wagner Xu", "wagnerhsu@qq.com"));
            //message.Subject = subject;
            //message.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            //{
            //    Text = msg
            //};
            //message.To.Add(new MailboxAddress(email));
            //using (var client = new SmtpClient())
            //{
            //    await client.ConnectAsync("localhost");
            //    await client.AuthenticateAsync("admin@meehealth.com", "123456");
            //    await client.SendAsync(message);
            //    await client.DisconnectAsync(true);
            //}

            _logger.LogInformation($"{email},{subject},{message}");
        }
    }
}