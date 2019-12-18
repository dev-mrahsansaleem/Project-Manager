using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManger
{
    public partial class PMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["adminName"]!=null)
            {
                lblUserLogin.Text = Session["adminName"].ToString();
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void linkTypes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Types.aspx");
        }

        protected void LinkUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");
        }

        protected void LinkGroups_Click(object sender, EventArgs e)
        {
            Response.Redirect("Groups.aspx");
        }

        protected void LinkProjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("Projects.aspx");
        }

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }

        protected void LinkEvaluation_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evaluation.aspx");
        }
    }
}