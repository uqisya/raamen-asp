using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Factory
{
    public class RamenFactory
    {
        // insert
        public static Raman insertRamen(string name, string broth, string price)
        {
            Raman item = new Raman();
            // tambah drop down untuk type id meat dari table Meat

            item.Name = name;
            item.Broth = broth;
            item.Price = price;

            return item;
        }

        // update
        public static Raman updateRamen(string name, string broth, string price)
        {
            Raman item = new Raman();

            item.Name = name;
            item.Broth = broth;
            item.Price = price;

            return item;
        }
    }
}