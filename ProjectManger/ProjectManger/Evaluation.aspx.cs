using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManger
{
    public partial class Evaluation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dpStudentname.DataValueField = "Uid";
            
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

                    //sqlcom.Parameters.AddWithValue("@TypeName", txtTypeName.Text.Trim());
                    sqlcom.ExecuteNonQuery();
                    sqlCon.Close();
                
                
            }
            catch
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "unable to establish connection";
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            /*var DC = new DataClasses1DataContext();
            var data = (from ob in DC.Evaluations
                        select ob);
            gridviewData.DataSource = data;
            gridviewData.DataBind();*/

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            lbltime.Text = "( " + DateTime.Now.ToString() + " )";

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-discription", "attachment;filename=print.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            panelpdf.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 10f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            return;
        }

        protected void dpStudentname_SelectedIndexChanged(object sender, EventArgs e)
        {
            var TEST = "TEST";
        }
    }
}