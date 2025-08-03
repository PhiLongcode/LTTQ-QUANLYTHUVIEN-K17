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
                    object LbPrem = dt.Rows[0]["CPREM"];
                    FrmMain.lblName.Text = LbName.ToString();
                    FrmMain.lblPrem.Text = LbPrem.ToString();
                    FrmMain.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin đăng nhập");
                MessageBox.Show(ex.Message);
            }

        }
    }
}
