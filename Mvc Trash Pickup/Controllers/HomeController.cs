using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult PickUps()
        {
            ViewBag.Message = "Pick Up Schedules.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Send us a message.";
  
            return View();
        }
        //[HttpPost]
        //public ActionResult Contact(string message)
        //    ViewBag.TheMessage = "Thanks for your Message, we'll get back to you ASAP.";
        //    return View();

        


    }
}