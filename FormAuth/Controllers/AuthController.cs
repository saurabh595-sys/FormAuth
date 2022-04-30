using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormAuth.Models;
using System.Web.Security;

namespace FormAuth.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //[Authorize(Roles = "")]
        public ActionResult Login(UserDetail ud)
        {
            using(var contex = new Contex() )
            {
                bool isvalid = contex.UserDetails.Any(x =>x.UserName ==ud.UserName && x.Password == ud.Password);
                if (isvalid)
                {
                    FormsAuthentication.SetAuthCookie(ud.UserName,false);
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User Name and Password");
                    return View();
                }
                
            }
               
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(UserDetail ud)
        {
            
                using (var contex = new Contex())
                {
                    contex.UserDetails.Add(ud);
                    contex.SaveChanges();
                
                }
            return RedirectToAction("Login");

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
          
        }
        

    }
}