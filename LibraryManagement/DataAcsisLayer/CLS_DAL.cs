using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.DataAcsisLayer
{
    class CLS_DAL
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection(@"Data Source=MSI;Initial Catalog=LibraryManagementDB;Integrated Security=True");
        }

        // Method to open sqlcon
        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        } // Method to Close sqlcon
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        // Function to read data
        public DataTable read(string Store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Excute to insert , edit delete
        public void Excute(string Store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }

    }
}
