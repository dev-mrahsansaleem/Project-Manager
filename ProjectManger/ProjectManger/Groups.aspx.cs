using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManger
{
    public partial class Groups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;

            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "insert into [dbo].[Groups] ([GrpName],[AsignProName]) values(@grpName,@assignProName)";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);
            try
            {
                sqlCon.Open();
                if (txtGrpName.Text.Trim() != "")
                {
                    sqlcom.Parameters.AddWithValue("@grpName", txtGrpName.Text.Trim());
                    if(dpProjects.SelectedItem.Text.Trim()!="")
                    {
                        sqlcom.Parameters.AddWithValue("@assignProName", dpProjects.SelectedItem.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        sqlCon.Close();
                        lblMsg.ForeColor = System.Drawing.Color.Green;
                        lblMsg.Text = txtGrpName.Text + " added successfully";
                        //reset
                        txtGrpName.Text = "";
                    }
                    else
                    {
                        lblMsg.Text = "project can not be unselected";
                    }
                }
                else
                {
                    lblMsg.Text = "Group name can not be empty";
                }

            }
            catch
            {
                lblMsg.Text = "unable to establish connection";
            }
        }
    }
}