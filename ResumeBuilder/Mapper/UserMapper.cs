using DataAccess;
using ResumeBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeBuilder.Mapper
{
    public class UserMapper
    {
        public USER UserViewModelToUser(UserViewModel user)
        {
           
                return new USER()
                {
                    USER_ID = user.UserId,
                    USERNAME = user.UserName,
                    EMAIL_ADDRESS = user.EmailAddress,
                    PASSWORD = user.Password,
                    FIRST_NAME = user.FirstName,
                    LAST_NAME = user.LastName,
                    STREET_ADDRESS = user.StreetAddress,
                    CITY = user.City,
                    STATE_PROVINCE = user.StateProvince,
                    ZIPCODE = user.ZipCode,
                    DATE_OF_BIRTH = user.DateOfBirth,
                    NUMBER = user.Number
                };
        
        }
    }
}