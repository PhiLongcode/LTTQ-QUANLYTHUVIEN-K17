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
    public partial class FRM_DETAILSUSER : Form
    {
        public FRM_DETAILSUSER()
        {
            InitializeComponent();
            // Đảm bảo form có background color solid để tránh lỗi transparency
            this.BackColor = System.Drawing.Color.White;
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

        private void FRM_DETAILSUSER_Load(object sender, EventArgs e)
        {
            try
            {
                // Form sẽ hiển thị bình thường không có transition
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 