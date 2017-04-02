using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CaPhe.User
{
    public partial class User : Form
    {
        private string sMaNV;
        private string sTenNV;
        public User()
        {
            InitializeComponent();
            UserControl gioithieu = new GioiThieu();
            this.Text = "Xin Chào " + this.sTenNV;
            loadPanel(gioithieu);
        }
        public User(string sMaNV, string sTenNV)
        {
            this.sMaNV = sMaNV;
            this.sTenNV = sTenNV;
            InitializeComponent();
            UserControl gioithieu = new GioiThieu();
            this.Text = "Xin Chào " + this.sTenNV;
            loadPanel(gioithieu);
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            UserControl laphoadon = new LapHD(this.sMaNV, this.sTenNV);
            loadPanel(laphoadon);

        }
        private void loadPanel(System.Windows.Forms.Control obj)
        {
            pnUser.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            pnUser.Controls.Add(obj);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            UserControl thongtincanhan = new QuanLyThongTin(this.sMaNV);
            loadPanel(thongtincanhan);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
