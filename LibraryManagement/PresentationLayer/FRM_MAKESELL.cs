using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_MAKESELL : Form
    {
        public int ID;
        public FRM_MAKESELL()
        {
            InitializeComponent();
        }

        private void txtcatname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadPictures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {



        }

        private void CatAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Trim() == "")
            {
                PresentationLayer.FRM_DİALOG frmdialog = new FRM_DİALOG();
                frmdialog.Show();
            }
            else
            {
                if (ID == 0)
                {

                    // Add Sell
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.Insert(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView2.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(txtPrice.Text), SellDate.Value.ToString());
                    PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                    frmadded.lblAdd.Text = "Đã bán sách thành công";
                    frmadded.Show();
                    this.Close();
                }
                else
                {
                    //Edit Book
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();

                    BLSELL.Update(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView2.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(txtPrice.Text), SellDate.Value.ToString(),ID);
                    PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                    frmedited.Show();
                    this.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAKESELL_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            // Load to Books
            DataTable dt1 = new DataTable();
            dataGridView2.DataSource = dt1 = BLSELL.LoadBOOKS();
            // Load to Student
            DataTable dt2 = new DataTable();
            dataGridView1.DataSource = dt2 = BLSELL.LoadST();

        }
    }
}
