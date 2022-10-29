using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienBaiTapLonBackUp
{
    public partial class BanAn : Form
    {
        public BanAn()
        {
            InitializeComponent();
        }

        private void grbSoLuongBan_Enter(object sender, EventArgs e)
        {

        }
        //private Form activeForm = null;
        //private void openchildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    grbSoLuongBan.Controls.Add(childForm);
        //    grbSoLuongBan.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        private void btnBan1_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }
    }
}
