using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using WebShop.Models;
using WebShop.Context;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        WebShopDb context = new WebShopDb();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Administrator user)
        {
            WebShopDb context = new WebShopDb();
            // check if user has entered the admin account
            if(user.Username==context.Administrators.FirstOrDefault().Username)
            {
                if(user.Password==context.Administrators.FirstOrDefault().Password)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, true);

                    // all good - redirect the user to admin panel
                    return RedirectToAction("Index", "Admin"); 

                }
                else
                {
                    // wrong password
                    ModelState.AddModelError("WrongPW", "Wrong password. Please try again.");
                }
            }
            else
            { // username is wrong
                ModelState.AddModelError("WrongLogin", "There is no account with such details.");
            }
            return View();
        }
        // Only for administrators
        [Authorize] 
        public ActionResult AdminPanel()
        {
            return View();
        }
        [Authorize]
        public ActionResult Logoff()
        {
            // Delete the user details from cache.
            Session.Abandon();

            // Delete the authentication ticket and sign out.
            FormsAuthentication.SignOut();

            
            return RedirectToAction("Index");
        }
     
	}
}