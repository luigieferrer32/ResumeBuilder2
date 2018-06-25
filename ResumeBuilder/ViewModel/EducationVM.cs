using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ResumeBuilder.ViewModel
{
    public class EducationVM
    {
        public int IDEdu { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLocation { get; set; }
        public List<SelectListItem> Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public string GraduationYear { get; set; }
    }
}