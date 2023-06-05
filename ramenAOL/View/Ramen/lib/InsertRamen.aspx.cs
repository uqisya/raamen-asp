using ramenAOL.Controller;
using ramenAOL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Syauq\source\repos\projectAOL\ramenAOL\ramenAOL\App_Data\RamenDatabase2.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                SqlCommand cmd = new SqlCommand("select * from Meat", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);

                ddlMeatId.DataSource = data;
                ddlMeatId.DataTextField = "Name";
                ddlMeatId.DataValueField = "Id";
                ddlMeatId.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Syauq\source\repos\projectAOL\ramenAOL\ramenAOL\App_Data\RamenDatabase2.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Meat where Id = '" + ddlMeatId.SelectedValue + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            // ambil info dari frontend ke BE
            int meatId = int.Parse(dr["Id"].ToString());
            string name = txtName.Text;
            string broth = txtBroth.Text;
            string price = txtPrice.Text;

            lblStatus.Text = RamenController.insertRamen(meatId, name, broth, price);

            // masih belum bisa update otomatis karena return statusnya jadi ga muncul kalo di redirect
            Response.Redirect("~/View/Ramen/lib/ManageRamen.aspx");
        }
    }
}