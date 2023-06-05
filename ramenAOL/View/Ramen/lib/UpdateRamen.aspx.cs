using ramenAOL.Controller;
using ramenAOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ramenAOL.View.Ramen
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Raman item = RamenController.getRamenBasedOnId(id);
                txtName.Text = item.Name;
                txtBroth.Text = item.Borth;
                txtPrice.Text = item.Price;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // ambil id nya
            int id = int.Parse(Request.QueryString["id"]);

            // ambil value dari textbox
            string name = txtName.Text;
            string broth = txtBroth.Text;
            string price = txtPrice.Text;

            // update
            RamenController.updateRamen(id, name, broth, price);

            // redirect ke index staff
            Response.Redirect("~/View/Ramen/ManageRamen.aspx");
        }

    }
}