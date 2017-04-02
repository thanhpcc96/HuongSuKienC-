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
    public partial class QLSanpham : UserControl
    {
        DBConnect connect;
        string trangthai;
        lib.Validate chuanhoa = new lib.Validate();
        public QLSanpham()
        {
            InitializeComponent();
            connect = new DBConnect();
            loadData();
        }
        public void loadData()
        {
            dgvSP.DataSource = connect.excuteQuery("Select * from SANPHAM");
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaSP.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text=dgvSP.CurrentRow.Cells[1].Value.ToString();
            txtDonGia.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai = "Them";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "Sua";
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            trangthai = "Sua";
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtDonGia.ResetText();
            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai.Equals("Them"))
            {
                if (txtMaSP.Text.Length > 0 && txtTenSP.Text.Length > 0 && txtDonGia.Text.Length > 0 && chuanhoa.isNumber(txtDonGia.Text))
                {
                    if (connect.excuteQuery("Select * from SANPHAM where sMaSP='" + txtMaSP.Text + "'").Rows.Count == 0)
                    {
                        if (connect.excuteNonQuery("INSERT INTO dbo.SANPHAM ( sMaSP, sTenSP, iDonGia ) VALUES('" + txtMaSP.Text + "','" + txtTenSP.Text + "'," + int.Parse(txtDonGia.Text) + ")") != 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            loadData();
                        }
                        else MessageBox.Show("Có lỗi xảy ra!");
                    }
                    else MessageBox.Show("Sản phẩm này tồn tại");
                }
                else MessageBox.Show("Vui lòng hoàn thành các trường!");
                
            }
            if (trangthai.Equals("Sua"))
            {
                if (txtMaSP.Text.Length > 0 && txtTenSP.Text.Length > 0 && txtDonGia.Text.Length > 0 && chuanhoa.isNumber(txtDonGia.Text))
                {
                    if (connect.excuteQuery("Select * from SANPHAM where sMaSP='" + txtMaSP.Text + "'").Rows.Count > 0)
                    {
                        if (connect.excuteNonQuery("UPDATE dbo.SANPHAM SET sTenSP='"+txtTenSP.Text+"',"+int.Parse(txtDonGia.Text)+")") != 0)
                        {
                            MessageBox.Show("Sửa thành công!");
                            loadData();
                        }
                        else MessageBox.Show("Có lỗi xảy ra!");
                    }
                    else MessageBox.Show("Sản phẩm KO tồn tại");
                }
                else MessageBox.Show("Vui lòng hoàn thành các trường!");
            }
            if (trangthai.Equals("Xoa"))
            {
                if (txtMaSP.Text.Length > 0 && txtTenSP.Text.Length > 0 && txtDonGia.Text.Length > 0 && chuanhoa.isNumber(txtDonGia.Text))
                {
                    if (connect.excuteQuery("Select * from SANPHAM where sMaSP='" + txtMaSP.Text + "'").Rows.Count > 0)
                    {
                        if (connect.excuteNonQuery("DELETE dbo.SANPHAM Where  sTenSP='" + txtTenSP.Text + "')" ) != 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            loadData();
                        }
                        else MessageBox.Show("Có lỗi xảy ra!");
                    }
                    else MessageBox.Show("Sản phẩm Ko tồn tại");
                }
                else MessageBox.Show("Vui lòng hoàn thành các trường!");
            }
        }
    }
}
