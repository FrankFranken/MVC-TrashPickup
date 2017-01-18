﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Mvc_Trash_Pickup.Controllers;
using Mvc_Trash_Pickup.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_Trash_Pickup.Startup))]
namespace Mvc_Trash_Pickup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
            new Controllers.UsersController();
        }


       
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            if (roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
            if (roleManager.RoleExists("Admin"))
            {  
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);                

                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@email.com";               
                string userPWD = "password";
                var chkUser = userManager.Create(user, userPWD); 

                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admin");
                }
            }
  
            if (roleManager.RoleExists("Employee"))
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "Employee1";
                user.Email = "Employee1@email.com";
                string userPWD = "password";
                var chkUser = userManager.Create(user, userPWD);
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Employee");
                }
            }
        }
    }
}

