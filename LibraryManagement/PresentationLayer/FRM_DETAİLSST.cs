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
    public partial class FRM_DETAİLSST: Form
    {
        public FRM_DETAİLSST()
        {
            InitializeComponent();
            // Ensure form has a solid background to avoid transparency issues
            this.BackColor = System.Drawing.Color.Black;
        }

        private void FRM_DETAİLSBOOKS_Load(object sender, EventArgs e)
        {
            // Form will display normally without any transition issues
            // All controls are properly initialized in Designer
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_DETAİLSBOOKS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
