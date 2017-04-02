using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CaPhe.admin
{
    public partial class ThongKeDanhSo : UserControl
    {
        DBConnect connect;
        DataTable tblToanCuc;
        public ThongKeDanhSo()
        {
            InitializeComponent();
            connect = new DBConnect();
            loadDanhSoNgay();
            loadDataToanCuc();
            loadSPbanchay();
        }
        public void loadDanhSoNgay()
        {
            txtToday.Text = DateTime.Now.ToShortDateString().ToString();
            txtLuotMua.Text = connect.luotMuaHomNay()+"";
            txtTodayTien.Text = connect.doanhThuHomNay() + "";
            
        }
        public void loadDataToanCuc()
        {
            tblToanCuc = connect.excuteQuery("SELECT abc.dNgayLap ngaylap, SUM(Tien) tien FROM (SELECT CHITIETHOADON.sMaHD,iSoLuong*iDonGia Tien, dNgayLap  FROM  dbo.HOADON INNER JOIN dbo.CHITIETHOADON ON CHITIETHOADON.sMaHD = HOADON.sMaHD INNER JOIN dbo.SANPHAM ON dbo.SANPHAM.sMaSP = dbo.CHITIETHOADON.sMaSP) abc  GROUP BY abc.dNgayLap");
            dgvToanTime.DataSource = charThongke.DataSource = tblToanCuc;
            charThongke.ChartAreas["ChartArea1"].AxisX.Title = "Biểu đồ doanh số";
            charThongke.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền";
            charThongke.Series["Series1"].XValueMember = "ngaylap";
            charThongke.Series["Series1"].YValueMembers = "tien";

        }
        public void loadSPbanchay()
        {
            dgvBanChay.DataSource = connect.excuteQuery("Select * from vSanPhamTop");
        }
    }
}
