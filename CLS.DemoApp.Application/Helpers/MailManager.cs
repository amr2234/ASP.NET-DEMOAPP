using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CLS.DemoApp.Application.Helpers
{
    public class MailManager
    {

        public static bool sendMail(string subject,string body)
        {
            // Host=smtp ,Port ,Credential (Usename,pwd)


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;//25
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("from@gmail.com", "123");
         
            smtp.Send("from@gmail.com", "mailssss", subject, body);

            //MailMessage m = new MailMessage();

            //smtp.Send(m);



            return true;
        }
    }
}
