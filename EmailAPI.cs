using System;
using System.Collections.Generic;
using System.Text;
using MimeKit;
using MailKit;
using MailKit.Net.Smtp;

namespace Sweepstakes
{
    class EmailAPI
    {
        MimeMessage message = new MimeMessage();
        string firmName;

        public EmailAPI(string name, string marketingEmail)
        {
            firmName = name;
            message.From.Add(new MailboxAddress($"{name}", $"{marketingEmail}"));
            message.To.Add(new MailboxAddress("Chris", "chrisobrien2000@outlook.com"));
            message.ReplyTo.Add(new MailboxAddress($"{name}", $"{marketingEmail}"));
        }

        public void SendEmailToWinner()
        {
            message.Subject = $"Result of Sweepstake";
            message.Body = new TextPart("plain")
            {
                Text = $@"Fantastic News,

You are the winner of the Sweepstakes you recently participated in!

-- {firmName}"
            };

            SendMessageThroughClient();
        }

        public void SendMessageThroughClient()
        {
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);

            client.Authenticate("chrisobee2000@gmail.com", "albwnxrjqvelbyqe");

            client.Send(message);
            client.Disconnect(true);
        }
    }
}
