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
    public partial class FRM_ADDSTUDENT : Form
    {
        public int ID;
        public FRM_ADDSTUDENT()
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
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Cover.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {


        }

        private void CatAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text.Trim() == "" || txtLocation.Text.Trim() == "" || txtPhone.Text.Trim() == ""
                || txtIdNumber.Text.Trim() == "" || txtEmail.Text.Trim() == "")
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
                    BL.CLS_ST CLSST = new BL.CLS_ST();
                    CLSST.Insert(txtStudentName.Text, txtLocation.Text, txtPhone.Text, txtEmail.Text, txtSchool.Text, txtDep.Text, ma, txtIdNumber.Text);
                    PresentationLayer.FRM_ADDED frmadded = new FRM_ADDED();
                    frmadded.Show();
                    this.Close();
                }
                else
                {
                    //Edit STUDENT
                    BL.CLS_ST BLST = new BL.CLS_ST();
                    MemoryStream ma = new MemoryStream();
                    pic_Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    BLST.update(txtStudentName.Text, txtLocation.Text, txtPhone.Text, txtEmail.Text, txtSchool.Text, txtDep.Text, ma, txtIdNumber.Text, ID);
                    PresentationLayer.FRM_EDİTED frmedited = new FRM_EDİTED();
                    frmedited.Show();
                    this.Close();
                }
            }
        }

        private void txtIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex("^[0-9]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex("^[0-9+]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[a-zA-Z._@0-9]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[a-zA-ZÀ-ỹöçüğşİŞÇÖĞÜı\s]$");
            if (!rx.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
