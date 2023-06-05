using ramenAOL.Handler;
using ramenAOL.Model;
using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Controller
{
    public class RamenController
    {
        // insert
        public static string insertRamen(int meatId, string name, string broth, string price)
        {
            if(name.Equals("") || broth.Equals("") || price.Equals(""))
            {
                return "Please fill all the field";
            }
            return RamenHandler.insertRamen(meatId, name, broth, price);
        }

        // update
        public static string updateRamen(int id, string name, string broth, string price)
        {
            if(name.Equals("") || broth.Equals("") || price.Equals(""))
            {
                return "Please fill all the field";
            }

            return RamenHandler.updateRamen(id, name, broth, price);
        }

        // getRamen based on id
        public static Raman getRamenBasedOnId(int id)
        {
            return RamenHandler.getRamenBasedOnId(id);
        }

        public static List<Raman> getAllRamen()
        {
            return RamenHandler.getAllRamen();
        }

    }
}