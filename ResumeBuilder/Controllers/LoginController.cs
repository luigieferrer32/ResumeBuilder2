using BusinessLogic.Manager;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ResumeBuilder.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public JsonResult AuthenticateUser(USER user)
        {
            UserManager userManager = new UserManager();
            var access = userManager.AuthenticateUser(user);

            return Json(new { access = access }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

    }
}