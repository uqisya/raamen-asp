﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View.Ramen
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //PreInit event of your desired page
        protected override void OnPreInit(EventArgs e)
        {
            ramenAOL.Model.User user = (ramenAOL.Model.User)Session["user"];

            if (!string.IsNullOrEmpty(Page.MasterPageFile))
            {
                if (user.RoleId == 1)
                {
                    Page.MasterPageFile = "~/View/Navbar/AdminNavbar.master";
                }
                else if (user.RoleId == 2)
                {
                    Page.MasterPageFile = "~/View/Navbar/StaffNavbar.master";
                }
            }
        }
    }
}