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
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "insert into [dbo].[Users] ([Uname],[UrollNo],[Ugroup],[UType],[Uproject]) values(@UName,@UrollNo,@Ugroup,@UType)";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);
            try
            {
                sqlCon.Open();
                if (txtUserName.Text.Trim() != "")
                {
                    sqlcom.Parameters.AddWithValue("@UName", txtUserName.Text.Trim());
                    if (txtRollNo.Text.Trim() != "")
                    {
                        sqlcom.Parameters.AddWithValue("@UrollNo", txtRollNo.Text.Trim());
                        if (txtUserName.Text.Trim() != "")
                        {
                            sqlcom.Parameters.AddWithValue("@Ugroup", dbUserGroup.SelectedItem.Text.Trim());
                            if (txtUserName.Text.Trim() != "")
                            {
                                sqlcom.Parameters.AddWithValue("@UType", dbUserType.SelectedItem.Text.Trim());
                                //sqlcom.Parameters.AddWithValue("@Uproject", dbUserProject.SelectedItem.Text.Trim());
                                sqlcom.ExecuteNonQuery();
                                sqlCon.Close();


                                


                                lblMsg.ForeColor = System.Drawing.Color.Green;
                                lblMsg.Text = txtUserName.Text + " is added successfully";
                                //reset
                                txtUserName.Text = "";
                                txtRollNo.Text = "";
                            }
                            else
                            {
                                lblMsg.Text = "User Type can not be unselected";
                            }
                        }
                        else
                        {
                            lblMsg.Text = "User group can not be unselected";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "User roll no can not be empty";
                    }
                }
                else
                {
                    lblMsg.Text = "User name can not be empty";
                }
            }
            catch
            {
                lblMsg.Text = "unable to establish connection";
            }
        }

        protected void dbUserGroup_TextChanged(object sender, EventArgs e)
        {
            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "SELECT [AsignProName] FROM [Groups] where [GrpName]='" + dbUserGroup.SelectedItem.Text + "'";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);

            sqlCon.Open();

            using (SqlDataReader sdr = sqlcom.ExecuteReader())
            {
                sdr.Read();
                txtUserProject.Text = sdr["AsignProName"].ToString();
            }
            sqlCon.Close();
        }

        protected void dbUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            string mainCon = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(mainCon);
            string sqlQuery = "SELECT [AsignProName] FROM [Groups] where [GrpName]='" + dbUserGroup.SelectedItem.Text + "'";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlCon);

            sqlCon.Open();

            using (SqlDataReader sdr = sqlcom.ExecuteReader())
            {
                sdr.Read();
                txtUserProject.Text = sdr["AsignProName"].ToString();
            }
            sqlCon.Close();
        }
    }
}