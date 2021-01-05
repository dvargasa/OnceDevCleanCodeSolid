using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._01_SingleResponsability
{
    public class Notification
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //a class doesn't need have the responsability of insert in database itself
        //someone must do it for it (repository, another class)
        public string AddClient()
        {
            //validation: class don't have to know to validate e-mail. Use a class to validate e-mail
            if (!Email.Contains("@"))
                return "E-mail is invalid";

            //not responsability: connection and know de database
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "Test";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ... VALUES (@name...";

                cmd.Parameters.AddWithValue("name", Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            //not responsability: send email
            var mail = new MailMessage("x@x.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Hello";
            mail.Body = "No SRP applied here";
            client.Send(mail);

            return "Ok Client";
        }
    }
}
