using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using SDGSDB.Models;

namespace SDGSDB.API.Controllers
{
    
    public class SendEmailController : ApiController
    {
       [HttpPost]
       public IHttpActionResult sendmail(EmailClass ec)
        {
            try
            {
                string subject = ec.subject;
                string body = ec.body;
                string to = ec.to;
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("sdg.tracker1@gmail.com");
                mm.To.Add(to);
                mm.Subject = subject;
                mm.Body = @body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = true;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("sdg.tracker1@gmail.com", "sdg@1234");
                smtp.Send(mm);
                return Json(ec);

            }
            catch (Exception ex)
            {                
                throw ex;
            }
            }

    }
}
