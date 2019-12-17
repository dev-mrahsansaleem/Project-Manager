using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectManger
{
    public partial class Types : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "insert into [dbo].[UserTypes] (TypeName) values(@TypeName)";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);
            try
            {
                sqlCon.Open();
                if (txtTypeName.Text.Trim() != "")
                {
                    sqlcom.Parameters.AddWithValue("@TypeName", txtTypeName.Text.Trim());
                    sqlcom.ExecuteNonQuery();
                    sqlCon.Close();
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Text = txtTypeName.Text +" user type added successfully";
                    //reset
                    txtTypeName.Text = "";
                }
                else
                {
                    lblMsg.Text = "Type name can not be empty";
                }
                
            }
            catch
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "unable to establish connection";
            }
            
        }
    }
}