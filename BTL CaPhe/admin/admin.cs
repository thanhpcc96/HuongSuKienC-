using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CaPhe.admin
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            GioiThieu gthieu = new GioiThieu();
            showControl(gthieu);
        }
        private void showControl(System.Windows.Forms.Control obj)
        {
            pnControl.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            pnControl.Controls.Add(obj);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            UserControl user = new QLNV();
            showControl(user);
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            UserControl luong = new QLLuong();
            showControl(luong);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            UserControl thongkedanhso = new ThongKeDanhSo();
            showControl(thongkedanhso);
        }

        private void btnDXuat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            UserControl sanpham = new QLSanpham();
            showControl(sanpham);
        }
    }
}
