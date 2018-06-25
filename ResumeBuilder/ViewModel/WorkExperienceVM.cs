using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ResumeBuilder.ViewModel
{
    public class WorkExperienceVM
    {
        public int IDExp { get; set; }
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<SelectListItem> StartMonth { get; set; }
        public List<SelectListItem> StartYear { get; set; }
        public List<SelectListItem> EndMonth { get; set; }
        public List<SelectListItem> EndYear { get; set; }
      
      

        
    }
}