using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_manager
{
    public partial class evaluation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79L809E;Initial Catalog=Project_Manager;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from groups";
            DropDownList1.DataSource = cmd.ExecuteReader();
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
            con.Close();
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into evaluation values ('" + DropDownList1.SelectedValue + "','" + Convert.ToInt32(totalmarks.Text) + "','" + Convert.ToInt32(obtainedmarks.Text) + "')";
            cmd.ExecuteNonQuery();
            totalmarks.Text = "";
            obtainedmarks.Text = "";
            DropDownList1.SelectedValue = "0";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}