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
    public partial class MonTrangMieng : Form
    {
        public MonTrangMieng()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelMonTrangMieng.Visible == true)
                panelMonTrangMieng.Visible = false;
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

        private void btnChe_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnCaramel_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnHoaQua_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }
    }
}
