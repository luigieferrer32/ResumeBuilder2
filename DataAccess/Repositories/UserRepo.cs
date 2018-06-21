using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repositories
{
    public class UserRepo
    {
        //database modify
        public void Create(USER entity)
        {
            using(var context = new ResumeBuilderEntities())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public USER Update (USER entity)
        {
             
            using (var context = new ResumeBuilderEntities())
            {
                //var item = context.USERs.Where(x => x.USER_ID == 10).First();
                //item.FIRST_NAME = entity.FIRST_NAME;
                //item.LAST_NAME = entity.LAST_NAME;
                //item.STREET_ADDRESS = entity.STREET_ADDRESS;
                // item.CITY = entity.CITY;
                // item.STATE_PROVINCE = entity.STATE_PROVINCE;
                // item.ZIPCODE = entity.ZIPCODE;
                // item.DATE_OF_BIRTH = entity.DATE_OF_BIRTH;
                // item.NUMBER = entity.NUMBER;
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            return entity;
        }

        public void Delete(UserRepo entity)
        {
            using (var context = new ResumeBuilderEntities())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        

        public USER RetrieveByName (string name)
        {
            using (var context = new ResumeBuilderEntities())
            {
                return context.Set<USER>().Where(x => x.USERNAME == name).SingleOrDefault();
            }
        }

        public USER RetrieveByID(int ID)
        {
            using (var context = new ResumeBuilderEntities())
            {
                return context.Set<USER>().Where(x => x.USER_ID == ID).SingleOrDefault();
            }
        }
    }
}
