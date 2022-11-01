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
        Classes.ConnectData data = new Classes.ConnectData();
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
        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTLLTTQDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.bTLLTTQDataSet.NhanVien);
            LoadData();
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[3].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns[4].HeaderText = "Trạng Thái";

        }
        void LoadData()
        {
            DataTable dtNhanVien = data.ReadData("select * from NhanVien");
            dgvNhanVien.DataSource = dtNhanVien;
        }

        
    }
}
