using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorsOnTheMoveAfrica.Services
{
    public class SendGridServices : IEmailSender
    {
        private const string apiKey = "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";
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("doctorsonthemoveafrica@doctors.com", "Doctors on the move Africa"),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage
            };
            msg.AddTo(new EmailAddress("davidzagi93@gmail.com", "Test User"));
            await client.SendEmailAsync(msg);
        }
    }
}
