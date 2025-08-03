using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text.Trim() == "")
            {
                PresentationLayer.FRM_DİALOG frmdialog = new FRM_DİALOG();
                frmdialog.Show();
            }
            else
            {
                if (ID == 0)
                {
                    // Add
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.Insert(txt_catname.Text);
                    PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                    frmadded.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.update(txt_catname.Text,ID);
                    PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                    frmedited.Show();
                    this.Close();
                }

            }
        }

        private void txt_catname_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
