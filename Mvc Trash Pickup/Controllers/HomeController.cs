using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Trash_Pickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "New Pick Up Changes.";

            return View();
        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Work Schedules.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email); //Email which you are getting 
                    //from contact us page 
                    msz.To.Add("emailaddrss@gmail.com"); //Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                        ("youremailid@gmail.com", "password");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public class ContactViewModel
        {
            internal string Email;
            internal string Message;
            internal string Subject;
        }
    }
}


//ViewBag.TheMessage = "Send us a message.";

        //return View();
//    }
//    [HttpPost]
//    public ActionResult Contact(string message)
//            ViewBag.TheMessage = "Thanks for your Message, we'll get back to you ASAP.";
//            return View();
//}
