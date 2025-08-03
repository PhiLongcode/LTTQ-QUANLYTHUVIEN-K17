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
    public partial class FRM_ADDED : Form
    {
        public FRM_ADDED()
        {
            InitializeComponent();
        }

        private void FRM_ADDED_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(lblAdd);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDED_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
