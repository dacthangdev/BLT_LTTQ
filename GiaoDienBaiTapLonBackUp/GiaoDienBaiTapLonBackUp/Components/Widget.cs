using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienBaiTapLonBackUp.Components
{
    public partial class Widget : UserControl
    {
        public event EventHandler Onselect = null;
        public Widget()
        {
            InitializeComponent();
        }

        private void Widget_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }
        public string Title { get => label1.Text; set => label1.Text = value; }
        public string Cost { get => label2.Text; set => label2.Text = value; }
        public Image Icon { get => pictureBox1.Image; set => pictureBox1.Image = value; }
    }
}
