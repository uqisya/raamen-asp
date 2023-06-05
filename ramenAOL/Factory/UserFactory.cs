using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Factory
{
    public class UserFactory
    {
        public static User addUser(String username, String email, String gender, String password)
        {
            User user = new User();
            user.RoleId = 3;
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            return user;
        }
    }
}