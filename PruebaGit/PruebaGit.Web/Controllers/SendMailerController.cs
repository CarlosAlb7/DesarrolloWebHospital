using System.Web.Mvc;
using System.Net.Mail;
using PruebaGit.Web.Models;
using System.Net;
using System;

namespace PruebaGit.Web.Controllers
{
    public class SendMailerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SendMailer
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Index( string To, string Subject, string Body)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;

                //If you need to authenticate
                client.Credentials = new NetworkCredential("danielv210796@gmail.com", "21julio1996AA");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("danielv210796@gmail.com", "HospitalExpress");
                mailMessage.To.Add(To);
                mailMessage.Subject = Subject;
                mailMessage.Body = Body;

                client.Send(mailMessage);
                ViewBag.Message = ("Mensaje enviado exitosamente");

            }
            catch(Exception)
            {
                ViewBag.Error("No se envio el mensaje");
            }
        }
    }
}