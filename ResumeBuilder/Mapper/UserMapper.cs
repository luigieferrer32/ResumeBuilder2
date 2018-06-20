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

        public USER UserViewModelToResume(UserViewModel user)
        {
            //ResumeBuilderEntities context = new ResumeBuilderEntities();
            //var item = context.USERs.Where(x => x.USER_ID == 10).First();
            //Console.WriteLine(item.USERNAME.ToString());
            //item.FIRST_NAME = user.FirstName;
            //item.LAST_NAME = user.LastName;


            return new USER()
            {
              
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