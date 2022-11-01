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
        private Form activeForm = null;
        private void openchildFormThanhToan(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelOder.Controls.Add(childForm);
            panelOder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBan1_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            openchildFormThanhToan(new ThanhToan());
        }
    }
}
