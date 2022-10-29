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
        bool is_tang_1_click = false;
        bool is_tang_2_click = false;
        bool is_tang_3_click = false;
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
        // adkjqwdhoahdyoqwhdoasdhoqidwh


        private void btnTang1_Click(object sender, EventArgs e)
        {
            is_tang_1_click = true;
            btnTang1.BackColor = Color.Red;
            btnTang2.BackColor = Color.White;
            btnTang3.BackColor = Color.White;
            is_tang_2_click = false;
            is_tang_3_click = false;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            is_tang_2_click = true;
            btnTang2.BackColor = Color.Red;
            btnTang1.BackColor = Color.White;
            btnTang3.BackColor = Color.White;
            is_tang_1_click = false;
            is_tang_3_click = false;
        }

        private void btnTang3_Click(object sender, EventArgs e)
        {
            is_tang_3_click = true;
            btnTang3.BackColor = Color.Red;
            btnTang2.BackColor = Color.White;
            btnTang1.BackColor = Color.White;
            is_tang_2_click = false;
            is_tang_1_click = false;
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan1.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan1.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan1.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            grbSoLuongBan.Visible = false;
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan2.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan2.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan2.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan3.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan3.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan3.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan4.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan4.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan4.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan5.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan5.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan5.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan6.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan6.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan6.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan7.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan7.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan7.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan8.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan8.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan8.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            if (is_tang_1_click)
            {
                lbtTable.Text = "Bàn " + btnBan9.Text + " - " + btnTang1.Text;
            }
            else if (is_tang_2_click) lbtTable.Text = "Bàn " + btnBan9.Text + " - " + btnTang2.Text;
            else if (is_tang_3_click) lbtTable.Text = "Bàn " + btnBan9.Text + " - " + btnTang3.Text;
            else lbtTable.Text = "Bạn chưa chọn bàn!";
            LayMonAnTuBanAn lb = new LayMonAnTuBanAn();
            lb.ShowDialog();
        }

    }
}
