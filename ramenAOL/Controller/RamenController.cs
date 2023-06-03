using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Controller
{
    public class RamenController
    {
        public static string insertRamen(string name, string broth, string price)
        {
            if(name.Equals("") || broth.Equals("") || price.Equals(""))
            {
                return "Please fill all the field";
            }

            return RamenRepository.insertRamen(name, broth, price);
        }

    }
}