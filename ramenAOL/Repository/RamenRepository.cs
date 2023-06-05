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
        static RamenDatabase2Entities2 db = new RamenDatabase2Entities2();
        public static string insertRamen(Raman item)
        {
            //Raman item = RamenFactory.insertRamen(name, broth, price);

            db.Ramen.Add(item);
            db.SaveChanges();

            return "success";
        }

        public static string updateRamen(int id, string name, string broth, string price)
        {
            Raman item = db.Ramen.Find(id);

            item.Name = name;
            item.Borth = broth;
            item.Price = price; 

            db.SaveChanges();

            return "success";
        }

        // get ramen based on id
        public static Raman getRamenBasedOnId(int id)
        {
            return db.Ramen.Find(id);
        }

        public static void deleteRamen(int id)
        {
            //RamenDatabaseEntities1 db = new RamenDatabaseEntities1();

            Raman item = db.Ramen.Find(id);
            db.Ramen.Remove(item);
            db.SaveChanges();
        }

        // get all item ramen
        //public static List<Raman> getRamen()
        //{
        //    //RamenDatabaseEntities1 db = new RamenDatabaseEntities1();
        //    List<Raman> item = (from x in db.Ramen select x).ToList<Raman>();

        //    return item;
        //}

        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }
    }
}