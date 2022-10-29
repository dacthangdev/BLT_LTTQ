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
    public partial class MonChinh : Form
    {
        public MonChinh()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelMonChinh.Visible == true)
                panelMonChinh.Visible = false;
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

        private void btnEchRangMuoi_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnGaChien_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnGaUMuoi_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBoSot_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBoLuLac_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnLauEch_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBaBaRang_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBaBaOm_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnBaBaNau_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }
    }
}
