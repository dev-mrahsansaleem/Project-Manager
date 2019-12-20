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
    public partial class groups : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79L809E;Initial Catalog=Project_Manager;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (!Page.IsPostBack)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from person where type='Student'";
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from person where type='Student'";
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from person where type='Student'";
                DropDownList3.DataSource = cmd.ExecuteReader();
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from person where type='Student'";
                DropDownList4.DataSource = cmd.ExecuteReader();
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from projects";
                DropDownList5.DataSource = cmd.ExecuteReader();
                DropDownList5.DataBind();
                DropDownList5.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();


                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *from person where type='Teacher'";
                DropDownList6.DataSource = cmd.ExecuteReader();
                DropDownList6.DataBind();
                DropDownList6.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into groups values('" + DropDownList1.SelectedValue + ',' + DropDownList2.SelectedValue + ',' + DropDownList3.SelectedValue + ',' + DropDownList4.SelectedValue + "','" + DropDownList5.SelectedValue + "','" + DropDownList6.SelectedValue + "')";
            cmd.ExecuteNonQuery();
            DropDownList1.SelectedValue = "0";
            DropDownList2.SelectedValue = "0";
            DropDownList3.SelectedValue = "0";
            DropDownList4.SelectedValue = "0";
            DropDownList5.SelectedValue = "0";
            DropDownList6.SelectedValue = "0";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}