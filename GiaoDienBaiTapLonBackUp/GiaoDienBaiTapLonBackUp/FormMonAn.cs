using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienBaiTapLonBackUp
{
    public partial class FormMonAn : Form
    {
        Classes.ConnectData dta = new Classes.ConnectData();
        string tenmon;
        public FormMonAn()
        {
            InitializeComponent();
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            try
            {
                tenmon = Classes.StaticData.tenmon;
                DataTable dataTable = dta.ReadData("select * from monan where tenmon = N'" + tenmon + "'");
                string fileanh = dataTable.Rows[0]["hinhanh"].ToString();
                lblMota.Text = dataTable.Rows[0]["mota"].ToString();
                lblGiathanh.Text = dataTable.Rows[0]["giatien"].ToString();
                ptbMonan.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + fileanh);
            }
            catch
            {

            }
        }

        private void iconbtnShip_Click(object sender, EventArgs e)
        {

        }

        private void iconbtnGoiMon_Click(object sender, EventArgs e)
        {

        }
    }
}
