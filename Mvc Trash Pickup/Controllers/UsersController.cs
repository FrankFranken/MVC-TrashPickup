using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Mvc_Trash_Pickup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Trash_Pickup.Controllers
{
    public class UsersController : Controller
    {
        [Authorize]
        // GET: Users
       public ActionResult Index()   
        {
            ApplicationDbContext context = new ApplicationDbContext();
            if (User.Identity.IsAuthenticated)   
            {   
   
   
                if (!isAdminUser())   
                {   
                    return RedirectToAction("Index", "Home");   
                }   
            }   
            else   
            {   
                return RedirectToAction("Index", "Home");   
            }   
   
            var Roles = context.Roles.ToList();   
            return View(Roles);   
   
        }  

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}