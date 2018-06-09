using System;
using DataAccess;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Manager
{
    class UserManager
    {
        public void SavePersonInfo(PERSON person)
        {
            UserRepo userRepo = new UserRepo();
            //userRepo.Create(person);
        }
    }
}
