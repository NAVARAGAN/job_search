using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class COMPANY_REGISTER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CCOMPANYREGISTERATIONCLASScs ob = new CCOMPANYREGISTERATIONCLASScs();
            ob.REGNO = TextBox1.Text;
            ob.COMPANY_NAME = TextBox2.Text;
            ob.PHNO = TextBox3.Text;
            ob.EMAIL = TextBox4.Text;
            ob.HRHEADNAME = TextBox5.Text;
            ob.HRNUMBER = TextBox6.Text;
            ob.PASSWORD = TextBox7.Text;
            ob.CONFIRMPASSWORD = TextBox8.Text;




            //USERREGISTERATION b1 = new USERREGISTERATION();
            BALJOBAPPLY b = new BALJOBAPPLY();
            try
            {
                string result = b.BALcompany_registeration(ob);
                if (result != null)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Thankyou for Registering With Us...You Can Now Post Jobs By Loging in", "alertMessage();", true);
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
            Response.Redirect("COMPANYLOGIN.aspx");
        }
    }

    }
