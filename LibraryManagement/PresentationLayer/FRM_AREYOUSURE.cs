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
    public partial class FRM_AREYOUSURE : Form
    {
        public static bool YesNo = false;
        public FRM_AREYOUSURE()
        {
            InitializeComponent();
        }

        private void FRM_AREYOUSURE_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(lblAreYouSure);
            bunifuTransition1.ShowSync(lblAreYouWant);
            bunifuTransition1.ShowSync(btnNo);
            bunifuTransition1.ShowSync(btnYes);

            // Vietnamese translations
            lblAreYouSure.Text = "Bạn có chắc chắn không?";
            lblAreYouWant.Text = "Bạn muốn thực hiện thao tác này?";
            btnYes.Text = "Có";
            btnNo.Text = "Không";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            YesNo = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_AREYOUSURE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
