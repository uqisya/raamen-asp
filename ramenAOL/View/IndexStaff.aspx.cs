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
            ramenGV.DataSource = RamenRepository.getRamen();
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

        protected void ramenGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void ramenGV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void ramenGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}