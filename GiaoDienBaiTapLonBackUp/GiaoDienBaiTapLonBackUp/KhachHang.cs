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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            txtTimKiemKH.ForeColor = SystemColors.GrayText;
            txtTimKiemKH.Text = "Nhập tên hoặc mã khách hàng để tìm";
            this.txtTimKiemKH.Leave += new System.EventHandler(this.txtTimKiemKH_Leave);
            this.txtTimKiemKH.Enter += new System.EventHandler(this.txtTimKiemKH_Enter);
        }

        private void txtTimKiemKH_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text.Length == 0)
            {
                txtTimKiemKH.Text = "Nhập tên hoặc mã khách hàng để tìm";
                txtTimKiemKH.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTimKiemKH_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "Nhập tên hoặc mã khách hàng để tìm")
            {
                txtTimKiemKH.Text = "";
                txtTimKiemKH.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

        }
    }
}
