
namespace LibraryManagement.PresentationLayer
{
    partial class FRM_DETAİLSBOOKS
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAİLSBOOKS));
            this.btnClose = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblBookDate = new System.Windows.Forms.Label();
            this.lblBookCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblBookAuthr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookRate = new Bunifu.Framework.UI.BunifuRating();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2GradientPanel2;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientPanel2.Controls.Add(this.lblBookDate);
            this.guna2GradientPanel2.Controls.Add(this.lblBookCat);
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Controls.Add(this.lblBookPrice);
            this.guna2GradientPanel2.Controls.Add(this.lblBook);
            this.guna2GradientPanel2.Controls.Add(this.lblBookAuthr);
            this.guna2GradientPanel2.Controls.Add(this.label4);
            this.guna2GradientPanel2.Controls.Add(this.lblBookName);
            this.guna2GradientPanel2.Controls.Add(this.label3);
            this.guna2GradientPanel2.Controls.Add(this.label2);
            this.guna2GradientPanel2.Controls.Add(this.BookRate);
            this.guna2GradientPanel2.Controls.Add(this.BookCover);
            this.bunifuTransition1.SetDecoration(this.guna2GradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(143, 36);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(840, 535);
            this.guna2GradientPanel2.TabIndex = 9;
            // 
            // lblBookDate
            // 
            this.lblBookDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookDate.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBookDate, BunifuAnimatorNS.DecorationType.None);
            this.lblBookDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookDate.Location = new System.Drawing.Point(350, 478);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(314, 35);
            this.lblBookDate.TabIndex = 26;
            this.lblBookDate.Text = "Ngày xuất bản :";
            // 
            // lblBookCat
            // 
            this.lblBookCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookCat.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBookCat, BunifuAnimatorNS.DecorationType.None);
            this.lblBookCat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookCat.Location = new System.Drawing.Point(350, 382);
            this.lblBookCat.Name = "lblBookCat";
            this.lblBookCat.Size = new System.Drawing.Size(301, 35);
            this.lblBookCat.TabIndex = 27;
            this.lblBookCat.Text = "Danh mục sách :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(670, 478);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ngày xuất bản :";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookPrice.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBookPrice, BunifuAnimatorNS.DecorationType.None);
            this.lblBookPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookPrice.Location = new System.Drawing.Point(350, 286);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(369, 35);
            this.lblBookPrice.TabIndex = 30;
            this.lblBookPrice.Text = "Giá";
            // 
            // lblBook
            // 
            this.lblBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBook, BunifuAnimatorNS.DecorationType.None);
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBook.Location = new System.Drawing.Point(654, 382);
            this.lblBook.Name = "lblBook";
            this.lblBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBook.Size = new System.Drawing.Size(168, 35);
            this.lblBook.TabIndex = 29;
            this.lblBook.Text = "Danh mục sách :";
            // 
            // lblBookAuthr
            // 
            this.lblBookAuthr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookAuthr.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBookAuthr, BunifuAnimatorNS.DecorationType.None);
            this.lblBookAuthr.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookAuthr.Location = new System.Drawing.Point(350, 190);
            this.lblBookAuthr.Name = "lblBookAuthr";
            this.lblBookAuthr.Size = new System.Drawing.Size(354, 35);
            this.lblBookAuthr.TabIndex = 32;
            this.lblBookAuthr.Text = "của";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(725, 286);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 31;
            this.label4.Text = "Giá :";
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBookName, BunifuAnimatorNS.DecorationType.None);
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBookName.Location = new System.Drawing.Point(350, 94);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(307, 35);
            this.lblBookName.TabIndex = 34;
            this.lblBookName.Text = "củasách";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(710, 190);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "của :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(663, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(159, 35);
            this.label2.TabIndex = 35;
            this.label2.Text = "củasách :";
            // 
            // BookRate
            // 
            this.BookRate.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.BookRate, BunifuAnimatorNS.DecorationType.None);
            this.BookRate.Enabled = false;
            this.BookRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookRate.Location = new System.Drawing.Point(43, 29);
            this.BookRate.Margin = new System.Windows.Forms.Padding(6);
            this.BookRate.Name = "BookRate";
            this.BookRate.Size = new System.Drawing.Size(289, 56);
            this.BookRate.TabIndex = 25;
            this.BookRate.Value = 3;
            // 
            // BookCover
            // 
            this.BookCover.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.BookCover, BunifuAnimatorNS.DecorationType.None);
            this.BookCover.Image = global::LibraryManagement.Properties.Resources.Book_Cover_icon_2;
            this.BookCover.Location = new System.Drawing.Point(23, 94);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(309, 416);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover.TabIndex = 24;
            this.BookCover.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 1;
            this.bunifuTransition1.MaxAnimationTime = 2000;
            // 
            // FRM_DETAİLSBOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1126, 583);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GradientPanel2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_DETAİLSBOOKS";
            this.Opacity = 0.85D;
            this.Text = "FRM_DETAİLSBOOKS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_DETAİLSBOOKS_Load);
            this.Click += new System.EventHandler(this.FRM_DETAİLSBOOKS_Click);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        public System.Windows.Forms.Label lblBookDate;
        public System.Windows.Forms.Label lblBookCat;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblBookPrice;
        public System.Windows.Forms.Label lblBook;
        public System.Windows.Forms.Label lblBookAuthr;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuRating BookRate;
        public System.Windows.Forms.PictureBox BookCover;
    }
}