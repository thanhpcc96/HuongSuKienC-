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
    public partial class QLNV : UserControl
    {
        DBConnect connect;
        string trangthainut;
        public QLNV()
        {
            InitializeComponent();
            connect = new DBConnect();

        }
        private void loadDataGridView()
        {
            this.dgvDSNV.DataSource = connect.excuteQuery("Select * from vloadNV");
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void clearData() // xóa data từ các ô nhập
        {
            txtMaNV.Enabled = true;
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtHsl.ResetText();
            txtPass.ResetText();
            txtDiaChi.ResetText();
            
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            clearData();
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthainut = "Them";
            txtMaNV.ReadOnly = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            trangthainut = "Xoa";
            txtMaNV.ReadOnly = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthainut = "Sua";
            txtMaNV.ReadOnly = true;
            btnLuu.Enabled = true;
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaNV.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNV.Text = dgvDSNV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSNV.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvDSNV.CurrentRow.Cells[2].Value.ToString();
            if (dgvDSNV.CurrentRow.Cells[3].Value.ToString().Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else rdNu.Checked = true;
            txtDiaChi.Text = dgvDSNV.CurrentRow.Cells[4].Value.ToString();
            txtChucVu.Text = dgvDSNV.CurrentRow.Cells[5].Value.ToString();
            txtHsl.Text = dgvDSNV.CurrentRow.Cells[6].Value.ToString();
            txtPass.Text = dgvDSNV.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length > 0 && txtHoTen.Text.Length > 0 && txtDiaChi.Text.Length > 0 && txtHsl.Text.Length > 0 && dtNgaySinh.Text.Length > 0) {
                if (trangthainut.Equals("Them"))
                {
                    if (connect.excuteQuery("Select * from NHANVIEN where sMaNV='" + txtMaNV.Text + "'").Rows.Count == 0)
                    {
                        string gt = (rdNam.Checked == true) ? "Nam" : "Nữ";
                        //string chucvu = cbChucVu.SelectedText.ToString();
                        if (connect.ThemNhanVien(txtMaNV.Text, txtHoTen.Text, dtNgaySinh.Text, gt, txtDiaChi.Text,txtChucVu.Text, float.Parse(txtHsl.Text), txtPass.Text) !=0)
                        {
                            MessageBox.Show("Them thanh cong!");
                            loadDataGridView();
                        }
                        else { MessageBox.Show("Them That bai"); }
                    }
                    else MessageBox.Show("Nhân viên này đã tồn tại");
                }
                if (trangthainut.Equals("Sua"))
                {
                    if (connect.excuteQuery("select * from NHANVIEN where sMaNV='" + txtMaNV.Text + "'").Rows.Count > 0)
                    {
                        string gt = (rdNam.Checked == true) ? "Nam" : "Nữ";
                        if (connect.SuaThongTinNV(txtMaNV.Text, txtHoTen.Text, dtNgaySinh.Text, gt, txtDiaChi.Text, txtChucVu.Text, float.Parse(txtHsl.Text), txtPass.Text) !=0)
                        {
                            MessageBox.Show("Sửa Thành công!");
                            loadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Rồi!");
                        }
                    }
                    else MessageBox.Show("Nhân viên Này ko tồn tại!");
                }
                if (trangthainut.Equals("Xoa"))
                {
                    if (connect.excuteQuery("select * from NHANVIEN where sMaNV='" + txtMaNV.Text + "'").Rows.Count > 0)
                    {
                        if (connect.XoaNV(txtMaNV.Text) !=0)
                        {
                            MessageBox.Show("Xóa Thành Công!");
                            loadDataGridView();
                        }
                        else MessageBox.Show("Không thành công!");
                    }
                    else MessageBox.Show("Chọn Nhân Viên Cần Loại bỏ!");
                }
            }
        }
    }
}
