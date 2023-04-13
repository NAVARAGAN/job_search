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
    public class JOBAPPLYDAL
    {

        public string insert_jobapply(JOBAPPLYCLASS1 udata)
        { 

        OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
        cn.Open();
            OracleCommand cmd = new OracleCommand("proc_insertjobapply_394594", cn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_name", OracleType.VarChar).Value = udata.NAME;
                cmd.Parameters.Add("p_phno", OracleType.VarChar).Value = udata.PHNO;
                cmd.Parameters.Add("p_qualification", OracleType.VarChar).Value = udata.QUALIFICATION;
                cmd.Parameters.Add("p_experience", OracleType.VarChar).Value = udata.EXPERIENCE;
                cmd.Parameters.Add("p_noticeperiod", OracleType.VarChar).Value = udata.NOTICE_PERIOD;
                cmd.Parameters.Add("p_resume", OracleType.VarChar).Value = udata.RESUME;
                cmd.Parameters.Add("p_dob", OracleType.DateTime).Value = udata.DOB;
                cmd.Parameters.Add("p_postappliedto", OracleType.VarChar).Value = udata.POST_APPLIED_TO;

                cmd.ExecuteNonQuery();
                return "inserted";




            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }




        public string insert_registeration(USERREGISTERATION udata)
        {

            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            OracleCommand cmd = new OracleCommand("user_registeration", cn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_firstname", OracleType.VarChar).Value = udata.FIRSTNAME;
                cmd.Parameters.Add("p_lastname", OracleType.VarChar).Value = udata.LASTNAME;
                cmd.Parameters.Add("p_username", OracleType.VarChar).Value = udata.USERNAME;
                cmd.Parameters.Add("p_password", OracleType.VarChar).Value = udata.PASSWORD;
                cmd.Parameters.Add("p_confirm_password", OracleType.VarChar).Value = udata.CONFIRMPASSWORD;
                

                cmd.ExecuteNonQuery();
                return "inserted";




            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public DataSet login_students(string uname, string password)
        {

            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            DataSet ds = new DataSet();
            OracleCommand cmd = new OracleCommand("login_394594", cn);
            try
            {

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleType.VarChar).Value = uname;
                cmd.Parameters.Add("P_password", OracleType.VarChar).Value = password;
                cmd.Parameters.Add("p_row", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter ad = new OracleDataAdapter(cmd);

                ad.Fill(ds);
                // cmd.ExecuteNonQuery();
                return ds;
            }

            catch (Exception ex)
            {
                return ds;
            }

        }






        public string company_registeration(CCOMPANYREGISTERATIONCLASScs udata)
        {

            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            OracleCommand cmd = new OracleCommand("company_registeration", cn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_regno", OracleType.VarChar).Value = udata.REGNO;
                cmd.Parameters.Add("p_companyname", OracleType.VarChar).Value = udata.COMPANY_NAME;
                cmd.Parameters.Add("p_phno", OracleType.VarChar).Value = udata.PHNO;
                cmd.Parameters.Add("p_email", OracleType.VarChar).Value = udata.EMAIL;
                cmd.Parameters.Add("p_hrheadname", OracleType.VarChar).Value = udata.HRHEADNAME;
                cmd.Parameters.Add("p_hrnumber", OracleType.VarChar).Value = udata.HRNUMBER;
                cmd.Parameters.Add("p_password", OracleType.VarChar).Value = udata.PASSWORD;
                cmd.Parameters.Add("p_confirmpassword", OracleType.VarChar).Value = udata.CONFIRMPASSWORD;

                cmd.ExecuteNonQuery();
                return "inserted";




            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }






        public DataSet login_company(string uname, string password)
        {

            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            DataSet ds = new DataSet();
            OracleCommand cmd = new OracleCommand("company_login", cn);
            try
            {

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleType.VarChar).Value = uname;
                cmd.Parameters.Add("P_password", OracleType.VarChar).Value = password;
                cmd.Parameters.Add("p_row", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter ad = new OracleDataAdapter(cmd);

                ad.Fill(ds);
                // cmd.ExecuteNonQuery();
                return ds;
            }

            catch (Exception ex)
            {
                return ds;
            }

        }



        public string insert_companyjobupload(companyjobupload udata)
        {

            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["conname"].ConnectionString);
            cn.Open();
            OracleCommand cmd = new OracleCommand("company_jobupload", cn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("p_companyid", OracleType.VarChar).Value = udata.COMPANY_ID;
                cmd.Parameters.Add("p_jobfield", OracleType.VarChar).Value = udata.JOBFIELD;
                cmd.Parameters.Add("p_post", OracleType.VarChar).Value = udata.POST;
                cmd.Parameters.Add("p_salary", OracleType.VarChar).Value = udata.SALARY;
                cmd.Parameters.Add("p_place", OracleType.VarChar).Value = udata.PLACE;
                cmd.Parameters.Add("p_typeofjob", OracleType.VarChar).Value = udata.TYPEOFJOB;
                cmd.Parameters.Add("p_qualificationneed", OracleType.VarChar).Value = udata.QUALIFICATION_NEED;
                cmd.Parameters.Add("p_jobdescription", OracleType.VarChar).Value = udata.DESCRIPTION;




                cmd.ExecuteNonQuery();
                return "inserted";




            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }







    }
}