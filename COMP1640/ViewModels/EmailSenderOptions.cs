using System;
using MailKit.Security;

namespace COMP1640.ViewModels
{

    public class EmailSenderOptions
    {
        public EmailSenderOptions()
        {
            Host_SecureSocketOptions = SecureSocketOptions.Auto;
        }

        public string Host { get; set; }
        public int Port { get; set; }

        public string User { get; set; }
        public string Pass { get; set; }

        public string Sender { get; set; }
        public string Name { get; set; }
        public SecureSocketOptions Host_SecureSocketOptions { get; set; }

    }
}
