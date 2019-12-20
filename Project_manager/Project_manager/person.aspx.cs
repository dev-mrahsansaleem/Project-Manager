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
    public partial class person : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79L809E;Initial Catalog=Project_Manager;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            type.Items.Insert(0, new ListItem("--Select--", "0"));
            type.Items.Insert(1, new ListItem("Student", "Student"));
            type.Items.Insert(2, new ListItem("Teacher", "Teacher"));

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into person values ('" + name.Text + "','" + fathername.Text + "','" + regNo.Text + "','" + type.SelectedValue + "')";
            cmd.ExecuteNonQuery();
            name.Text = "";
            fathername.Text = "";
            regNo.Text = "";
            type.SelectedValue = "0";
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            name.Text = "";
            fathername.Text = "";
            regNo.Text = "";
            type.SelectedValue = "0";
        }

        protected void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedValue == "Teacher")
            {
                regNo.Enabled = false;
            }
        }
    }
}