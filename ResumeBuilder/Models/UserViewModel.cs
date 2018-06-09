using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeBuilder.Models
{
    public class UserViewModel
    {
        public string Firstname     { get; set; }
        public string Lastname      {get; set;}
        public string Middlename    {get; set;}
        public string Address       {get; set;}
        public string City           {get; set;}
        public string Provice       {get; set;}
        public string Zipcode       {get; set;}
        public Nullable<DateTime> Birthdate {get; set;}
        public string EmailAddress  {get; set;}
        public int ContactNo {get; set;}
}
}