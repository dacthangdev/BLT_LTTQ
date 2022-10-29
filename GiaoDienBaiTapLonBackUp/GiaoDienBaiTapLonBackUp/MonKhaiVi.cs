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
    public partial class MonKhaiVi : Form
    {
        public MonKhaiVi()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelMonKhaiVi.Visible == true)
                panelMonKhaiVi.Visible = false;
        }
        private Form activeForm = null;
        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHienThiMonAn.Controls.Add(childForm);
            panelHienThiMonAn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSupBap_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnSupBiNgo_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnKhoaiTayChien_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnDauLuotVan_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnGoiHaiSan_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnGioHeoMuoi_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnSaLad_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnDauPhong_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBia_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }
    }
}
