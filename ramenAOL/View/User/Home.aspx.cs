using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View.User
{
    public partial class Home : System.Web.UI.Page
    {
        private RamenDatabase2Entities2 db = new RamenDatabase2Entities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/testing_session.aspx");
            }
            else
            {
                ramenAOL.Model.User user;
                if (Session["user"] == null)
                {
                    int id = int.Parse(Request.Cookies["user_cookie"].Value);
                    user = (from x in db.Users where x.Id == id select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (ramenAOL.Model.User)Session["user"];
                }

                lblUsername.Text = user.Username;

                var listStaffDB = (from x in db.Users where x.RoleId == 2 select x);
                foreach (var x in listStaffDB)
                {
                    listStaff.Items.Add(x.Username);
                }

                if(user.RoleId == 1)
                {
                    adminContentPlaceHolder.Visible = true;
                    staffContentPlaceHolder.Visible = false;
                }
                else if(user.RoleId == 2){
                    adminContentPlaceHolder.Visible = false;
                    staffContentPlaceHolder.Visible = true;
                }
                //Response.Redirect("~/View/Ramen/ManageRamen.aspx");
            }
        }

        //PreInit event of your desired page
        protected override void OnPreInit(EventArgs e)
        {
            ramenAOL.Model.User user = (ramenAOL.Model.User)Session["user"];

            if (!string.IsNullOrEmpty(Page.MasterPageFile))
            {
                if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/View/testing_session.aspx");
                }

                if (user.RoleId == 1)
                {
                    Page.MasterPageFile = "~/View/Navbar/AdminNavbar.master";
                }
                else if (user.RoleId == 2)
                {
                    Page.MasterPageFile = "~/View/Navbar/GuestNavbar.master";
                }
                
            }
        }
    }
}