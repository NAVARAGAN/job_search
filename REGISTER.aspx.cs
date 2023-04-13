using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class REGISTER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            USERREGISTERATION ob = new USERREGISTERATION();
            ob.FIRSTNAME = TextBox1.Text;
            ob.LASTNAME = TextBox2.Text;
            ob.USERNAME = TextBox3.Text;
            ob.PASSWORD = TextBox4.Text;
            ob.CONFIRMPASSWORD = TextBox5.Text;
         


            //USERREGISTERATION b1 = new USERREGISTERATION();
            BALJOBAPPLY b = new BALJOBAPPLY();
            try
            {
                string result = b.BALinsert_registeration(ob);
                if (result != null)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Thankyou for Registering With Us...Login and Apply For Jobs now..", "alertMessage();", true);
                }
                else
                    Label1.Text = "some error";

            }
            catch (Exception ex)

            {
                Response.Write("hai");


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx");
        }
    }
}
