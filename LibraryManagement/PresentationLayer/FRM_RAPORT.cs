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
    public partial class FRM_RAPORT : Form
    {
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
        public FRM_RAPORT()
        {
            InitializeComponent();
        }

        private void FRM_RAPORT_Load(object sender, EventArgs e)
        {
            // Basic Information
            PresentationLayer.FRM_MAIN FrmMain = new FRM_MAIN();
            lblName.Text = FrmMain.lblName.Text;
            lblPrem.Text = FrmMain.lblPrem.Text;
            lblDate.Text = DateTime.Now.ToString();
            //Numbers Information

            //FOR BOOK
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                lblBook.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR STUDENT
            try
            {
                DataTable dt = new DataTable();
                dt = BLST.Load();
                lblStudent.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR SELL
            try
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Load();
                lblSell.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR BORROW
            try
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Load();
                lblBorrow.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR CATEGORY
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.Load();
                lblCategory.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //FOR USERS
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSERS.Load();
                lblUsers.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnPrintView_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrintSettings_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img,0,0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
              
        }
    }
}
