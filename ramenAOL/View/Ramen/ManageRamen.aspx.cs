using ramenAOL.Controller;
using ramenAOL.Repository;
using System;
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
            ramenAOL.Model.User user = (ramenAOL.Model.User)Session["user"];
            ramenGV.DataSource = RamenController.getAllRamen();
            ramenGV.DataBind();

            //lblUsername.Text = user.Username;
        }

        //PreInit event of your desired page
        protected override void OnPreInit(EventArgs e)
        {
            ramenAOL.Model.User user = (ramenAOL.Model.User)Session["user"];

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/testing_session.aspx");
            }

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

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // ambil id berdasarkan kolom dan row yg diklik
            GridViewRow row = ramenGV.Rows[e.RowIndex];

            int id = int.Parse(row.Cells[1].Text.ToString());

            // entities
            RamenRepository.deleteRamen(id);
            Response.Redirect("~/View/Ramen/ManageRamen.aspx");
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // ambil id, kita ambil row yang lagi diklik
            GridViewRow row = ramenGV.Rows[e.NewEditIndex];

            // ambil kolom si id nya
            int id = int.Parse(row.Cells[1].Text);

            // passing id ke page update page pake query string
            Response.Redirect("~/View/Ramen/lib/UpdateRamen.aspx?id=" + id);
        }

        protected void btnInsertRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Ramen/lib/InsertRamen.aspx");
        }
    }
}