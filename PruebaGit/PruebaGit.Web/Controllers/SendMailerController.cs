using System.Web.Mvc;
using System.Net.Mail;
using PruebaGit.Web.Models;
using System.Net;
using System;
using System.Web;

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
        public void Index( string To, string Subject, string Body, HttpPostedFileBase fichero, string verificar)
        {
       
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;

                //If you need to authenticate
                client.Credentials = new NetworkCredential("danielv210796@gmail.com", "21julio1996AA");
                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress("danielv210796@gmail.com","Hospital Express");
                mailMessage.To.Add(To);
                mailMessage.Subject = Subject;
                mailMessage.Body = Body;

            if(verificar == "verificado")
            {
                string ruta = Server.MapPath("~/Upload/");
                fichero.SaveAs(ruta + "\\" + fichero.FileName);

                Attachment adjunto = new Attachment(ruta + "\\" + fichero.FileName);
                mailMessage.Attachments.Add(adjunto);
            }
        
                client.Send(mailMessage);
                ViewBag.Message = ("Mensaje enviado exitosamente");

          
        }
    }
}