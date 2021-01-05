using System.Net.Mail;

namespace Solid.DIP.Example1.Violation
{
    public static class EmailServices
    {
        public static bool IsValid(string email) => email.Contains("@");

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