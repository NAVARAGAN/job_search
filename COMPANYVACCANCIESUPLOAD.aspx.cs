using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class COMPANYVACCANCIESUPLOAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {

            companyjobupload ob = new companyjobupload();
            ob.COMPANY_ID = Session["job_id"].ToString();
            ob.JOBFIELD = DropDownList1.SelectedItem.ToString();
            ob.POST = TextBox1.Text;
            ob.SALARY = TextBox2.Text;
            ob.PLACE = TextBox3.Text;
            ob.TYPEOFJOB = DropDownList2.SelectedItem.ToString();
            ob.QUALIFICATION_NEED = TextBox4.Text;
            ob.DESCRIPTION = TextBox5.Text;




            //USERREGISTERATION b1 = new USERREGISTERATION();
            BALJOBAPPLY b = new BALJOBAPPLY();
            try
            {
                string result = b.BALinsert_companyjobupload(ob);
                if (result != null)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Thanks for uploading", "alertMessage();", true);
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
            Response.Redirect("HOMEPAGE.aspx");
        }
    }
}