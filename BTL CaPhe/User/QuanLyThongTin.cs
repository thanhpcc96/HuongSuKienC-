using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CaPhe.User
{
    public partial class QuanLyThongTin : UserControl
    {
        private string sMaNV;
        string password;
        DBConnect connect;
        public QuanLyThongTin()
        {
            InitializeComponent();
        }
        public QuanLyThongTin(string sMaNV)
        {
            InitializeComponent();
            this.sMaNV = sMaNV;
            connect = new DBConnect();
            loadData();
        }
        // load data lên
        private void loadData()
        {
            DataTable tbl = connect.excuteQuery("Select * from NHANVIEN where sMaNV='"+this.sMaNV+"'");
            txtHoTen.Text = tbl.Rows[0]["sTenNV"].ToString();
            txtNgaySinh.Text = string.Format("{0:dd/MM/yyy}", Convert.ToDateTime(tbl.Rows[0]["dNgaySinh"]));
            string gt = tbl.Rows[0]["sGioiTinh"].ToString();
            if (gt.Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else rdNu.Checked = true;
            txtDiaChi.Text = tbl.Rows[0]["sDiaChi"].ToString();
            txtMaNV.Text = tbl.Rows[0]["sMaNV"].ToString();
            txtHeSoLuong.Text = tbl.Rows[0]["fHsl"].ToString();
            password = tbl.Rows[0]["sPassword"].ToString();

            // tính số hóa đơn 
            txtSLHD.Text =""+ connect.soHDnv(this.sMaNV);



           
            

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void QuanLyThongTin_Load(object sender, EventArgs e)
        {

        }

        private void txtMKHienTai_TextChanged(object sender, EventArgs e)
        {
            if (txtMKHienTai.Text.Equals(password))
            {
                txtMKMoi.ReadOnly = false;
                txtErr1.Text = "";
            }
            else txtErr1.Text = "Mật khẩu sai!";
        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.ReadOnly = !(txtMKMoi.Text.Length > 0);
        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text.Equals(txtMKMoi.Text))
            {
                btnXacNhan.Enabled = true;
                txtERR.Text = "";
            }
            else
            {
                txtERR.Text = "Xác nhận không khớp";
            }
        }

        private void btnHuyBo2_Click(object sender, EventArgs e)
        {
            txtMKHienTai.ResetText();
            txtERR.Text = txtErr1.Text = "";
            txtMKMoi.ResetText();
            txtXacNhanMK.ResetText();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMKHienTai.Text.Equals("") && txtXacNhanMK.Text.Equals("")) MessageBox.Show("Trống bố đéo cho đổi!");
            if (connect.excuteNonQuery("update NHANVIEN set sPassword='" + txtXacNhanMK.Text + "' where sMaNV='" + this.sMaNV + "'")==1)
            {
                MessageBox.Show("Cập Nhật Mật Khẩu Thành Công!");
            }
            else MessageBox.Show("Cập Nhật thất bại!");
        }

        private void txtHeSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
