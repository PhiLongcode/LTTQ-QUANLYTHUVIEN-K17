
namespace LibraryManagement.PresentationLayer
{
    partial class FRM_ADDBOOKS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDBOOKS));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtbookname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtauther = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UploadPictures = new System.Windows.Forms.LinkLabel();
            this.pic_Cover = new System.Windows.Forms.PictureBox();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.BookDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CatAdd = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBookAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.bunifuTransition1.SetDecoration(this.guna2GradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(946, 587);
            this.guna2GradientPanel1.TabIndex = 7;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.txtbookname);
            this.guna2GradientPanel2.Controls.Add(this.txtprice);
            this.guna2GradientPanel2.Controls.Add(this.txtauther);
            this.guna2GradientPanel2.Controls.Add(this.groupBox3);
            this.guna2GradientPanel2.Controls.Add(this.groupBox2);
            this.guna2GradientPanel2.Controls.Add(this.btnClose);
            this.guna2GradientPanel2.Controls.Add(this.btnBookAdd);
            this.bunifuTransition1.SetDecoration(this.guna2GradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(946, 587);
            this.guna2GradientPanel2.TabIndex = 8;
            // 
            // txtbookname
            // 
            this.txtbookname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtbookname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtbookname, BunifuAnimatorNS.DecorationType.None);
            this.txtbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbookname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbookname.HintText = "";
            this.txtbookname.isPassword = false;
            this.txtbookname.LineFocusedColor = System.Drawing.Color.Purple;
            this.txtbookname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtbookname.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.txtbookname.LineThickness = 5;
            this.txtbookname.Location = new System.Drawing.Point(504, 129);
            this.txtbookname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(401, 48);
            this.txtbookname.TabIndex = 7;
            this.txtbookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtprice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtprice, BunifuAnimatorNS.DecorationType.None);
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtprice.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.Purple;
            this.txtprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.txtprice.LineThickness = 5;
            this.txtprice.Location = new System.Drawing.Point(504, 317);
            this.txtprice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(408, 48);
            this.txtprice.TabIndex = 7;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtauther
            // 
            this.txtauther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtauther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtauther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtauther, BunifuAnimatorNS.DecorationType.None);
            this.txtauther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtauther.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtauther.HintText = "";
            this.txtauther.isPassword = false;
            this.txtauther.LineFocusedColor = System.Drawing.Color.Purple;
            this.txtauther.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtauther.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.txtauther.LineThickness = 5;
            this.txtauther.Location = new System.Drawing.Point(504, 221);
            this.txtauther.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtauther.Name = "txtauther";
            this.txtauther.Size = new System.Drawing.Size(408, 48);
            this.txtauther.TabIndex = 7;
            this.txtauther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtauther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtauther_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.UploadPictures);
            this.groupBox3.Controls.Add(this.pic_Cover);
            this.groupBox3.Controls.Add(this.bunifuRating1);
            this.groupBox3.Controls.Add(this.BookDate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.bunifuTransition1.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(444, 473);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phụ";
            // 
            // UploadPictures
            // 
            this.UploadPictures.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.UploadPictures, BunifuAnimatorNS.DecorationType.None);
            this.UploadPictures.LinkColor = System.Drawing.Color.Fuchsia;
            this.UploadPictures.Location = new System.Drawing.Point(284, 346);
            this.UploadPictures.Name = "UploadPictures";
            this.UploadPictures.Size = new System.Drawing.Size(80, 24);
            this.UploadPictures.TabIndex = 4;
            this.UploadPictures.TabStop = true;
            this.UploadPictures.Text = "Tải ảnh";
            this.UploadPictures.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UploadPictures_LinkClicked);
            // 
            // pic_Cover
            // 
            this.bunifuTransition1.SetDecoration(this.pic_Cover, BunifuAnimatorNS.DecorationType.None);
            this.pic_Cover.Image = global::LibraryManagement.Properties.Resources.Book_Cover_icon_2;
            this.pic_Cover.Location = new System.Drawing.Point(79, 260);
            this.pic_Cover.Name = "pic_Cover";
            this.pic_Cover.Size = new System.Drawing.Size(152, 196);
            this.pic_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cover.TabIndex = 3;
            this.pic_Cover.TabStop = false;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuRating1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRating1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuRating1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuRating1.Location = new System.Drawing.Point(46, 187);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(378, 59);
            this.bunifuRating1.TabIndex = 2;
            this.bunifuRating1.Value = 0;
            // 
            // BookDate
            // 
            this.BookDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BookDate.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.BookDate, BunifuAnimatorNS.DecorationType.None);
            this.BookDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDate.ForeColor = System.Drawing.Color.White;
            this.BookDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BookDate.FormatCustom = null;
            this.BookDate.Location = new System.Drawing.Point(46, 102);
            this.BookDate.Margin = new System.Windows.Forms.Padding(6);
            this.BookDate.Name = "BookDate";
            this.BookDate.Size = new System.Drawing.Size(378, 42);
            this.BookDate.TabIndex = 1;
            this.BookDate.Value = new System.DateTime(2022, 7, 5, 20, 25, 3, 466);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(284, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ảnh bìa sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(323, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đánh giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(282, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày xuất bản";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.CatAdd);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(479, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(444, 473);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cơ bản";
            // 
            // CatAdd
            // 
            this.CatAdd.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.CatAdd, BunifuAnimatorNS.DecorationType.None);
            this.CatAdd.LinkColor = System.Drawing.Color.Fuchsia;
            this.CatAdd.Location = new System.Drawing.Point(25, 399);
            this.CatAdd.Name = "CatAdd";
            this.CatAdd.Size = new System.Drawing.Size(64, 24);
            this.CatAdd.TabIndex = 4;
            this.CatAdd.TabStop = true;
            this.CatAdd.Text = "Thêm";
            this.CatAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CatAdd_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 391);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 37);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(265, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(345, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(332, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(326, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên sách";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(23, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBookAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.BorderRadius = 15;
            this.btnBookAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.bunifuTransition1.SetDecoration(this.btnBookAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnBookAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookAdd.FillColor = System.Drawing.Color.Purple;
            this.btnBookAdd.FillColor2 = System.Drawing.Color.Black;
            this.btnBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnBookAdd.ForeColor = System.Drawing.Color.White;
            this.btnBookAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBookAdd.ImageOffset = new System.Drawing.Point(0, 20);
            this.btnBookAdd.ImageSize = new System.Drawing.Size(65, 65);
            this.btnBookAdd.Location = new System.Drawing.Point(306, 513);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(335, 53);
            this.btnBookAdd.TabIndex = 4;
            this.btnBookAdd.Text = "Thêm";
            this.btnBookAdd.Tile = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.txtbookname;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.txtauther;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.txtprice;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // FRM_ADDBOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.guna2GradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDBOOKS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_ADDBOOKS_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cover)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtauther;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtbookname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        public Guna.UI2.WinForms.Guna2GradientButton btnBookAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel UploadPictures;
        private System.Windows.Forms.LinkLabel CatAdd;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.PictureBox pic_Cover;
        public Bunifu.Framework.UI.BunifuRating bunifuRating1;
        public Bunifu.Framework.UI.BunifuDatepicker BookDate;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}