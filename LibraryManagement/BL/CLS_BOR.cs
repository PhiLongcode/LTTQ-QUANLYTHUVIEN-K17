using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.BL
{
    class CLS_BOR
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOR", pr);
            return dt;
        }
        //Load FOR SELL THE BOOKS
        public DataTable LoadBOOKS()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKFORSELL", pr);
            return dt;
        }
        //Load FOR CHOSE THE STUDENT
        public DataTable LoadST()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSTFORSELL", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string BNAME, string BTITLE, string EDATE1, string EDATE2,int PRICE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("EDATE1", EDATE1);
            pr[3] = new SqlParameter("EDATE2", EDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);
            DAL.Open();
            DAL.Excute("PR_INSERTBOR", pr);
            DAL.Close();
        }
        // UPDATE Date
        public void Update(string BNAME, string BTITLE, string EDATE1, string EDATE2, int PRICE,int ID)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("EDATE1", EDATE1);
            pr[3] = new SqlParameter("EDATE2", EDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);
            pr[5] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_UPDATEBOR", pr);
            DAL.Close();
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_BORDELETE", pr);
            DAL.Close();
        }
        //Search
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_BORSEARCH", pr);
            return dt;
        }

        //Load borrowed books for specific user
        public DataTable LoadForUser(int userID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("USERID", userID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBORFORUSER", pr);
            return dt;
        }

        //Load borrowed books with status for all users (admin view)
        public DataTable LoadWithStatus()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBORWITHSTATUS", pr);
            return dt;
        }

        //Load borrowed books with status for specific user
        public DataTable LoadForUserWithStatus(int userID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("USERID", userID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBORFORUSERWITHSTATUS", pr);
            return dt;
        }
    }
}
