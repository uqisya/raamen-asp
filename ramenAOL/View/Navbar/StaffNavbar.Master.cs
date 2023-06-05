using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View.Navbar
{
    public partial class StaffNavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/User/Home.aspx");
        }

        protected void btnManageRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Ramen/ManageRamen.aspx");
        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Order/OrderQueue.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/User/Profile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }

            Session.Remove("user");
            // samain foldernya
            Response.Redirect("~/View/login.aspx");
        }
    }
}