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
    public class RoleController : Controller
    {
        
        // GET: Role
        public ActionResult Index()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            if (User.Identity.IsAuthenticated)
            {
                if (!isAdminUser())
                {
                    return RedirectToAction("Index", "Role");
                }
            }
            else
            {
                return RedirectToAction("Index", "Role");
            }

            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        public bool isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = userManager.GetRoles(user.GetUserId());
                if (s[0] == "Admin")
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