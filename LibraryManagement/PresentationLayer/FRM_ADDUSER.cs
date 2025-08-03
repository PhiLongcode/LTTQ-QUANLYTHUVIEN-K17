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
            ID = 0; // Khởi tạo ID để tránh null
            
            // Đảm bảo form có background color solid để tránh lỗi transparency
            this.BackColor = System.Drawing.Color.White;
            
            // Thiết lập background color cho các controls để tránh lỗi transparency
            if (guna2GradientPanel2 != null)
                guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            if (panel1 != null)
                panel1.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lblTimer != null)
                    lblTimer.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thời gian: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_ADDUSER_Activated(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo khi form được kích hoạt
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra null cho các control
                if (txtName == null || txtUserName == null || comPerm == null || txtPassword == null || chkActive == null)
                {
                    MessageBox.Show("Lỗi: Các control không được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtName.Text?.Trim() == "" || txtUserName.Text?.Trim() == "" || comPerm.Text?.Trim() == "" || txtPassword.Text?.Trim() == "")
                {
                    try
                    {
                        PresentationLayer.FRM_DİALOG frmdialog = new FRM_DİALOG();
                        if (frmdialog.lblDialog != null)
                        {
                            if (txtPassword.Text?.Length < 8 && (txtName.Text?.Trim() != "" || txtUserName.Text?.Trim() != "" || comPerm.Text?.Trim() != ""))
                                frmdialog.lblDialog.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                            else
                                frmdialog.lblDialog.Text = "Vui lòng điền đầy đủ thông tin";
                        }
                        frmdialog.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi hiển thị dialog: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ID == 0)
                    {
                        try
                        {
                            // Add User
                            BL.CLS_USERS BLUSER = new BL.CLS_USERS();
                            string activeStatus = chkActive.Checked ? "Active" : "Disable";
                            BLUSER.Insert(txtName.Text, txtUserName.Text, txtPassword.Text, comPerm.Text, activeStatus);
                            PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                            frmadded.Show();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            //Edit USER
                            BL.CLS_USERS BLUSER = new BL.CLS_USERS();
                            string activeStatus = chkActive.Checked ? "Active" : "Disable";
                            BLUSER.Update(txtName.Text, txtUserName.Text, txtPassword.Text, comPerm.Text, ID, activeStatus);
                            PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                            frmedited.Show();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thao tác: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Regex rx = new Regex("^[a-zA-Z0-9._]$");
                if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý ký tự: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Regex rx = new Regex(@"^[a-zA-ZÀ-ỹ\s]$");
                if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý ký tự: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword != null && txtPassword.Text?.Length < 8)
                {
                    try
                    {
                        PresentationLayer.FRM_DİALOG FrmDialog = new FRM_DİALOG();
                        if (FrmDialog.lblDialog != null)
                            FrmDialog.lblDialog.Text = "Mật khẩu phải có ít nhất 8 ký tự";
                        FrmDialog.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi hiển thị dialog: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_ADDUSER_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo timer nếu cần
                if (timer1 != null)
                {
                    timer1.Interval = 1000; // 1 giây
                    timer1.Start();
                }

                // Khởi tạo các giá trị mặc định cho combo box
                if (comPerm != null)
                {
                    comPerm.Items.Clear();
                    comPerm.Items.Add("admin");
                    comPerm.Items.Add("user");
                    comPerm.SelectedIndex = 1; // Mặc định chọn "user"
                }

                // Đảm bảo các textbox controls có background color phù hợp
                if (txtName != null)
                    txtName.BackColor = System.Drawing.Color.White;
                if (txtUserName != null)
                    txtUserName.BackColor = System.Drawing.Color.White;
                if (txtPassword != null)
                    txtPassword.BackColor = System.Drawing.Color.White;

                // Khởi tạo checkbox active
                if (chkActive != null)
                {
                    chkActive.Checked = true; // Mặc định là active
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}