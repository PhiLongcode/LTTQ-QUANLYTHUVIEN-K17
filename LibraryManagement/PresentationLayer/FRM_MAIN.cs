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
        string currentUserPermission; // Lưu quyền hạn của người dùng hiện tại
        int currentUserID; // Lưu ID của người dùng hiện tại
        string currentUserName; // Lưu tên đăng nhập của người dùng hiện tại
        
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
            State = ""; // Khởi tạo State để tránh null
        }
        
        // Phương thức thiết lập quyền hạn cho người dùng
        public void SetUserPermission(string permission, int userID = 0, string userName = "")
        {
            currentUserPermission = permission?.ToLower() ?? "";
            currentUserID = userID;
            currentUserName = userName ?? "";
            
            // Debug: Hiển thị thông tin quyền hạn
            bool isAdmin = currentUserPermission == BL.CLS_USERS.Permissions.ADMIN;
            string debugInfo = $"Permission: '{currentUserPermission}', IsAdmin: {isAdmin}, UserID: {currentUserID}, UserName: '{currentUserName}'";
            System.Diagnostics.Debug.WriteLine(debugInfo);
            
            ApplyPermissionRestrictions();
        }
        
        // Áp dụng các hạn chế quyền hạn
        private void ApplyPermissionRestrictions()
        {
            try
            {
                if (string.IsNullOrEmpty(currentUserPermission))
                    return;

                bool isAdmin = currentUserPermission.ToLower().Trim() == BL.CLS_USERS.Permissions.ADMIN;

                // Debug: Hiển thị thông tin quyền hạn trong ApplyPermissionRestrictions
                System.Diagnostics.Debug.WriteLine($"ApplyPermissionRestrictions - Permission: '{currentUserPermission}', IsAdmin: {isAdmin}");

                // Ẩn/hiện các nút dựa trên quyền hạn
                if (btnBooks != null)
                    btnBooks.Visible = BL.CLS_USERS.CanViewBooks(currentUserPermission);

                // Admin có thể truy cập tất cả các chức năng - sử dụng trực tiếp isAdmin
                if (btnStudent != null)
                {
                    btnStudent.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnStudent.Visible = {isAdmin}");
                }

                if (btnBorrow != null)
                {
                    btnBorrow.Visible = BL.CLS_USERS.CanViewBorrowedBooks(currentUserPermission);
                    System.Diagnostics.Debug.WriteLine($"btnBorrow.Visible = {BL.CLS_USERS.CanViewBorrowedBooks(currentUserPermission)}");
                }

                if (btnSell != null)
                {
                    btnSell.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnSell.Visible = {isAdmin}");
                }

                if (btnCategory != null)
                {
                    btnCategory.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnCategory.Visible = {isAdmin}");
                }

                if (btnUsers != null)
                {
                    btnUsers.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnUsers.Visible = {isAdmin}");
                }

                // Ẩn nút báo cáo nếu không có quyền
                if (btnRaport != null)
                {
                    btnRaport.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnRaport.Visible = {isAdmin}");
                }

                // Ẩn các nút thêm, sửa, xóa cho user (chỉ admin mới có quyền)
                if (btnAdd != null)
                {
                    btnAdd.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnAdd.Visible = {isAdmin}");
                }
                if (btnEdit != null)
                {
                    btnEdit.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnEdit.Visible = {isAdmin}");
                }
                if (btnDelete != null)
                {
                    btnDelete.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnDelete.Visible = {isAdmin}");
                }

                // Ẩn các nút thêm trên trang chủ cho user (chỉ admin mới có quyền)
                if (btnAddBook != null)
                {
                    btnAddBook.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnAddBook.Visible = {isAdmin}");
                }
                if (btnAddStudent != null)
                {
                    btnAddStudent.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnAddStudent.Visible = {isAdmin}");
                }
                if (btnAddBorrow != null)
                {
                    btnAddBorrow.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnAddBorrow.Visible = {isAdmin}");
                }
                if (btnAddCat != null)
                {
                    btnAddCat.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnAddCat.Visible = {isAdmin}");
                }
                if (btnSellBook != null)
                {
                    btnSellBook.Visible = isAdmin;
                    System.Diagnostics.Debug.WriteLine($"btnSellBook.Visible = {isAdmin}");
                }

                // Cập nhật label hiển thị quyền hạn
                if (lblPrem != null)
                {
                    string permissionText = "";
                    switch (currentUserPermission)
                    {
                        case BL.CLS_USERS.Permissions.ADMIN:
                            permissionText = "Quản trị viên";
                            break;
                        case BL.CLS_USERS.Permissions.USER:
                            permissionText = "Người dùng";
                            break;
                        default:
                            permissionText = "Không xác định";
                            break;
                    }
                    lblPrem.Text = permissionText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thiết lập quyền hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                if (P_MB == null)
                    return;

                if (P_MB.Width == 175)
                {
                    P_MB.Width = 35;
                    if (btnHome != null)
                        btnHome.RightToLeft = RightToLeft.Yes;
                    if (btnBooks != null)
                        btnBooks.RightToLeft = RightToLeft.Yes;
                    if (btnStudent != null)
                        btnStudent.RightToLeft = RightToLeft.Yes;
                    if (btnSell != null)
                        btnSell.RightToLeft = RightToLeft.Yes;
                    if (btnBorrow != null)
                        btnBorrow.RightToLeft = RightToLeft.Yes;
                    if (btnUsers != null)
                        btnUsers.RightToLeft = RightToLeft.Yes;
                    if (btnCategory != null)
                        btnCategory.RightToLeft = RightToLeft.Yes;
                    if (lblName != null)
                        lblName.Visible = false;
                    if (lblPrem != null)
                        lblPrem.Visible = false;
                    if (btnHome != null)
                    {
                        btnHome.HoverState.FillColor = Color.Purple;
                        btnHome.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnBooks != null)
                    {
                        btnBooks.HoverState.FillColor = Color.Purple;
                        btnBooks.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnStudent != null)
                    {
                        btnStudent.HoverState.FillColor = Color.Purple;
                        btnStudent.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnSell != null)
                    {
                        btnSell.HoverState.FillColor = Color.Purple;
                        btnSell.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnCategory != null)
                    {
                        btnCategory.HoverState.FillColor = Color.Purple;
                        btnCategory.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnBorrow != null)
                    {
                        btnBorrow.HoverState.FillColor = Color.Purple;
                        btnBorrow.HoverState.FillColor2 = Color.Black;
                    }
                    if (btnUsers != null)
                    {
                        btnUsers.HoverState.FillColor = Color.Purple;
                        btnUsers.HoverState.FillColor2 = Color.Black;
                    }
                }
                else
                {
                    P_MB.Width = 175;
                    if (btnHome != null)
                        btnHome.RightToLeft = RightToLeft.No;
                    if (btnBooks != null)
                        btnBooks.RightToLeft = RightToLeft.No;
                    if (btnStudent != null)
                        btnStudent.RightToLeft = RightToLeft.No;
                    if (btnSell != null)
                        btnSell.RightToLeft = RightToLeft.No;
                    if (btnBorrow != null)
                        btnBorrow.RightToLeft = RightToLeft.No;
                    if (btnUsers != null)
                        btnUsers.RightToLeft = RightToLeft.No;
                    if (btnCategory != null)
                        btnCategory.RightToLeft = RightToLeft.No;
                    if (lblName != null)
                        lblName.Visible = true;
                    if (lblPrem != null)
                        lblPrem.Visible = true;
                    if (btnHome != null)
                    {
                        btnHome.HoverState.FillColor = Color.Black;
                        btnHome.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnBooks != null)
                    {
                        btnBooks.HoverState.FillColor = Color.Black;
                        btnBooks.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnStudent != null)
                    {
                        btnStudent.HoverState.FillColor = Color.Black;
                        btnStudent.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnSell != null)
                    {
                        btnSell.HoverState.FillColor = Color.Black;
                        btnSell.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnCategory != null)
                    {
                        btnCategory.HoverState.FillColor = Color.Black;
                        btnCategory.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnBorrow != null)
                    {
                        btnBorrow.HoverState.FillColor = Color.Black;
                        btnBorrow.HoverState.FillColor2 = Color.Purple;
                    }
                    if (btnUsers != null)
                    {
                        btnUsers.HoverState.FillColor = Color.Black;
                        btnUsers.HoverState.FillColor2 = Color.Purple;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi giao diện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "CAT";
                if (lbTitle != null)
                    lbTitle.Text = "Danh mục";
                //Load data
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 1)
                    {
                        dataGridView1.Columns[0].HeaderText = "Stt";
                        dataGridView1.Columns[1].HeaderText = "Tên danh mục";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = true;
                P_MAIN.Visible = false;
                
                if (lbTitle != null)
                    lbTitle.Text = "Trang chủ";
                    
                // Use our permission system instead of lblPrem.Text
                bool isAdmin = !string.IsNullOrEmpty(currentUserPermission) && 
                              currentUserPermission.ToLower().Trim() == BL.CLS_USERS.Permissions.ADMIN;
                
                if (isAdmin)
                {
                    if (btnAdd != null)
                        btnAdd.Location = new Point(656, 6);
                    if (btnDetails != null)
                        btnDetails.Location = new Point(50, 6);
                }
                else
                {
                    if (btnAdd != null)
                        btnAdd.Location = new Point(454, 6);
                    if (btnDetails != null)
                        btnDetails.Location = new Point(252, 6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được thêm
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra State có null không
                if (string.IsNullOrEmpty(State))
                {
                    MessageBox.Show("Vui lòng chọn một mục để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add category
                if (State == "CAT")
                {
                    try
                    {
                        PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
                        if (Fcat.btnCatAdd != null)
                            Fcat.btnCatAdd.Text = "Thêm";
                        Fcat.ID = 0;
                        Fcat.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Add BOOKS
                else if (State == "BOOKS")
                {
                    try
                    {
                        PresentationLayer.FRM_ADDBOOKS Fbooks = new FRM_ADDBOOKS();
                        if (Fbooks.btnBookAdd != null)
                            Fbooks.btnBookAdd.Text = "Thêm";
                        Fbooks.ID = 0;
                        Fbooks.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Add STUDENT
                else if (State == "ST")
                {
                    try
                    {
                        PresentationLayer.FRM_ADDSTUDENT FSTUDENT = new FRM_ADDSTUDENT();
                        if (FSTUDENT.btnAdd != null)
                            FSTUDENT.btnAdd.Text = "Thêm";
                        FSTUDENT.ID = 0;
                        FSTUDENT.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Add SELL
                else if (State == "SELL")
                {
                    try
                    {
                        PresentationLayer.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                        if (FSELL.btnAdd != null)
                            FSELL.btnAdd.Text = "Thêm";
                        FSELL.ID = 0;
                        FSELL.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm bán sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Add BORROW
                else if (State == "BOR")
                {
                    try
                    {
                        PresentationLayer.FRM_BOR FBOR = new FRM_BOR();
                        if (FBOR.btnAdd != null)
                            FBOR.btnAdd.Text = "Thêm";
                        FBOR.ID = 0;
                        FBOR.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Add USERS
                else if (State == "USERS")
                {
                    try
                    {
                        PresentationLayer.FRM_ADDUSER ADDUSER = new FRM_ADDUSER();
                        if (ADDUSER.btnAdd != null)
                            ADDUSER.btnAdd.Text = "Thêm";
                        ADDUSER.ID = 0;
                        ADDUSER.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chức năng này chưa được hỗ trợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (lblBook != null)
                    lblBook.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FOR STUDENT
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                if (lblStudent != null)
                    lblStudent.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FOR SELL
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                if (lblSell != null)
                    lblSell.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng bán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FOR BORROW
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Load();
                if (lblBorrow != null)
                    lblBorrow.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FOR CATEGORY
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                if (lblCategory != null)
                    lblCategory.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FOR USERS
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSERS.Load();
                if (lblUsers != null)
                    lblUsers.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải số lượng người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR PREM - Use our permission system instead of lblPrem.Text
            bool isAdmin = !string.IsNullOrEmpty(currentUserPermission) && 
                          currentUserPermission.ToLower().Trim() == BL.CLS_USERS.Permissions.ADMIN;
            
            if (btnDelete != null)
                btnDelete.Visible = isAdmin;
            if (btnUsers != null)
                btnUsers.Visible = isAdmin;
            if (btnEdit != null)
                btnEdit.Visible = isAdmin;

            if (State == "CAT")
            {
                //Load data Cat
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 0)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Tên danh mục";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (State == "BOOKS")
            {
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 4)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Tên sách";
                            dataGridView1.Columns[2].HeaderText = "Tác giả";
                            dataGridView1.Columns[3].HeaderText = "Phân loại";
                            dataGridView1.Columns[4].HeaderText = "Giá";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (State == "ST")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "ST";
                if (lbTitle != null)
                    lbTitle.Text = "Sinh viên";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLST.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 4)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Tên sinh viên";
                            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
                            dataGridView1.Columns[4].HeaderText = "Email";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (State == "SELL")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "SELL";
                if (lbTitle != null)
                    lbTitle.Text = "Bán sách";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSELL.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 4)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Tên người mua";
                            dataGridView1.Columns[2].HeaderText = "Tên sách";
                            dataGridView1.Columns[3].HeaderText = "Giá";
                            dataGridView1.Columns[4].HeaderText = "Ngày tháng";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu bán sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (State == "BOR")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BOR";
                if (lbTitle != null)
                    lbTitle.Text = "Mượn sách";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLBOR.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 5)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Tên người mượn";
                            dataGridView1.Columns[2].HeaderText = "Tên sách";
                            dataGridView1.Columns[3].HeaderText = "Ngày mượn";
                            dataGridView1.Columns[4].HeaderText = "Ngày trả";
                            dataGridView1.Columns[5].HeaderText = "Giá";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (State == "USERS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "USERS";
                if (lbTitle != null)
                    lbTitle.Text = "Người dùng";
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSERS.Load();
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Count > 4)
                        {
                            dataGridView1.Columns[0].HeaderText = "STT";
                            dataGridView1.Columns[1].HeaderText = "Họ tên";
                            dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
                            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
                            dataGridView1.Columns[4].HeaderText = "Quyền hạn";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền hạn - chỉ admin mới được sửa
            if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Edit category
            if (State == "CAT")
            {
                try
                {
                    PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
                    Fcat.btnCatAdd.Text = "Sửa";
                    Fcat.txt_catname.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    Fcat.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    Fcat.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["TITLE"];
                        object obj2 = dt.Rows[0]["AUTHER"];
                        object obj3 = dt.Rows[0]["CAT"];
                        object obj4 = dt.Rows[0]["PRICE"];
                        object obj5 = dt.Rows[0]["BDATE"];
                        object obj6 = dt.Rows[0]["RATE"];
                        object obj7 = dt.Rows[0]["COVER"];
                        FBOOKS.txtbookname.Text = obj1?.ToString() ?? "";
                        FBOOKS.txtauther.Text = obj2?.ToString() ?? "";
                        FBOOKS.comboBox1.Text = obj3?.ToString() ?? "";
                        FBOOKS.txtprice.Text = obj4?.ToString() ?? "";
                        FBOOKS.BookDate.Value = Convert.ToDateTime(obj5);
                        FBOOKS.bunifuRating1.Value = (int)obj6;
                        //Load Image
                        if (obj7 != null && obj7 != DBNull.Value)
                        {
                            byte[] ob = (byte[])obj7;
                            MemoryStream ma = new MemoryStream(ob);
                            FBOOKS.pic_Cover.Image = Image.FromStream(ma);
                        }
                        FBOOKS.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["Name"];
                        object obj2 = dt.Rows[0]["Address"];
                        object obj3 = dt.Rows[0]["Phone"];
                        object obj4 = dt.Rows[0]["Email"];
                        object obj5 = dt.Rows[0]["School"];
                        object obj6 = dt.Rows[0]["Dep"];
                        object obj7 = dt.Rows[0]["Cover"];
                        object obj8 = dt.Rows[0]["IdentificationNumber"];
                        FST.txtStudentName.Text = obj1?.ToString() ?? "";
                        FST.txtLocation.Text = obj2?.ToString() ?? "";
                        FST.txtPhone.Text = obj3?.ToString() ?? "";
                        FST.txtEmail.Text = obj4?.ToString() ?? "";
                        FST.txtSchool.Text = obj5?.ToString() ?? "";
                        FST.txtDep.Text = obj6?.ToString() ?? "";
                        FST.txtIdNumber.Text = obj8?.ToString() ?? "";
                        //Load Image
                        if (obj7 != null && obj7 != DBNull.Value)
                        {
                            byte[] ob = (byte[])obj7;
                            MemoryStream ma = new MemoryStream(ob);
                            FST.pic_Cover.Image = Image.FromStream(ma);
                        }
                        FST.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FSELL.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa bán sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FBOR.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["CNAME"];
                        object obj2 = dt.Rows[0]["CUSER"];
                        object obj3 = dt.Rows[0]["CPASSWORD"];
                        object obj4 = dt.Rows[0]["CPREM"];

                        FUSER.txtName.Text = obj1?.ToString() ?? "";
                        FUSER.txtUserName.Text = obj2?.ToString() ?? "";
                        FUSER.txtPassword.Text = obj3?.ToString() ?? "";
                        FUSER.comPerm.Text = obj4?.ToString() ?? "";
                        FUSER.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền hạn - chỉ admin mới được xóa
            if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            try
            {
                if (txtSearch == null || dataGridView1 == null)
                    return;

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BOOKS";
                if (lbTitle != null)
                    lbTitle.Text = "Sách";
                //Load data
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 4)
                    {
                        dataGridView1.Columns[0].HeaderText = "STT";
                        dataGridView1.Columns[1].HeaderText = "Tên sách";
                        dataGridView1.Columns[2].HeaderText = "Tác giả";
                        dataGridView1.Columns[3].HeaderText = "Phân loại";
                        dataGridView1.Columns[4].HeaderText = "Giá";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DETALIS OF BOOKS
            if (State == "BOOKS")
            {
                try
                {
                    PresentationLayer.FRM_DETAİLSBOOKS FDBOOKS = new FRM_DETAİLSBOOKS();
                    DataTable dt = new DataTable();
                    dt = BLBOOKS.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["TITLE"];
                        object obj2 = dt.Rows[0]["AUTHER"];
                        object obj3 = dt.Rows[0]["CAT"];
                        object obj4 = dt.Rows[0]["PRICE"];
                        object obj5 = dt.Rows[0]["BDATE"];
                        object obj6 = dt.Rows[0]["RATE"];
                        object obj7 = dt.Rows[0]["COVER"];
                        FDBOOKS.lblBookName.Text = obj1?.ToString() ?? "";
                        FDBOOKS.lblBookAuthr.Text = obj2?.ToString() ?? "";
                        FDBOOKS.lblBookCat.Text = obj3?.ToString() ?? "";
                        FDBOOKS.lblBookPrice.Text = obj4?.ToString() ?? "";
                        FDBOOKS.lblBookDate.Text = obj5?.ToString() ?? "";
                        FDBOOKS.BookRate.Value = (int)obj6;
                        //Load Image
                        if (obj7 != null && obj7 != DBNull.Value)
                        {
                            byte[] ob = (byte[])obj7;
                            MemoryStream ma = new MemoryStream(ob);
                            FDBOOKS.BookCover.Image = Image.FromStream(ma);
                        }
                        FDBOOKS.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["Name"];
                        object obj2 = dt.Rows[0]["Address"];
                        object obj3 = dt.Rows[0]["Phone"];
                        object obj4 = dt.Rows[0]["Email"];
                        object obj5 = dt.Rows[0]["School"];
                        object obj6 = dt.Rows[0]["Dep"];
                        object obj7 = dt.Rows[0]["Cover"];
                        object obj8 = dt.Rows[0]["IdentificationNumber"];
                        FRDST.lblName.Text = obj1?.ToString() ?? "";
                        FRDST.lblLocation.Text = obj2?.ToString() ?? "";
                        FRDST.lblPhone.Text = obj3?.ToString() ?? "";
                        FRDST.lblEmail.Text = obj4?.ToString() ?? "";
                        FRDST.lblSchool.Text = obj5?.ToString() ?? "";
                        FRDST.lblDep.Text = obj6?.ToString() ?? "";
                        FRDST.lblIdNumber.Text = obj8?.ToString() ?? "";
                        //Load Image
                        if (obj7 != null && obj7 != DBNull.Value)
                        {
                            byte[] ob = (byte[])obj7;
                            MemoryStream ma = new MemoryStream(ob);
                            FRDST.picStudent.Image = Image.FromStream(ma);
                        }
                        FRDST.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            // DETALIS OF USER
            if (State == "USERS")
            {
                try
                {
                    PresentationLayer.FRM_DETAILSUSER FDUSER = new FRM_DETAILSUSER();
                    DataTable dt = new DataTable();
                    dt = BLUSERS.LoadEdit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        object obj1 = dt.Rows[0]["CNAME"];
                        object obj2 = dt.Rows[0]["CUSER"];
                        object obj3 = dt.Rows[0]["CPASSWORD"];
                        object obj4 = dt.Rows[0]["CPREM"];
                        object obj5 = dt.Rows[0]["CSTATE"];
                        
                        FDUSER.lblName.Text = obj1?.ToString() ?? "";
                        FDUSER.lblUserName.Text = obj2?.ToString() ?? "";
                        FDUSER.lblPassword.Text = obj3?.ToString() ?? "";
                        FDUSER.lblPermission.Text = obj4?.ToString() ?? "";
                        FDUSER.lblStatus.Text = obj5?.ToString() ?? "";
                        
                        FDUSER.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xem chi tiết người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "ST";
                if (lbTitle != null)
                    lbTitle.Text = "Sinh viên";
                //Load data
                DataTable dt = new DataTable();
                dt = BLST.Load();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 4)
                    {
                        dataGridView1.Columns[0].HeaderText = "STT";
                        dataGridView1.Columns[1].HeaderText = "Tên sinh viên";
                        dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                        dataGridView1.Columns[3].HeaderText = "Số điện thoại";
                        dataGridView1.Columns[4].HeaderText = "Email";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "SELL";
                if (lbTitle != null)
                    lbTitle.Text = "Bán sách";
                //Load data
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 4)
                    {
                        dataGridView1.Columns[0].HeaderText = "STT";
                        dataGridView1.Columns[1].HeaderText = "Tên người mua";
                        dataGridView1.Columns[2].HeaderText = "Tên sách";
                        dataGridView1.Columns[3].HeaderText = "Giá";
                        dataGridView1.Columns[4].HeaderText = "Ngày tháng";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu bán sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "BOR";
                
                //Load data based on user permission with status information
                DataTable dt = new DataTable();
                if (currentUserPermission == BL.CLS_USERS.Permissions.ADMIN)
                {
                    // Admin sees all borrowed books with status
                    dt = BLBOR.LoadWithStatus();
                    if (lbTitle != null)
                        lbTitle.Text = "Mượn sách (Tất cả)";
                }
                else
                {
                    // User sees only their borrowed books with status
                    dt = BLBOR.LoadForUserWithStatus(currentUserID);
                    if (lbTitle != null)
                        lbTitle.Text = "Sách đã mượn của tôi";
                }
                
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 6)
                    {
                        dataGridView1.Columns[0].HeaderText = "STT";
                        dataGridView1.Columns[1].HeaderText = "Tên người mượn";
                        dataGridView1.Columns[2].HeaderText = "Tên sách";
                        dataGridView1.Columns[3].HeaderText = "Ngày mượn";
                        dataGridView1.Columns[4].HeaderText = "Ngày trả";
                        dataGridView1.Columns[5].HeaderText = "Giá";
                        dataGridView1.Columns[6].HeaderText = "Trạng thái";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                State = "USERS";
                if (lbTitle != null)
                    lbTitle.Text = "Người dùng";
                //Load data
                DataTable dt = new DataTable();
                dt = BLUSERS.Load();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Count > 4)
                    {
                        dataGridView1.Columns[0].HeaderText = "STT";
                        dataGridView1.Columns[1].HeaderText = "Họ tên";
                        dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
                        dataGridView1.Columns[3].HeaderText = "Mật khẩu";
                        dataGridView1.Columns[4].HeaderText = "Quyền hạn";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                PresentationLayer.FRM_LOGİN Login = new FRM_LOGİN();
                BLUSERS.Logout();
                this.Hide();
                Login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = true;
                P_MAIN.Visible = false;
                if (lbTitle != null)
                    lbTitle.Text = "Trang chủ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển về trang chủ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được thêm sách
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add BOOKS
                PresentationLayer.FRM_ADDBOOKS Fbooks = new FRM_ADDBOOKS();
                Fbooks.btnBookAdd.Text = "Thêm";
                Fbooks.ID = 0;
                Fbooks.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được thêm sinh viên
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add STUDENT
                PresentationLayer.FRM_ADDSTUDENT FSTUDENT = new FRM_ADDSTUDENT();
                FSTUDENT.btnAdd.Text = "Thêm";
                FSTUDENT.ID = 0;
                FSTUDENT.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSellBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được bán sách
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add SELL
                PresentationLayer.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                FSELL.btnAdd.Text = "Thêm";
                FSELL.ID = 0;
                FSELL.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi bán sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được thêm danh mục
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add category
                PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
                Fcat.btnCatAdd.Text = "Thêm";
                Fcat.ID = 0;
                Fcat.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra quyền hạn - chỉ admin mới được mượn sách
                if (string.IsNullOrEmpty(currentUserPermission) || currentUserPermission.ToLower().Trim() != BL.CLS_USERS.Permissions.ADMIN)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add BORROW
                PresentationLayer.FRM_BOR FBOR = new FRM_BOR();
                FBOR.btnAdd.Text = "Thêm";
                FBOR.ID = 0;
                FBOR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            try
            {
                PresentationLayer.FRM_RAPORT FrmRaport = new FRM_RAPORT();
                FrmRaport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
