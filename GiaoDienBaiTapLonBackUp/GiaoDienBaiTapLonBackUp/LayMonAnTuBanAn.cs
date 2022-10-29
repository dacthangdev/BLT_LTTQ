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
    public partial class LayMonAnTuBanAn : Form
    {
        public LayMonAnTuBanAn()
        {
            InitializeComponent();
            customsizeDesing();
        }
        private void customsizeDesing()
        {
            panelMonChinh.Visible = false;
            panelMonKhaiVi.Visible = false;
            panelMonTrangMieng.Visible = false;
            panelDoUong.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMonChinh.Visible == true)
                panelMonChinh.Visible = false;
            if (panelMonKhaiVi.Visible == true)
                panelMonKhaiVi.Visible = false;
            if (panelMonTrangMieng.Visible == true)
                panelMonTrangMieng.Visible = false;
            if (panelDoUong.Visible == true)
                panelDoUong.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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

        private void btnChe_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void btnCaramel_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new FormMonAn());
        }

        private void iconbtnMonKhaiVi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMonKhaiVi);
        }

        private void iconbtnMonChinh_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMonChinh);
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

        private void iconbtnDoUong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoUong);
        }

        private void iconbtnMonTrangMieng_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMonTrangMieng);
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LayMonAnTuBanAn_Load(object sender, EventArgs e)
        {
            iconbtnMonKhaiVi_Click(sender, e);
            buttonSupBap_Click(sender, e);
        }
    }
}
