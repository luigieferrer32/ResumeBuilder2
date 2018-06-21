using BusinessLogic.Manager;
using DataAccess;
using ResumeBuilder.Mapper;
using ResumeBuilder.Models;
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
            ViewBag.UserId = user.USER_ID;
            return Json(new { access = access }, JsonRequestBehavior.AllowGet);
          
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        public JsonResult RegisterUser(UserViewModel model)
        {
            UserMapper userMapper = new UserMapper();
            UserManager userManager = new UserManager();
            var user = userMapper.UserViewModelToUser(model);
            userManager.RegisterUser(user);
            var status = true;
            return Json(new { status = status }, JsonRequestBehavior.AllowGet);
        }

    }
}