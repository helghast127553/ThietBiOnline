using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThietBiOnline.Models.EF;
using ThietBiOnline.Common;

namespace ThietBiOnline.Models.DAO
{
    public static class UserDAO
    {
        public static int InsertUser(User user)
        {
            using (var db = new ThietBiOnlineEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user.ID;
            }          
        }
       public static int CheckUser(string userName, string password)
        {
            User user = null; 
            using (var db = new ThietBiOnlineEntities())
            {
                user = db.Users.SingleOrDefault(x => x.UserName == userName);
            }
            if (user == null)
                return 0;
            else
            {
                if (user.Password == password)
                    return 1;
                else
                    return -2;
            }
        }
        public static User GetByID(string userName)
        {
            User user = null;
            using (var db = new ThietBiOnlineEntities())
            {
                user = db.Users.SingleOrDefault(x => x.UserName == userName);
            }
            return user;
        }
    }
}