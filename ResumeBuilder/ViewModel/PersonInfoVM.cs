using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ResumeBuilder.ViewModel
{
    public class PersonInfoVM
    {
        public int IDPers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Phone { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
    }
}