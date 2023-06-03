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
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // ambil info dari frontend ke BE
            string name = txtName.Text;
            string broth = txtBroth.Text;
            string price = txtPrice.Text;

            lblStatus.Text = RamenController.insertRamen(name, broth, price);

            // masih belum bisa update otomatis karena return statusnya jadi ga muncul kalo di redirect
            Response.Redirect("~/View/IndexStaff.aspx");
        }
    }
}