using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class COMPANYLOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            BALJOBAPPLY b1 = new BALJOBAPPLY();
            try
            {
                DataSet result = b1.BALlogin_company(TextBox1.Text, TextBox2.Text);
                if (result.Tables[0].Rows.Count > 0)
                {
                    Session["job_id"] = result.Tables[0].Rows[0][0];
                    Response.Redirect("COMPANYVACCANCIESUPLOAD.aspx");
                }
                else
                {
                    Label1.Text = "incorrect username/Password";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("COMPANY REGISTER.aspx");
        }
    }
}