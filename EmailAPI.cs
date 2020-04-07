using System;
using System.Collections.Generic;
using System.Text;
using MimeKit;
using MailKit;

namespace Sweepstakes
{
    class EmailAPI
    {
        MimeMessage message = new MimeMessage();
        BodyBuilder builder = new BodyBuilder();

        public EmailAPI(string name, string marketingEmail)
        {
            message.From.Add(new MailboxAddress($"{name}", "MarketingFirm@email.com"));
            

        }
    }
}
