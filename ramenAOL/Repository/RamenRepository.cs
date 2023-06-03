using ramenAOL.Factory;
using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ramenAOL.Repository
{
    public class RamenRepository
    {
        public static string insertRamen(string name, string broth, string price)
        {
            RamenDatabaseEntities1 db = new RamenDatabaseEntities1();

            Raman item = RamenFactory.insertRamen(name, broth, price);
            db.Ramen.Add(item);
            db.SaveChanges();

            return "success";
        }

        public static void deleteRamen(int id)
        {
            RamenDatabaseEntities1 db = new RamenDatabaseEntities1();

            Raman item = db.Ramen.Find(id);
            db.Ramen.Remove(item);
            db.SaveChanges();
        }

        public static string updateRamen(string name, string broth, string price)
        {
            RamenDatabaseEntities1 db = new RamenDatabaseEntities1();

            //Raman item = db.Ramen.Find(id);

            RamenFactory.updateRamen(name, broth, price);

            db.SaveChanges();

            return "success";
        }

        public static List<Raman> getRamen()
        {
            RamenDatabaseEntities1 db = new RamenDatabaseEntities1();
            List<Raman> item = (from x in db.Ramen select x).ToList<Raman>();

            return item;
        }
    }
}