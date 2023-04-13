using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class JOBLIST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("JOBAPPLY.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("JOBAPPLY.aspx");

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();



            OracleDataAdapter ad = new OracleDataAdapter("select * from tbl_company_jobpost where jobfield='" + DropDownList1.SelectedItem.ToString() + "'", cn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            DataList1.DataSource = ds.Tables[0];
            DataList1.DataBind();
            cn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("JOBAPPLY.aspx");
        }
    }
}