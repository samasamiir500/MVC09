using System.Net;
using System.Net.Mail;

namespace MVC03.PL.Helpers
{
    public static class EmailSettings
    {
        public static bool SendEmail(Email email)
        {

            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("sama.samiiiir.0000@gmail.com", "eizudhbavwiabdhy");
                client.Send("sama.samiiiir.0000@gmail.com", email.To, email.Subject, email.Body);
                //eizudhbavwiabdhy
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
