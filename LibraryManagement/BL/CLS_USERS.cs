using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.BL
{
    class CLS_USERS
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        
        // Định nghĩa các quyền hạn
        public static class Permissions
        {
            public const string ADMIN = "admin";           // Quản trị viên - Toàn quyền
            public const string USER = "user";             // Người dùng - Chỉ mượn sách
        }
        
        // Kiểm tra quyền truy cập
        public static bool HasPermission(string userPermission, string requiredPermission)
        {
            if (string.IsNullOrEmpty(userPermission) || string.IsNullOrEmpty(requiredPermission))
                return false;
                
            userPermission = userPermission.ToLower().Trim();
            requiredPermission = requiredPermission.ToLower().Trim();
            
            // Admin có tất cả quyền
            if (userPermission == Permissions.ADMIN)
                return true;
                
            // User chỉ có quyền user
            if (userPermission == Permissions.USER)
                return requiredPermission == Permissions.USER;
                
            return false;
        }
        
        // Kiểm tra quyền quản lý sách
        public static bool CanManageBooks(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền quản lý sinh viên
        public static bool CanManageStudents(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền quản lý mượn trả
        public static bool CanManageBorrows(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền quản lý bán sách
        public static bool CanManageSales(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền quản lý danh mục
        public static bool CanManageCategories(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền quản lý người dùng
        public static bool CanManageUsers(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền xem báo cáo
        public static bool CanViewReports(string userPermission)
        {
            return HasPermission(userPermission, Permissions.ADMIN);
        }
        
        // Kiểm tra quyền xem danh sách sách (cả admin và user đều có thể xem)
        public static bool CanViewBooks(string userPermission)
        {
            if (string.IsNullOrEmpty(userPermission))
                return false;
                
            userPermission = userPermission.ToLower().Trim();
            
            // Cả admin và user đều có thể xem sách
            return userPermission == Permissions.ADMIN || userPermission == Permissions.USER;
        }
        
        // Kiểm tra quyền xem danh sách sách đã mượn (cả admin và user đều có thể xem)
        public static bool CanViewBorrowedBooks(string userPermission)
        {
            if (string.IsNullOrEmpty(userPermission))
                return false;
                
            userPermission = userPermission.ToLower().Trim();
            
            // Cả admin và user đều có thể xem sách đã mượn
            return userPermission == Permissions.ADMIN || userPermission == Permissions.USER;
        }
        
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string CNAME, string CUSER, string CPASSWORD, string CPREM, String CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("CSTATE", CSTATE);
            DAL.Open();
            DAL.Excute("PR_INSERTUSER", pr);
            DAL.Close();
        }
        // UPDATE Date
        public void Update(string CNAME, string CUSER, string CPASSWORD, string CPREM, int ID , String CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[6]; // Changed from 5 to 6
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("ID", ID);
            pr[5] = new SqlParameter("CSTATE", CSTATE);
            DAL.Open();
            DAL.Excute("PR_EDITUSER", pr);
            DAL.Close();
        }
        public DataTable LoadEdit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEEDITUSER", pr);
            return dt;
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_USERSDELETE", pr);
            DAL.Close();
        }
        // Log out
        public void Logout()
        {
            SqlParameter[] pr = null;
            DAL.Open();
            DAL.Excute("PR_LOGOUT", pr);
            DAL.Close();
        }
        //Load DATA FOR LOGIN
        public DataTable Login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;
        }
        // UPDATE Date FOR LOGIN
        public void UpdateLogin(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DAL.Open();
            DAL.Excute("PR_UPDATELOGIN", pr);
            DAL.Close();

        }
        //Load FOR CHECK START
        public DataTable StartLoadDate()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", pr);
            return dt;
        }
    }
}
