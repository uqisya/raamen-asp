using ramenAOL.Factory;
using ramenAOL.Model;
using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Handler
{
    public class UserHandler
    {
        public static string addUser(String username, String email, String gender, String password)
        {
            User user = UserFactory.addUser(username, email, gender, password);
            UserRepository.addUser(user);
            return "User registered success";
        }

        public static User loginUser(String username, String password)
        {
            User user = UserRepository.loginUser(username, password);
            return user;
        }
    }
}