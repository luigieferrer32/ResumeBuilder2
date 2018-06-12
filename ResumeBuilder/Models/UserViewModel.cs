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
        public Nullable<int> IdPerson { get; set; }
        [DisplayName("Email Address:")]
        public string EmailAddress { get; set; }

        // public virtual PERSON PERSON { get; set; }

    }
}