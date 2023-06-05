using ramenAOL.Handler;
using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Controller
{
    public class UserController
    {
        public static String addUser(String username, String email, String gender, String password, String confirmPass)
        {
            if (username.Equals("") || email.Equals("") || password.Equals("") || confirmPass.Equals(""))
            {
                return "All field must be filled";
            }
            else if ((username.Length < 5 || username.Length > 15) || !(username.All(Char.IsLetter)))
            {
                return "Length must be between 5 and 15 and alphabet with space only.";
            }
            else if (!email.EndsWith(".com"))
            {
                return "Email must ends with ‘.com’.";
            }
            else if (gender == "")
            {
                return "Gender must be chosen";
            }
            else if (!password.Equals(confirmPass))
            {
                return "Password must be the same with confirm password.";
            }
            else if (!confirmPass.Equals(password))
            {
                return "Confirm password must be the same with password.";
            }
            return UserHandler.addUser(username, email, gender, password); ;
        }

        public static (String, User) userLogin(String username, String password)
        {
            // validasi
            if (username == "" && password == "")
            {
                return ("username and password may not be empty!", null);
            }
            else if (username == "")
            {
                return ("username may not be empty!", null);
            }
            else if (password == "")
            {
                return ("password may not be empty!", null);
            }

            // check user in db
            User user = UserHandler.loginUser(username, password);

            if (user == null)
            {
                return ("user not found!", null);
            }

            return ("success", user);
        }
    }
}