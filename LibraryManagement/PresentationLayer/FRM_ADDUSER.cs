using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDUSER_Activated(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtUserName.Text.Trim() == "" || comPerm.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                PresentationLayer.FRM_DİALOG frmdialog = new FRM_DİALOG();
                if (txtPassword.Text.Length < 8 && (txtName.Text.Trim() != "" || txtUserName.Text.Trim() != "" || comPerm.Text.Trim() != ""))
                    frmdialog.lblDialog.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                else
                    frmdialog.lblDialog.Text = "Vui lòng điền đầy đủ thông tin";
                frmdialog.Show();
            }
            else
            {
                if (ID == 0)
                {


                    // Add Book
                    BL.CLS_USERS BLUSER = new BL.CLS_USERS();
                    BLUSER.Insert(txtName.Text, txtUserName.Text, txtPassword.Text, comPerm.Text, "False");
                    PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                    frmadded.Show();
                    this.Close();
                }
                else
                {
                    //Edit USER
                    BL.CLS_USERS BLUSER = new BL.CLS_USERS();
                    BLUSER.Update(txtName.Text, txtUserName.Text, txtPassword.Text, comPerm.Text, ID);
                    PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                    frmedited.Show();
                    this.Close();
                }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex("^[a-zA-Z0-9._]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[a-zA-ZÀ-ỹ\s]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }



        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                PresentationLayer.FRM_DİALOG FrmDialog = new FRM_DİALOG();
                FrmDialog.lblDialog.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                FrmDialog.Show();
            }
        }
    }
}