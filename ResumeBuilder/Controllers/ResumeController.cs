using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeBuilder.Mapper;
using ResumeBuilder.Models;
using BusinessLogic.Manager;
using DataAccess.Repositories;
using DataAccess;
using ResumeBuilder.ViewModel;


namespace ResumeBuilder.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IResumeRepo resumeRepo;
        public ResumeController(IResumeRepo resumeRepository)
        {
            resumeRepo = resumeRepository;
        }
        // GET: Resume
        public ActionResult Resume()
        {
            
            return View();
        }

        //public JsonResult UpdateAssistance(UserViewModel model)
        // {

        //     UserMapper userMapper = new UserMapper();
        //     UserRepo userRepo = new UserRepo();



        //     var UpdatedModel = userRepo.Update(userMapper.UserViewModelToResume(model));
        //     return Json(new { UpdatedModel }, JsonRequestBehavior.AllowGet);

        // }
        //[HttpPost]
        //[ActionName("PersonnalInformtion")]
        //public ActionResult PersonnalInformtion(PersonInfoVM model)
        //{
        //    if (ModelState.IsValid)
        //    {
                
        //    }
          
        //}
}