using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public class BALJOBAPPLY
    {
        JOBAPPLYDAL ob = new JOBAPPLYDAL();

        public string BALinsert_jobapply(JOBAPPLYCLASS1 udata)
        {
            try
            {
                return ob.insert_jobapply(udata);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }




        public string BALinsert_registeration(USERREGISTERATION udata)
        {
            try
            {
                return ob.insert_registeration(udata);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public DataSet BALLogin_students(string uname, string pwd)
        {
            try
            {
                return ob.login_students(uname, pwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string BALcompany_registeration( CCOMPANYREGISTERATIONCLASScs udata)
        {
            try
            {
                return ob.company_registeration(udata);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        public DataSet BALlogin_company(string uname, string pwd)
        {
            try
            {
                return ob.login_company(uname, pwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string BALinsert_companyjobupload(companyjobupload udata)
        {
            try
            {
                return ob.insert_companyjobupload(udata);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}


