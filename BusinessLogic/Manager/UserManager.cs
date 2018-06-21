using System;
using DataAccess;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager
{
    public class UserManager
    {
        public bool AuthenticateUser(USER user)
        {
            UserRepo userRepo = new UserRepo();
            bool AccessStatus = false;

            var dataUser = userRepo.RetrieveByName(user.USERNAME);

            if (dataUser != null)
            {
                if (dataUser.PASSWORD == user.PASSWORD)
                {
                    AccessStatus = true;
                    user.USER_ID = dataUser.USER_ID;
                }
            }
            return AccessStatus;
        }


        public void RegisterUser(USER user)
        {
            UserRepo userRepo = new UserRepo();
            userRepo.Create(user);

        }


        public void GetUserID(USER user)
        {
            UserRepo userRepo = new UserRepo();
            var dataUser = userRepo.RetrieveByID(user.USER_ID);
            if (dataUser != null)
            {
                dataUser.USER_ID = user.USER_ID;
            }
        }


    }
}
