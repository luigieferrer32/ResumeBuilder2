using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeBuilder.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            var genderList = new List<SelectListItem>
            {

                new SelectListItem{Text = "Male", Value = "M"},
                new SelectListItem{Text = "Female", Value = "F"}
            };
            ViewBag.Gender = new SelectList(genderList, "Value", "Text");


            return View();
        }
       

    }
}