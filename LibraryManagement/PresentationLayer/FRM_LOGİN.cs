using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_LOGİN : Form
    {
        public FRM_LOGİN()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USERS CLSUSER = new BL.CLS_USERS();
                DataTable dt = new DataTable();
                dt = CLSUSER.Login(txtUserName.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    CLSUSER.UpdateLogin(txtUserName.Text, txtPassword.Text);
                    PresentationLayer.FRM_MAIN FrmMain = new FRM_MAIN();
                    object LbName = dt.Rows[0]["CNAME"];
                    object LbPrem = dt.Rows[0]["CPREM"].ToString().ToLower();
                    object LbUserID = dt.Rows[0]["ID"];
                    object LbUserName = dt.Rows[0]["CUSER"];
                    
                    // Thiết lập thông tin người dùng cho form chính
                    FrmMain.lblName.Text = LbName?.ToString() ?? "";
                    
                    // Debug: Hiển thị thông tin đăng nhập
                    string permission = LbPrem?.ToString().ToLower() ?? "";
                    int userID = Convert.ToInt32(LbUserID ?? 0);
                    string userName = LbUserName?.ToString() ?? "";
                    System.Diagnostics.Debug.WriteLine($"Login - Permission: '{permission}', UserID: {userID}, UserName: '{userName}'");
                    
                    FrmMain.SetUserPermission(permission, userID, userName);
                    
                    FrmMain.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_LOGİN_Load(object sender, EventArgs e)
        {

        }
    }
}
