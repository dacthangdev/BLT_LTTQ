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
    public partial class NuocUong : Form
    {
        public NuocUong()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelNuocUong.Visible == true)
                panelNuocUong.Visible = false;
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

        private void btnBia_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnCoCa_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnNuocSuoi_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }
    }
}
