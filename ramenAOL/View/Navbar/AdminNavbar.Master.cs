using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View.Navbar
{
    public partial class AdminNavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnManageRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Ramen/ManageRamen.aspx");
        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Order/OrderQueue.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Order/History.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Order/Report.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/User/Profile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}