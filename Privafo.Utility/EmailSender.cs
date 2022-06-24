using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Utility
{
    public class EmailSender : IEmailSender
    {

        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Task SendEmailAsync(string mailTo, string subject, string htmlMessage)
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("noreply@privafo.com"));
            emailToSend.To.Add(MailboxAddress.Parse(mailTo));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { 
                Text = string.Format("<h2 style='color:red;'>{0}</h2>", htmlMessage) 
            };

            //send email
            using (var emailClient = new SmtpClient()) 
            {
                emailClient.Connect("mx.mailspace.id", 465, MailKit.Security.SecureSocketOptions.Auto);
                emailClient.Authenticate("noreply@privafo.com", "sysNoreply22!");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }

            return Task.CompletedTask;
        }
    }

    public class MailSettings
    {
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
