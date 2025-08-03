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
using System.Text.RegularExpressions;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_ADDBOOKS : Form
    {
        public int ID;
        public FRM_ADDBOOKS()
        {
            InitializeComponent();
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadPictures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Cover.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_BOOKS CLSBOOKS = new BL.CLS_BOOKS();
                DataTable dt = new DataTable();
                dt = CLSBOOKS.LOADCAT();
                object[] obj = new object[dt.Rows.Count];
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i] = dt.Rows[i]["CAT_NAME"];
                }
                comboBox1.Items.AddRange(obj);
            }
            catch
            {

            }


        }

        private void CatAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PresentationLayer.FRM_ADDCAT Fcat = new FRM_ADDCAT();
            Fcat.btnCatAdd.Text = "Thêm";
            Fcat.ID = 0;
            bunifuTransition1.ShowSync(Fcat);
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text.Trim() == "" || txtauther.Text.Trim() == "" || txtprice.Text.Trim() == "")
            {
                PresentationLayer.FRM_DİALOG frmdialog = new FRM_DİALOG();
                frmdialog.Show();
            }
            else
            {
                if (ID == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    pic_Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);


                    // Add Book
                    BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                    BLBOOKS.Insert(txtbookname.Text, txtauther.Text, comboBox1.Text, txtprice.Text, BookDate.Value.ToString(), bunifuRating1.Value, ma);
                    PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                    frmadded.Show();
                    this.Close();
                }
                else
                {
                    //Edit Book
                    BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                    MemoryStream ma = new MemoryStream();
                    pic_Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    BLBOOKS.update(txtbookname.Text, txtauther.Text, comboBox1.Text, txtprice.Text, BookDate.Value.ToString(), bunifuRating1.Value, ma, ID);
                    PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                    frmedited.Show();
                    this.Close();
                }
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex("^[0-9]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtauther_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[a-zA-ZÀ-ỹöçşığüİŞÇÖÜĞ\s]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
