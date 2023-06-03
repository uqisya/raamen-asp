using ramenAOL.Controller;
using ramenAOL.Model;
using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View
{
    public partial class IndexStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = RamenController.getAllRamen();
            ramenGV.DataBind();
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // ambil id berdasarkan kolom dan row yg diklik
            GridViewRow row = ramenGV.Rows[e.RowIndex];

            int id = int.Parse(row.Cells[1].Text.ToString());

            // entities
            RamenRepository.deleteRamen(id);
            Response.Redirect("~/View/IndexStaff.aspx");
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // ambil id, kita ambil row yang lagi diklik
            GridViewRow row = ramenGV.Rows[e.NewEditIndex];

            // ambil kolom si id nya
            int id = int.Parse(row.Cells[1].Text);

            // passing id ke page update page pake query string
            Response.Redirect("~/View/Ramen/UpdateRamen.aspx?id=" + id);
        }
    }
}