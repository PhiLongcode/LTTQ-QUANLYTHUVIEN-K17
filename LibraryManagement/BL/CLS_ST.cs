using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagement.BL
{
    class CLS_ST
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADST", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string NAME, string TLOCATION, string PHONE, string EMAIL, 
            string SCHOOL, string DEP, MemoryStream COVER, string IdentificationNumber)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("IdentificationNumber", IdentificationNumber);
            DAL.Open();
            DAL.Excute("PR_INSERTST", pr);
            DAL.Close();
        }
        //Load Date for edit
        public DataTable LoadEdit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEEDITST", pr);
            return dt;
        }
        // Update Date
        public void update(string NAME, string TLOCATION, string PHONE, string EMAIL,
            string SCHOOL, string DEP, MemoryStream COVER, string IdentificationNumber,int ID)
        {

            SqlParameter[] pr = new SqlParameter[9];
            pr[0] = new SqlParameter("NAME", NAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("IdentificationNumber", IdentificationNumber);
            pr[8] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_EDITST", pr);
            DAL.Close();
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("P_DELETEST", pr);
            DAL.Close();
        }
        //Search
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_STSEARCH", pr);
            return dt;
        }

    }
}
