using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using TMApp.Models;

namespace TMApp.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult EmailView()
        {

          
            return View();
        }
        [HttpPost]
        public ActionResult SendMail(Email model)
        {

            try
            {

                MailMessage mail = new MailMessage();
                mail.To.Add(model.Receiver);
                mail.From = new MailAddress("damyokunlola@gmail.com");
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("damilola.project1@gmail.com","Moodooapp1");
                client.EnableSsl = true;
               // client.DeliveryMethod = SmtpDeliveryMethod.Network;
                
             
                
                client.Send(mail);
                RedirectToAction("EmailView", "Email");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //var mail = new MailMessage();
            //mail.From = new MailAddress("damyokunlola@gmail.com");
            //mail.To.Add("damilola.project1@gmail.com");
            //mail.Subject = model.Subject;
            //mail.Body = string.Format(model.Body);
            //mail.IsBodyHtml = true;
            //using (var smtp= new SmtpClient())
            //{
            //    smtp.UseDefaultCredentials = false;
            //    smtp.EnableSsl = true;
            //    smtp.Send(mail);
            //   RedirectToAction("EmailView", "Email");
            //}

           
            //}
         



            //try
            //{
            //    if (ModelState.IsValid)
            //    {
            //        var SenderEmail = new MailAddress("damilola.project1@gmail.com", "Moodoo");
            //        var ReceiverEmail = new MailAddress(model.Receiver, "Receiver");
            //        var password = "Moodooapp1";
            //        var sub = model.Subject;
            //        var body = model.Body;
            //        var smtp = new SmtpClient
            //        {
            //            Host = "smtp.gmail.com",
            //            Port = 587,
            //            EnableSsl = true,
            //            DeliveryMethod=SmtpDeliveryMethod.Network,
            //            UseDefaultCredentials=false,
            //            Credentials= new NetworkCredential(SenderEmail.Address,password)

            //        };
            //        using (var mail = new MailMessage(SenderEmail, ReceiverEmail)
            //        {
                      
            //            Subject =model.Subject,
            //            Body=model.Body
            //        })
            //        {
            //            smtp.Send(mail);
            //        }
            //        RedirectToAction("EmailView", "Email");
              



            //    }
            //}
            //catch(Exception)
            //{
            //    ViewBag.Error = "some Error";
            //}

            return View("EmailView");
           
            }

        }
}