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
    public partial class POSTSVIEWFORCOMPANY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                bind();
            }


        }

        void bind()
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            
           

            OracleDataAdapter ad = new OracleDataAdapter("select * from tbl_company_jobpost where COMPANY_ID='"+ Session["job_id"] +"'",cn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            cn.Close();

        }
    }
}