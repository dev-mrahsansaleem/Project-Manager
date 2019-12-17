using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManger
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            try
            {
                Convert.ToInt32(txtAdminId.Text);//admin id must notbe an int type only there must be atleast 1 char
                lblMsg.Text = "admin Id Contain invlaid Charcters";
            }
            catch
            {
                try
                {
                    Convert.ToInt32(txtPassword.Text);//admin password must notbe an int type only there must be atleast 1 char
                    lblMsg.Text = "admin Password Contain invlaid Charcters";
                }
                catch
                {
                    if(txtAdminId.Text.Trim().ToUpper()=="ADMIN")
                    {
                        if(txtPassword.Text.Trim().ToUpper()=="ADMIN123")
                        {
                            Session["adminName"] = "welcome " + txtAdminId.Text.Trim().ToUpper();
                            //valid user
                            Response.Redirect("AdminPage.aspx");
                        }
                        else
                        {
                            lblMsg.Text = "invalid password";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "invalid admin id";
                    }
                }
            }
        }
    }
}