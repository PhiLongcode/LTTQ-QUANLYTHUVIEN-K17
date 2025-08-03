using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_MAIN : Form
    {
        //$$$
        string State;
        int ID;
        // Instance of category
        BL.CLS_CAT BLCAT = new BL.CLS_CAT();
        // Instance of books
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        // Instance of STUDENT
        BL.CLS_ST BLST = new BL.CLS_ST();
        // Instance of SELL
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();
        // Instance of BORROW
        BL.CLS_BOR BLBOR = new BL.CLS_BOR();
        // Instance of USERS
        BL.CLS_USERS BLUSERS = new BL.CLS_USERS();
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            if (P_MB.Width == 175)
            {
                P_MB.Width = 35;
                btnHome.RightToLeft = RightToLeft.Yes;
                btnBooks.RightToLeft = RightToLeft.Yes;
                btnStudent.RightToLeft = RightToLeft.Yes;
                btnSell.RightToLeft = RightToLeft.Yes;
                btnBorrow.RightToLeft = RightToLeft.Yes;
                btnUsers.RightToLeft = RightToLeft.Yes;
                btnCategory.RightToLeft = RightToLeft.Yes;
                lblName.Visible = false;
                lblPrem.Visible = false;
                btnHome.HoverState.FillColor = Color.Purple;
                btnHome.HoverState.FillColor2 = Color.Black;
                btnBooks.HoverState.FillColor = Color.Purple;
                btnBooks.HoverState.FillColor2 = Color.Black;
                btnStudent.HoverState.FillColor = Color.Purple;
                btnStudent.HoverState.FillColor2 = Color.Black;
                btnSell.HoverState.FillColor = Color.Purple;
                btnSell.HoverState.FillColor2 = Color.Black;
                btnCategory.HoverState.FillColor = Color.Purple;
                btnCategory.HoverState.FillColor2 = Color.Black;
                btnBorrow.HoverState.FillColor = Color.Purple;
                btnBorrow.HoverState.FillColor2 = Color.Black;
                btnUsers.HoverState.FillColor = Color.Purple;
                btnUsers.HoverState.FillColor2 = Color.Black;

            }
            else
            {
                P_MB.Width = 175;
                btnHome.RightToLeft = RightToLeft.No;
                btnBooks.RightToLeft = RightToLeft.No;
                btnStudent.RightToLeft = RightToLeft.No;
                btnSell.RightToLeft = RightToLeft.No;
                btnBorrow.RightToLeft = RightToLeft.No;
                btnUsers.RightToLeft = RightToLeft.No;
                btnCategory.RightToLeft = RightToLeft.No;
                lblName.Visible = true;
                lblPrem.Visible = true;
                btnHome.HoverState.FillColor = Color.Black;
                btnHome.HoverState.FillColor2 = Color.Purple;
                btnBooks.HoverState.FillColor = Color.Black;
                btnBooks.HoverState.FillColor2 = Color.Purple;
                btnStudent.HoverState.FillColor = Color.Black;
                btnStudent.HoverState.FillColor2 = Color.Purple;
                btnSell.HoverState.FillColor = Color.Black;
                btnSell.HoverState.FillColor2 = Color.Purple;
                btnCategory.HoverState.FillColor = Color.Black;
                btnCategory.HoverState.FillColor2 = Color.Purple;
                btnBorrow.HoverState.FillColor = Color.Black;
                btnBorrow.HoverState.FillColor2 = Color.Purple;
                btnUsers.HoverState.FillColor = Color.Black;
                btnUsers.HoverState.FillColor2 = Color.Purple;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "CAT";
            lbTitle.Text = "Danh mục";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Tên danh mục";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            lbTitle.Text = "Trang chủ";
            if (lblPrem.Text == "مدير")
            {
                btnAdd.Location = new Point(656, 6);
                btnDetails.Location = new Point(50, 6);
            }
            else
            {
                btnAdd.Location = new Point(454, 6);
                btnDetails.Location = new Point(252, 6);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add category
            if (State == "CAT")
            {
                PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
                Fcat.btnCatAdd.Text = "Thêm";
                Fcat.ID = 0;
                bunifuTransition1.ShowSync(Fcat);
            }
            // Add BOOKS
            if (State == "BOOKS")
            {
                PresentationLayer.FRM_ADDBOOKS Fbooks = new FRM_ADDBOOKS();
                Fbooks.btnBookAdd.Text = "Thêm";
                Fbooks.ID = 0;
                bunifuTransition1.ShowSync(Fbooks);
            }
            // Add STUDENT
            if (State == "ST")
            {
                PresentationLayer.FRM_ADDSTUDENT FSTUDENT = new FRM_ADDSTUDENT();
                FSTUDENT.btnAdd.Text = "Thêm";
                FSTUDENT.ID = 0;
                bunifuTransition1.ShowSync(FSTUDENT);
            }
            // Add SELL
            if (State == "SELL")
            {
                PresentationLayer.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                FSELL.btnAdd.Text = "Thêm";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);
            }
            // Add BORROW
            if (State == "BOR")
            {
                PresentationLayer.FRM_BOR FBOR = new FRM_BOR();
                FBOR.btnAdd.Text = "Thêm";
                FBOR.ID = 0;
                bunifuTransition1.ShowSync(FBOR);
            }
            // Add USERS
            if (State == "USERS")
            {
                PresentationLayer.FRM_ADDUSER ADDUSER = new FRM_ADDUSER();
                ADDUSER.btnAdd.Text = "Thêm";
                ADDUSER.ID = 0;
                bunifuTransition1.ShowSync(ADDUSER);
            }

        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            //FOR LOAD NUMBERS

            //FOR BOOK
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                lblBook.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR STUDENT
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                lblStudent.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR SELL
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                lblSell.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR BORROW
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Load();
                lblBorrow.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR CATEGORY
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                lblCategory.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR USERS
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSERS.Load();
                lblUsers.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            // FOR PREM
            if (lblPrem.Text == "مدير")
            {
                btnDelete.Visible = true;
                btnUsers.Visible = true;
                btnEdit.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnUsers.Visible = false;
                btnEdit.Visible = false;
            }

            if (State == "CAT")
            {
                //Load data Cat
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Tên danh mục";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "BOOKS")
            {
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Tên sách";
                    dataGridView1.Columns[2].HeaderText = "Tác giả";
                    dataGridView1.Columns[3].HeaderText = "Phân loại";
                    dataGridView1.Columns[4].HeaderText = "Giá";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "ST")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "ST";
                lbTitle.Text = "Sinh viên";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLST.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Tên sinh viên";
                    dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[3].HeaderText = "Số điện thoại";
                    dataGridView1.Columns[4].HeaderText = "Email";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "SELL")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "SELL";
                lbTitle.Text = "Bán sách";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSELL.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Tên người mua";
                    dataGridView1.Columns[2].HeaderText = "Tên sách";
                    dataGridView1.Columns[3].HeaderText = "Giá";
                    dataGridView1.Columns[4].HeaderText = "Ngày tháng";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "BOR")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BOR";
                lbTitle.Text = "Mượn sách";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOR.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Tên người mượn";
                    dataGridView1.Columns[2].HeaderText = "Tên sách";
                    dataGridView1.Columns[3].HeaderText = "Ngày mượn";
                    dataGridView1.Columns[4].HeaderText = "Ngày trả";
                    dataGridView1.Columns[5].HeaderText = "Giá";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "USERS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "USERS";
                lbTitle.Text = "Người dùng";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSERS.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "STT";
                    dataGridView1.Columns[1].HeaderText = "Họ tên";
                    dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
                    dataGridView1.Columns[3].HeaderText = "Mật khẩu";
                    dataGridView1.Columns[4].HeaderText = "Quyền hạn";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit category
            if (State == "CAT")
            {
                PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
                Fcat.btnCatAdd.Text = "Sửa";
                Fcat.txt_catname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Fcat.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(Fcat);
                //Fcat.Show();
            }
            // Edit Books
            else if (State == "BOOKS")
            {
                try
                {
                    PresentationLayer.FRM_ADDBOOKS FBOOKS = new FRM_ADDBOOKS();
                    FBOOKS.btnBookAdd.Text = "Sửa";
                    FBOOKS.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FBOOKS.txtbookname.Text = obj1.ToString();
                    FBOOKS.txtauther.Text = obj2.ToString();
                    FBOOKS.comboBox1.Text = obj3.ToString();
                    FBOOKS.txtprice.Text = obj4.ToString();
                    FBOOKS.BookDate.Value = Convert.ToDateTime(obj5);
                    FBOOKS.bunifuRating1.Value = (int)obj6;
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOKS.pic_Cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FBOOKS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Edit STUDENT
            else if (State == "ST")
            {
                try
                {
                    PresentationLayer.FRM_ADDSTUDENT FST = new FRM_ADDSTUDENT();
                    FST.btnAdd.Text = "Sửa";
                    FST.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = BLST.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOCATİON"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAİL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    object obj8 = dt.Rows[0]["IdentificationNumber"];
                    FST.txtStudentName.Text = obj1.ToString();
                    FST.txtLocation.Text = obj2.ToString();
                    FST.txtPhone.Text = obj3.ToString();
                    FST.txtEmail.Text = obj4.ToString();
                    FST.txtSchool.Text = obj5.ToString();
                    FST.txtDep.Text = obj6.ToString();
                    FST.txtIdNumber.Text = obj8.ToString();
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FST.pic_Cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FST);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Edit SELL
            else if (State == "SELL")
            {
                try
                {
                    PresentationLayer.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                    FSELL.btnAdd.Text = "Sửa";

                    FSELL.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FSELL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Edit BOR
            else if (State == "BOR")
            {
                try
                {
                    PresentationLayer.FRM_BOR FBOR = new FRM_BOR();
                    FBOR.btnAdd.Text = "Sửa";
                    FBOR.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FBOR);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Edit USER
            else if (State == "USERS")
            {
                try
                {
                    PresentationLayer.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                    FUSER.btnAdd.Text = "Sửa";
                    FUSER.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    FUSER.lblAddNewUser.Text = "Sửa người dùng của";

                    DataTable dt = new DataTable();
                    dt = BLUSERS.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["CNAME"];
                    object obj2 = dt.Rows[0]["CUSER"];
                    object obj3 = dt.Rows[0]["CPASSWORD"];
                    object obj4 = dt.Rows[0]["CPREM"];

                    FUSER.txtName.Text = obj1.ToString();
                    FUSER.txtUserName.Text = obj2.ToString();
                    FUSER.txtPassword.Text = obj3.ToString();
                    FUSER.comPerm.Text = obj4.ToString();
                    bunifuTransition1.ShowSync(FUSER);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete category
            if (State == "CAT")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa danh mục";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLCAT.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }

            }
            // Delete BOOKS
            else if (State == "BOOKS")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa sách";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLBOOKS.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }
            }
            // Delete STUDENT
            else if (State == "ST")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa sinh viên";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLST.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }
            }
            // Delete SELL
            else if (State == "SELL")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa quá trình bán";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLSELL.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }
            }
            // Delete BOR
            else if (State == "BOR")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa quá trình mượn";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLBOR.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }
            }
            // Delete USER
            else if (State == "USERS")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                PresentationLayer.FRM_AREYOUSURE areyoursure = new FRM_AREYOUSURE();
                areyoursure.lblAreYouSure.Text = "Bạn sắp xóa người dùng";
                areyoursure.ShowDialog();
                if (PresentationLayer.FRM_AREYOUSURE.YesNo)
                {
                    BLUSERS.Delete(id);
                    PresentationLayer.FRM_DELETED deleted = new FRM_DELETED();
                    deleted.Show();
                    PresentationLayer.FRM_AREYOUSURE.YesNo = false;
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            // Search category
            if (State == "CAT")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            // Search BOOKS
            else if (State == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            // Search STUDENT
            else if (State == "ST")
            {
                DataTable dt = new DataTable();
                dt = BLST.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            // Search SELL
            else if (State == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            // Search BOR
            else if (State == "BOR")
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "BOOKS";
            lbTitle.Text = "Sách";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Tên sách";
                dataGridView1.Columns[2].HeaderText = "Tác giả";
                dataGridView1.Columns[3].HeaderText = "Phân loại";
                dataGridView1.Columns[4].HeaderText = "Giá";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // DETALIS OF BOOKS
            if (State == "BOOKS")
            {
                try
                {
                    PresentationLayer.FRM_DETAİLSBOOKS FDBOOKS = new FRM_DETAİLSBOOKS();
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["TITLE"];
                    object obj2 = dt.Rows[0]["AUTHER"];
                    object obj3 = dt.Rows[0]["CAT"];
                    object obj4 = dt.Rows[0]["PRICE"];
                    object obj5 = dt.Rows[0]["BDATE"];
                    object obj6 = dt.Rows[0]["RATE"];
                    object obj7 = dt.Rows[0]["COVER"];
                    FDBOOKS.lblBookName.Text = obj1.ToString();
                    FDBOOKS.lblBookAuthr.Text = obj2.ToString();
                    FDBOOKS.lblBookCat.Text = obj3.ToString();
                    FDBOOKS.lblBookPrice.Text = obj4.ToString();
                    FDBOOKS.lblBookDate.Text = obj5.ToString();
                    FDBOOKS.BookRate.Value = (int)obj6;
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FDBOOKS.BookCover.Image = Image.FromStream(ma);
                    FDBOOKS.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // DETALIS OF STUDENT
            if (State == "ST")
            {
                try
                {
                    PresentationLayer.FRM_DETAİLSST FRDST = new FRM_DETAİLSST();
                    DataTable dt = new DataTable();
                    dt = BLST.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["NAME"];
                    object obj2 = dt.Rows[0]["TLOCATİON"];
                    object obj3 = dt.Rows[0]["PHONE"];
                    object obj4 = dt.Rows[0]["EMAİL"];
                    object obj5 = dt.Rows[0]["SCHOOL"];
                    object obj6 = dt.Rows[0]["DEP"];
                    object obj7 = dt.Rows[0]["COVER"];
                    object obj8 = dt.Rows[0]["IdentificationNumber"];
                    FRDST.lblName.Text = obj1.ToString();
                    FRDST.lblLocation.Text = obj2.ToString();
                    FRDST.lblPhone.Text = obj3.ToString();
                    FRDST.lblEmail.Text = obj4.ToString();
                    FRDST.lblSchool.Text = obj5.ToString();
                    FRDST.lblDep.Text = obj6.ToString();
                    FRDST.lblIdNumber.Text = obj8.ToString();
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FRDST.picStudent.Image = Image.FromStream(ma);
                    FRDST.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "ST";
            lbTitle.Text = "Sinh viên";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Tên sinh viên";
                dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                dataGridView1.Columns[3].HeaderText = "Số điện thoại";
                dataGridView1.Columns[4].HeaderText = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "SELL";
            lbTitle.Text = "Bán sách";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Tên người mua";
                dataGridView1.Columns[2].HeaderText = "Tên sách";
                dataGridView1.Columns[3].HeaderText = "Giá";
                dataGridView1.Columns[4].HeaderText = "Ngày tháng";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "BOR";
            lbTitle.Text = "Mượn sách";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Tên người mượn";
                dataGridView1.Columns[2].HeaderText = "Tên sách";
                dataGridView1.Columns[3].HeaderText = "Ngày mượn";
                dataGridView1.Columns[4].HeaderText = "Ngày trả";
                dataGridView1.Columns[5].HeaderText = "Giá";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            State = "USERS";
            lbTitle.Text = "Người dùng";
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSERS.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Họ tên";
                dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns[3].HeaderText = "Mật khẩu";
                dataGridView1.Columns[4].HeaderText = "Quyền hạn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PresentationLayer.FRM_LOGİN Login = new FRM_LOGİN();
            BLUSERS.Logout();
            this.Hide();
            Login.Show();
            // trnasliton doing need here
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            lbTitle.Text = "Trang chủ";
        }



        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Add BOOKS
            PresentationLayer.FRM_ADDBOOKS Fbooks = new FRM_ADDBOOKS();
            Fbooks.btnBookAdd.Text = "Thêm";
            Fbooks.ID = 0;
            bunifuTransition1.ShowSync(Fbooks);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Add STUDENT
            PresentationLayer.FRM_ADDSTUDENT FSTUDENT = new FRM_ADDSTUDENT();
            FSTUDENT.btnAdd.Text = "Thêm";
            FSTUDENT.ID = 0;
            bunifuTransition1.ShowSync(FSTUDENT);
        }

        private void btnSellBook_Click(object sender, EventArgs e)
        {
            // Add SELL
            PresentationLayer.FRM_MAKESELL FSELL = new FRM_MAKESELL();
            FSELL.btnAdd.Text = "Thêm";
            FSELL.ID = 0;
            bunifuTransition1.ShowSync(FSELL);
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            // Add category
            PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
            Fcat.btnCatAdd.Text = "Thêm";
            Fcat.ID = 0;
            bunifuTransition1.ShowSync(Fcat);
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            // Add BORROW
            PresentationLayer.FRM_BOR FBOR = new FRM_BOR();
            FBOR.btnAdd.Text = "Thêm";
            FBOR.ID = 0;
            bunifuTransition1.ShowSync(FBOR);
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            PresentationLayer.FRM_RAPORT FrmRaport = new FRM_RAPORT();
            bunifuTransition1.ShowSync(FrmRaport);
        }
    }
}
