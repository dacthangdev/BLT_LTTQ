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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customsizeDesing();
        }
        private void customsizeDesing()
        {
            panelMediaMenu.Visible = false;
     
        }
        private void hideSubMenu()
        {
            if (panelMediaMenu.Visible == true)
                panelMediaMenu.Visible = false;;
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

        private void iconbtnQuanLy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            btnNhanVien_Click(sender, e);
            showSubMenu(panelMediaMenu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openchildForm(new NhanVien());
            // code
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openchildForm(new KhachHang());
            // code

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            openchildForm(new DonHang());
            // code
        }

        private void iconbtnMenu_Click(object sender, EventArgs e)
        {
            openchildForm(new LayMonAnTuBanAn());
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconbtnBanAn_Click(object sender, EventArgs e)
        {
            openchildForm(new BanAn());
        }

        private void iconbtnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openchildForm(new Home());
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            openchildForm(new NuocUong());
            // code
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
