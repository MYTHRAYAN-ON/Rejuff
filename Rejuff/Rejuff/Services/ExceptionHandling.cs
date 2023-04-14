using System;
using System.Net;
using System.Net.Mail;

namespace Rejuff.Services
{
    public class ExceptionHandling
    {
        public static void LogExceptions(string Exception)
        {
            try
            {
                SendExceptionViaMail(Exception);
            }
            catch (Exception ex)
            {
                SendExceptionViaMail(ex.ToString());
            }
        }

        public static void SendExceptionViaMail(string Message)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("digitalindiaapp0@gmail.com");
                message.To.Add(new MailAddress("techogens@gmail.com"));
                message.Subject = "EXCEPTION IN REJUFF APP @" + DateTime.Now.ToString();
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = Message;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("digitalindiaapp0@gmail.com", "DigitalIndia2020");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                //SendExceptionViaMail(ex.ToString());
            }
        }
    }
}
