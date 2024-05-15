﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Factory;
using WebApplication.Model;
using WebApplication.Repository;

namespace WebApplication.Handlers
{
    public class RamenHandler
    {
        public static string InsertRamen(string name, string meatName, string broth, string price)
        {
            Meat meat = RamenFactory.CreateMeat(meatName);
            Raman ramen = RamenFactory.CreateRamen(name, meat, broth, price);
            return RamenRepository.Insert(ramen);
        }

        public static void InsertMeat(string name)
        {
            Meat meat = RamenFactory.CreateMeat(name);
            MeatRepository.InsertMeat(meat);
        }

        public static Raman GetRamenById(int id)
        {
            return RamenRepository.GetRamenById(id);
        }

        public static Meat GetMeatById(int id)
        {
            return MeatRepository.GetMeatById(id);
        }

        public static bool DeleteRamen(int id)
        {
            return RamenRepository.Delete(id);
        }
        public static string UpdateRamen(int id, string name, string broth, string meat, string price)
        {
            return RamenRepository.UpdateRamenById(id, name, broth, meat, price);
        }

        public static bool UpdateMeat(int id, string meatName)
        {
            return MeatRepository.UpdateMeat(id, meatName);
        }

        public static List<Raman> GetAllRamen()
        {
            return RamenRepository.GetRamens();
        }

        public static List<Meat> GetAllMeat()
        {
            return MeatRepository.GetMeats();
        }
    }
}