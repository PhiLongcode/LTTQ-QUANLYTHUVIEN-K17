
namespace LibraryManagement.PresentationLayer
{
    partial class FRM_AREYOUSURE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AREYOUSURE));
            this.lblAreYouWant = new System.Windows.Forms.Label();
            this.lblAreYouSure = new System.Windows.Forms.Label();
            this.btnNo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnYes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // lblAreYouWant
            // 
            this.lblAreYouWant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAreYouWant.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAreYouWant, BunifuAnimatorNS.DecorationType.None);
            this.lblAreYouWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouWant.ForeColor = System.Drawing.Color.Indigo;
            this.lblAreYouWant.Location = new System.Drawing.Point(292, 252);
            this.lblAreYouWant.Name = "lblAreYouWant";
            this.lblAreYouWant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAreYouWant.Size = new System.Drawing.Size(410, 42);
            this.lblAreYouWant.TabIndex = 12;
            this.lblAreYouWant.Text = "Bạn có muốn tiếp tục..";
            this.lblAreYouWant.Visible = false;
            // 
            // lblAreYouSure
            // 
            this.lblAreYouSure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAreYouSure.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAreYouSure, BunifuAnimatorNS.DecorationType.None);
            this.lblAreYouSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouSure.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblAreYouSure.Location = new System.Drawing.Point(265, 188);
            this.lblAreYouSure.Name = "lblAreYouSure";
            this.lblAreYouSure.Size = new System.Drawing.Size(496, 42);
            this.lblAreYouSure.TabIndex = 13;
            this.lblAreYouSure.Text = "Bạn sắp xóa danh mục này";
            this.lblAreYouSure.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.ActiveBorderThickness = 1;
            this.btnNo.ActiveCornerRadius = 20;
            this.btnNo.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnNo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNo.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.BackColor = System.Drawing.Color.Black;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.ButtonText = "Không";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNo, BunifuAnimatorNS.DecorationType.None);
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Silver;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleCornerRadius = 20;
            this.btnNo.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnNo.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnNo.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnNo.Location = new System.Drawing.Point(330, 404);
            this.btnNo.Margin = new System.Windows.Forms.Padding(8);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(157, 50);
            this.btnNo.TabIndex = 14;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.ActiveBorderThickness = 1;
            this.btnYes.ActiveCornerRadius = 20;
            this.btnYes.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnYes.ActiveForecolor = System.Drawing.Color.White;
            this.btnYes.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.ButtonText = "Có";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnYes, BunifuAnimatorNS.DecorationType.None);
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Silver;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleCornerRadius = 20;
            this.btnYes.IdleFillColor = System.Drawing.Color.MediumOrchid;
            this.btnYes.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnYes.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnYes.Location = new System.Drawing.Point(529, 404);
            this.btnYes.Margin = new System.Windows.Forms.Padding(8);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(157, 50);
            this.btnYes.TabIndex = 15;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
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
            // 
            // FRM_AREYOUSURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1022, 642);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAreYouWant);
            this.Controls.Add(this.lblAreYouSure);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_AREYOUSURE";
            this.Opacity = 0.85D;
            this.Text = "FRM_AREYOUSURE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_AREYOUSURE_Load);
            this.Click += new System.EventHandler(this.FRM_AREYOUSURE_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnNo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYes;
        private System.Windows.Forms.Label lblAreYouWant;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Label lblAreYouSure;
    }
}