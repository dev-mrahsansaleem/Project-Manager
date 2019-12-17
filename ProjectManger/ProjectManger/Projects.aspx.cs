using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProjectManger
{
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            lblMsg.ForeColor = System.Drawing.Color.Red;
            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "insert into [dbo].[Projects] ([ProName],[ProDescription]) values(@ProName,@ProDes)";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
                sqlCon.Open();
                if (txtProjectName.Text.Trim() != "")
                {
                    sqlcom.Parameters.AddWithValue("@ProName", txtProjectName.Text.Trim());
                    if(txtProDescription.Text.Trim()!="")
                    {
                        sqlcom.Parameters.AddWithValue("@ProDes", txtProDescription.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        sqlCon.Close();
                        lblMsg.ForeColor = System.Drawing.Color.Green;
                        lblMsg.Text = txtProjectName.Text + " added successfully";
                        //reset
                        txtProjectName.Text = "";
                        txtProDescription.Text = "";
                    }
                    else
                    {
                        lblMsg.Text = "project description can not be empty";
                    }
                }
                else
                {
                    lblMsg.Text = "project name can not be empty";
                }

            }
            catch
            {
                lblMsg.Text = "unable to establish connection";
            }
        }
    }
}