using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View
{
    public partial class Admin : System.Web.UI.Page
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

                helloTxt.Text = "Hello, " + user.Username + "!";

                var listStaffDB = (from x in db.Users where x.RoleId == 2 select x);
                foreach (var x in listStaffDB)
                {
                    listStaff.Items.Add(x.Username);
                }
                Response.Redirect("~/View/Ramen/ManageRamen.aspx");
            }
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }

            Session.Remove("user");
            Response.Redirect("~/View/testing_session.aspx");
        }
    }
}