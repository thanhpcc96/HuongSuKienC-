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
    public partial class LapHD : UserControl
    {
        string sMaNV, sTenNV;
        DBConnect connect;
        DataTable tblChon, tblSP;
        int soHD;
        bool trangthaithanhtoan = false;
        string sMaHoaDon;
        public LapHD()
        {
            InitializeComponent();
            connect = new DBConnect();
            taoMoiDSChon();
        }
        public LapHD(string sMaNV, string sTenNV)
        {
            this.sMaNV = sMaNV;
            this.sTenNV = sTenNV;
            InitializeComponent();
            this.txtTenNV.Text = this.sTenNV;
            connect = new DBConnect();
            taoMoiDSChon();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LapHD_Load(object sender, EventArgs e)
        {
            lbSanPham.DataSource =tblSP= connect.excuteQuery("Select * from SANPHAM");
            lbSanPham.ValueMember="sMaSP";
            lbSanPham.DisplayMember = "sTenSP";
        }
        private void load_DataGridView()
        {
            dgvSanPham.DataSource = tblChon;
            txtTongTien.Text= tblChon.Compute("Sum(thanhTien)", "").ToString();
        }

        private void lbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            foreach (DataRow r in tblChon.Rows)
            {
                if (lbSanPham.SelectedValue.Equals(r["maSP"]))
                {

                    r["soLuong"] = int.Parse(r["soLuong"].ToString()) + 1;
                    load_DataGridView();
                    return;
                }
            }
            int spChon = lbSanPham.SelectedIndex;

            String ma = tblSP.Rows[spChon]["sMaSP"].ToString();
            String ten = tblSP.Rows[spChon]["sTenSP"].ToString();
            int gia = int.Parse(tblSP.Rows[spChon]["iDonGia"].ToString());
            int sl = 1;

            tblChon.Rows.Add(ma, ten, gia, sl);

            load_DataGridView();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            soHD = int.Parse(connect.excuteQuery("Select count(sMaHD) somahoadon from HOADON").Rows[0]["somahoadon"].ToString());
            if (tblChon.Rows.Count > 0)
            {
                int idHD = soHD + 1;
                sMaHoaDon = "HD" +idHD;
                connect.ThemHD(sMaHoaDon, this.sMaNV);
                foreach (DataRow r in tblChon.Rows)
                {
                    if (connect.themCTHD(sMaHoaDon, r["maSP"].ToString(), int.Parse(r["soLuong"].ToString())) == -1) Console.WriteLine("Thêm thành công" + sMaHoaDon + " " + r["maSP"].ToString());
                    else Console.WriteLine("Thêm thất bại " + sMaHoaDon + " " + r["maSP"].ToString());
                }
                MessageBox.Show("Thêm Thành Công!");
                trangthaithanhtoan = true;
            }
            else MessageBox.Show("Hóa đơn không có sản phẩm nào!");
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            taoMoiDSChon();
            trangthaithanhtoan = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvSanPham.SelectedRows)
            {
                dgvSanPham.Rows.Remove(r);
            }
            tblChon = (DataTable)dgvSanPham.DataSource;
            load_DataGridView();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (tblChon.Rows.Count > 0 && trangthaithanhtoan == true)
            {
                fLapHD f = new fLapHD();
                f.sMaHD = this.sMaHoaDon;
                this.Hide();
                f.ShowDialog(this);
                this.Show();
            }
            else MessageBox.Show("Vui lòng chọn sản phẩm và thanh toán!");
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void taoMoiDSChon()
        {
            tblChon = new DataTable();
            tblChon.Columns.Add("maSP", typeof(string));
            tblChon.Columns.Add("tenSP", typeof(string));
            tblChon.Columns.Add("donGia", typeof(int));
            tblChon.Columns.Add("soLuong", typeof(int));
            tblChon.Columns.Add("thanhTien", typeof(double), "donGia * soLuong");

            load_DataGridView();
        }
    }
   
}
