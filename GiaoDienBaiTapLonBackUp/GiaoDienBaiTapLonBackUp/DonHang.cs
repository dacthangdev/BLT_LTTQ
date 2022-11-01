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
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
            txtTimKiemDH.ForeColor = SystemColors.GrayText;
            txtTimKiemDH.Text = "Nhập mã đơn hàng để tìm";
            this.txtTimKiemDH.Leave += new System.EventHandler(this.txtTimKiemDH_Leave);
            this.txtTimKiemDH.Enter += new System.EventHandler(this.txtTimKiemDH_Enter);
        }

        private void txtTimKiemDH_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemDH.Text.Length == 0)
            {
                txtTimKiemDH.Text = "Nhập mã đơn hàng để tìm";
                txtTimKiemDH.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTimKiemDH_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemDH.Text == "Nhập mã đơn hàng để tìm")
            {
                txtTimKiemDH.Text = "";
                txtTimKiemDH.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themdonhang lb = new Themdonhang();
            lb.ShowDialog();
        }
    }
}
