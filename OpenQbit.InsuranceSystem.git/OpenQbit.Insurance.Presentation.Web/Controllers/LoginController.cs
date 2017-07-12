using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Security.Claims;
using Microsoft.Owin.Security;
using Microsoft.Owin;

namespace OpenQbit.Insurance.Presentation.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password, string userRole)
        {
            //using System.Security.Claims;
            //using Microsoft.Owin.Security;
            //using Microsoft.Owin;

            //  _db.SystemUser.Where( u => u.Name)
            ClaimsIdentity identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.NameIdentifier, userName),
                new Claim(ClaimTypes.Role, userRole)
            },
            "ApplicationCookie");


            IOwinContext ctx = Request.GetOwinContext();
            IAuthenticationManager authManager = ctx.Authentication;

            AuthenticationProperties authenticationproperties = new
                        AuthenticationProperties
            { IsPersistent = false };
            authManager.SignIn(authenticationproperties, identity);


            if (userRole.Equals("2"))
            {
                return RedirectToAction("Index", "Provinces");
            }
            else if (userRole.Equals("0"))
            {
                return RedirectToAction("Index", "Insurance");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logoff()
        {
            IOwinContext ctx = Request.GetOwinContext();
            IAuthenticationManager authManager = ctx.Authentication;
            authManager.SignOut("ApplicationCookie");

            return RedirectToAction("Login", "Login");
        }
    }
}