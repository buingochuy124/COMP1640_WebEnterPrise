using System;
using System.Net.Mail;
using System.Threading.Tasks;
using COMP1640.Repository.IRepository;
using COMP1640.ViewModels;
using COMP1640.ViewModels.Response;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace COMP1640.Repository
{
	public class SendEmail : ISendEmail
	{
		
        public SendEmail(IOptions<EmailSenderOptions> options)
        {
            this.Options = options.Value;
        }

        public EmailSenderOptions Options { get; set; }

        public void SendEMail(string email, string subject, string message)
        {
            Execute(email, subject, message);
        }

        public Task Execute(string to, string subject, string message)
        {
            // create message
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(Options.Sender);
            if (!string.IsNullOrEmpty(Options.Name))
            email.Sender.Name = Options.Name;
            email.From.Add(email.Sender);
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = message };

            // send email
            using (var smtp = new SmtpClient())
            {
                smtp.Connect(Options.Host, Options.Port, Options.Host_SecureSocketOptions);
                smtp.Authenticate("trungntgcd191228@fpt.edu.vn", "Anhanh123@");
                smtp.Send(email);
                smtp.Disconnect(true);
            }

            return Task.FromResult(true);
        }
    }
}

