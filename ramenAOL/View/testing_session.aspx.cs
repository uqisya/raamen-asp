using ramenAOL.Controller;
using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View
{
    public partial class testing_session : System.Web.UI.Page
    {
        private RamenDatabase2Entities2 db = new RamenDatabase2Entities2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String username = userTxt.Value;
            String password = passTxt.Value;
            bool isRemember = rememberMe.Checked;

            // validasi
            ramenAOL.Model.User user = new ramenAOL.Model.User();
            (errLbl.Text, user) = UserController.userLogin(username, password);

            if (user != null)
            {
                Session["user"] = user;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.Id.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                if (user.RoleId == 1)
                {
                    Response.Redirect("~/View/User/Home.aspx");
                }
                else if (user.RoleId == 2)
                {
                    Response.Redirect("~/View/Staff.aspx");
                }
                else if (user.RoleId == 3)
                {
                    Response.Redirect("~/View/Member.aspx");
                }
            }
        }
    }
}