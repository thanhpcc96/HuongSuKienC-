using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BTL_CaPhe
{
    
    class DBConnect
    {
        SqlConnection cnn = null;
        SqlCommand cmd = null;
        DataTable tbl;
        string connectString = ConfigurationManager.ConnectionStrings["DB_URI"].ConnectionString;
        public DBConnect()
        {
            cnn = new SqlConnection(connectString);
        }
        public DataTable excuteQuery(String query)
        {
            cnn.Open();
            cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tbl = new DataTable();
            da.Fill(tbl);
            cnn.Close();
            return tbl;
        }

        public int excuteNonQuery(String query)
        {
            int i = 0;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.Text;
                i = cmd.ExecuteNonQuery();
                cnn.Close();
            } catch(SqlException ex)
            {
                Console.Write(ex.ToString());
            }
            return i;
        }
        public DataTable checkLogin(string username)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pCheckLogin";
            cmd.Parameters.AddWithValue("@username", username);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cnn.Close();
            return tb;
        }
        // đếm số hóa đơn bán dk của 1 nhân viên
        public int soHDnv(string sMaNV)
        {
            cmd = new SqlCommand("Select count(sMaHD) from HOADON where sMaNV='" + sMaNV + "'",cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            int i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }
        public DataTable loadLuong(int luong)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pLoadLuong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@luong",luong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        public int ThemNhanVien(string manv, string hoten, string ngaysinh,string gt,string diachi,string chucvu, float hsl, string passs)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pThemNhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", hoten);
            cmd.Parameters.AddWithValue("@dNgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@sGioiTinh", gt);
            cmd.Parameters.AddWithValue("@sDiaChi", diachi);
            cmd.Parameters.AddWithValue("@sChucVu", chucvu);
            cmd.Parameters.AddWithValue("@fHsl", hsl);
            cmd.Parameters.AddWithValue("@sPassword", passs);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        public int XoaNV(string manv)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pXoaNV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sMaNV", manv);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        public int SuaThongTinNV(string manv, string hoten, string ngaysinh, string gt, string diachi, string chucvu, float hsl, string passs)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pSuaThongTinNV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", hoten);
            cmd.Parameters.AddWithValue("@dNgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@sGioiTinh", gt);
            cmd.Parameters.AddWithValue("@sDiaChi", diachi);
            cmd.Parameters.AddWithValue("@sChucVu", chucvu);
            cmd.Parameters.AddWithValue("@fHsl", hsl);
            cmd.Parameters.AddWithValue("@sPassword", passs);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;

        }

        /// thêm hóa đơn
        public int ThemHD(string mahd,string manv)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pThemHD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sMaHD", mahd);
            cmd.Parameters.AddWithValue("@sMaNV", manv);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;

        }
        // thêm chi tiết hóa đơn
        public int themCTHD(string mahd, string masp,int soluong)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pThemCTHD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sMaHD", mahd);
            cmd.Parameters.AddWithValue("@sMaSP", masp);
            cmd.Parameters.AddWithValue("@iSoLuong", soluong);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
        // tính doanh số ngày
        public int luotMuaHomNay()
        {
            cmd = new SqlCommand("SELECT COUNT(sMaHD) FROM dbo.HOADON WHERE DAY(dNgayLap)=DAY(GETDATE()) AND MONTH(dNgayLap)= MONTH(GETDATE()) AND YEAR(dNgayLap)=YEAR(GETDATE())",cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            int i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }
        // doanh số hôm nay
        public int doanhThuHomNay()
        {
            cmd = new SqlCommand(" SELECT SUM(Tien) FROM (SELECT CHITIETHOADON.sMaHD,iSoLuong*iDonGia Tien, dNgayLap  FROM  dbo.HOADON INNER JOIN dbo.CHITIETHOADON ON CHITIETHOADON.sMaHD = HOADON.sMaHD INNER JOIN dbo.SANPHAM ON dbo.SANPHAM.sMaSP = dbo.CHITIETHOADON.sMaSP) abc  WHERE DAY(abc.dNgayLap) = DAY(GETDATE()) AND MONTH(abc.dNgayLap) = MONTH(GETDATE()) AND YEAR(abc.dNgayLap) = YEAR(GETDATE())",cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            int i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }
        //sản phẩm bán chạy trong tháng này
       // public DataTable sanphambanchay()
        //{
            //cmd = cnn.CreateCommand();
           // cmd.CommandText = "pSanphambanchay";
          //  cmd.CommandType=CommandType.StoredProcedure
       // }

        // report hóa đơn
        public DataTable reportHoaDon(string mahd)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pReportHD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sMaHD", mahd);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(reader);
            cnn.Close();
            return tb;
          
        }
        public DataTable inLuong(float phantram,int sohd, int luongcoban)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = "pInLuong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phantramhoahong", phantram);
            cmd.Parameters.AddWithValue("@sohoadon", sohd);
            cmd.Parameters.AddWithValue("@luongcoban", luongcoban);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(reader);
            cnn.Close();
            return tb;
        }


    }
}
