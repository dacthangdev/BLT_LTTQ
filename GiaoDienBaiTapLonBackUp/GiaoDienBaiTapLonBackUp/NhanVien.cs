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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            txtTimKiemNV.ForeColor = SystemColors.GrayText;
            txtTimKiemNV.Text = "Nhập tên nhân viên hoặc mã nhân viên để tìm";
            this.txtTimKiemNV.Leave += new System.EventHandler(this.txtTimKiemNV_Leave);
            this.txtTimKiemNV.Enter += new System.EventHandler(this.txtTimKiemNV_Enter);
        }

        private void txtTimKiemNV_Leave(object sender, EventArgs e)
        {

            if (txtTimKiemNV.Text.Length == 0)
            {
                txtTimKiemNV.Text = "Nhập tên nhân viên hoặc mã nhân viên để tìm";
                txtTimKiemNV.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTimKiemNV_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemNV.Text == "Nhập tên nhân viên hoặc mã nhân viên để tìm")
            {
                txtTimKiemNV.Text = "";
                txtTimKiemNV.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
