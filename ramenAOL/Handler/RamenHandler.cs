using ramenAOL.Factory;
using ramenAOL.Model;
using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Handler
{
    public class RamenHandler
    {
        // insert
        public static string insertRamen(string name, string broth, string price)
        {
            Raman item = RamenFactory.insertRamen(name, broth, price);
            return RamenRepository.insertRamen(item);
        }

        // update
        public static string updateRamen(int id, string name, string broth, string price)
        {
            return RamenRepository.updateRamen(id, name, broth, price);
        }

        // getRamen based on id
        public static Raman getRamenBasedOnId(int id)
        {
            return RamenRepository.getRamenBasedOnId(id);
        }

        public static List<Raman> getAllRamen()
        {
            return RamenRepository.getAllRamen();
        }
    }
}