using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace GiaoDienBaiTapLonBackUp
{
    public partial class KhachHang : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
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
        private void KhachHang_Load(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.bTLLTTQDataSet1.KhachHang);
            LoadData();
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[2].HeaderText = "Số Điện Thoại";



        }
        void LoadData()
        {
            DataTable dtKhachHang = data.ReadData("select * from KhachHang");
            dgvKhachHang.DataSource = dtKhachHang;
        }

       
    }
}
