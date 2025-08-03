
namespace LibraryManagement.PresentationLayer
{
    partial class FRM_ADDCAT
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
            this.btnCatAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txt_catname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCatAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCatAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnCatAdd.BorderRadius = 20;
            this.btnCatAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnCatAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatAdd.FillColor = System.Drawing.Color.Purple;
            this.btnCatAdd.FillColor2 = System.Drawing.Color.Black;
            this.btnCatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnCatAdd.ForeColor = System.Drawing.Color.White;
            this.btnCatAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCatAdd.ImageOffset = new System.Drawing.Point(0, 20);
            this.btnCatAdd.ImageSize = new System.Drawing.Size(65, 65);
            this.btnCatAdd.Location = new System.Drawing.Point(184, 321);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(335, 85);
            this.btnCatAdd.TabIndex = 4;
            this.btnCatAdd.Text = "Thêm";
            this.btnCatAdd.Tile = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.txt_catname);
            this.guna2GradientPanel1.Controls.Add(this.btnClose);
            this.guna2GradientPanel1.Controls.Add(this.btnCatAdd);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(703, 465);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // txt_catname
            // 
            this.txt_catname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_catname.BackgroundImage = global::LibraryManagement.Properties.Resources.background1;
            this.txt_catname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_catname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_catname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_catname.ForeColor = System.Drawing.Color.Purple;
            this.txt_catname.HintForeColor = System.Drawing.Color.Gray;
            this.txt_catname.HintText = "Tên danh mục";
            this.txt_catname.isPassword = false;
            this.txt_catname.LineFocusedColor = System.Drawing.Color.Purple;
            this.txt_catname.LineIdleColor = System.Drawing.Color.Purple;
            this.txt_catname.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.txt_catname.LineThickness = 7;
            this.txt_catname.Location = new System.Drawing.Point(111, 182);
            this.txt_catname.Margin = new System.Windows.Forms.Padding(8);
            this.txt_catname.Name = "txt_catname";
            this.txt_catname.Size = new System.Drawing.Size(481, 78);
            this.txt_catname.TabIndex = 6;
            this.txt_catname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_catname.OnValueChanged += new System.EventHandler(this.txt_catname_OnValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(23, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục";
            // 
            // FRM_ADDCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(703, 465);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDCAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Guna.UI2.WinForms.Guna2GradientButton btnCatAdd;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnClose;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_catname;
        private System.Windows.Forms.Label label1;
    }
}