using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;


namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class JOBAPPLY : System.Web.UI.Page
    {
        OracleConnection cn = new OracleConnection("Data Source=UATDBNW;User Id=mana0809;Password=mana0809");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
                for (int i = 0; i <= 31; i++)
                    DropDownList1.Items.Add(i.ToString());
                for (int i = 1980; i < DateTime.Now.Year; i++)
                    DropDownList3.Items.Add(i.ToString());
            }

        }

        void bind()
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JOBAPPLYCLASS1 ob = new JOBAPPLYCLASS1();
            ob.NAME = TextBox1.Text;
            ob.PHNO = TextBox2.Text;

            ob.QUALIFICATION = TextBox3.Text;
            ob.EXPERIENCE = TextBox4.Text;
            string d = DropDownList1.SelectedItem + "-" + DropDownList2.SelectedItem + "-" + DropDownList3.SelectedItem;
            ob.DOB = Convert.ToDateTime(d);
            ob.NOTICE_PERIOD = TextBox4.Text;
            ob.RESUME = FileUpload1.FileName;
            ob.POST_APPLIED_TO = DropDownList4.SelectedItem.ToString();


            BALJOBAPPLY b1 = new BALJOBAPPLY();

            try
            {
                string result = b1.BALinsert_jobapply(ob);
                if (result != null)
                { 
                    ScriptManager.RegisterStartupScript(this, GetType(), "Thankyou For Applying For The Post. Our HR Will Contact You Soon....","alertMessage();", true);
                }
                else
                    Label1.Text = "some error";

            }
            catch (Exception ex)

            {
                Response.Write("hai");


            }
        }
    }
}
