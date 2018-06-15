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
