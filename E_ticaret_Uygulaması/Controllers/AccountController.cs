using E_ticaret_Uygulaması.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_ticaret_Uygulaması.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
           var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            userManager = new UserManager<ApplicationUser>(userStore);
            var roleStore=new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager= new RoleManager<ApplicationRole>(roleStore);
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
    }
}