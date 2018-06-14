using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ResumeBuilder.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [DisplayName("User Name:")]
        public string Password { get; set; }
        //public Nullable<int> IdPerson { get; set; }
        [DisplayName("Email Address:")]
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipCode { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Number { get; set; }

        // public virtual PERSON PERSON { get; set; }

    }
}