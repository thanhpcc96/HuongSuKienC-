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
    public partial class QLLuong : UserControl
    {
        DBConnect connect;
        int sl;
        lib.Validate chuanhoa = new lib.Validate();
        bool trangthai;
        public QLLuong()
        {
            InitializeComponent();
            connect = new DBConnect();
            trangthai = txtLuongCB.Text.Length > 0;
            if (trangthai) loadDataGridViewCoLuong();
            else loadDataGridViewChuaLuong();
           
        }
        public void loadDataGridViewCoLuong()
        {
            int LuonngCB;

            if (txtLuongCB.Text.Equals(""))
            {
                LuonngCB = 0;
            }
            else
            {
                try
                {
                    LuonngCB = int.Parse(txtLuongCB.Text);
                    dgvLuong.DataSource = connect.loadLuong(int.Parse(txtLuongCB.Text));
                }
                catch
                {
                    MessageBox.Show("Nhập Lại lương cơ bản!");
                    txtLuongCB.Focus();
                }
            }
        }
        public void loadDataGridViewChuaLuong()
        {
            dgvLuong.DataSource = connect.excuteQuery("Select * from vLoadLuong"); 
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtMaNV.Text = dgvLuong.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvLuong.CurrentRow.Cells[1].Value.ToString();
                txtHeSoLuong.Text = dgvLuong.CurrentRow.Cells[3].Value.ToString();
                // hóa đơn nv đó bán dk;
                if (txtMaNV.Text.Length > 0 && trangthai)
                {
                    sl = connect.soHDnv(txtMaNV.Text);
                    txtSoluonghoadon.Text = sl + "";
                    int luong = int.Parse(dgvLuong.CurrentRow.Cells[4].Value.ToString());
                    if (txtPhanTram.Text.Length == 0)
                    {
                        txtTongLuong.Text = luong + "";
                    }
                    else
                    {
                        txtTongLuong.Text = sl * int.Parse(txtPhanTram.Text) + luong + "";
                    }

                }
                else
                {
                    MessageBox.Show("Ko load được Nhân Viên! vui lòng nhập đủ thông tin");
                }
            
            
            
            
        }

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {
            if (!chuanhoa.isNumber(txtPhanTram.Text))
            {
                txtPhanTram.ResetText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length > 0) {
                if (connect.excuteQuery("select * from NHANVIEN where sMaNV='" + txtMaNV.Text + "'").Rows.Count == 0)
                {
                    MessageBox.Show("Kiểm tra lại nhân viên!(mã)");
                    txtMaNV.Focus();
                }
                else
                {
                    if (connect.excuteNonQuery("Update NHANVIEN SET fHsl=" + txtHeSoLuong) != 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    else MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (chuanhoa.isNumber(txtLuongCB.Text))
            {
                trangthai = true;
                loadDataGridViewCoLuong();
            }
            else MessageBox.Show("Lương cơ bản không hợp lệ!");
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (txtLuongCB.Text.Length > 0 && txtPhanTram.Text.Length > 0)
            {
                if (chuanhoa.isNumber(txtPhanTram.Text) && chuanhoa.isNumber(txtLuongCB.Text))
                {
                    finLuong f = new finLuong();
                    f.phantramhoahong = float.Parse(txtPhanTram.Text);
                    if (int.Parse(txtSoluonghoadon.Text) == 0) f.sohoadon = 0;
                    else f.sohoadon = int.Parse(txtSoluonghoadon.Text);
                    f.luongcoban = int.Parse(txtLuongCB.Text);
                    this.Hide();
                    f.ShowDialog(this);
                }
                else MessageBox.Show("Ồ! không phải số trong dữ liệu cảu bạn!");
            }
            else MessageBox.Show("Ồ! Lại bỏ trống ô nào rồi!");
        }
    }
}
