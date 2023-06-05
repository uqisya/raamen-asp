using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Repository
{
    public class UserRepository
    {
        static RamenDatabase2Entities2 db = new RamenDatabase2Entities2();

        public static void addUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User loginUser(String username, String password)
        {
            User user = (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();
            return user;
        }
    }
}