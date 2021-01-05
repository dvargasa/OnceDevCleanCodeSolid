using System.Net.Mail;

namespace Solid._1_SRP.Example1.Solution
{
    public static class EmailServices
    {        
        public static void Send(string from, string to, string subject, string body)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = body;
            client.Send(mail);
        }
    }
}