namespace BTL_CaPhe.User
{
    partial class QuanLyThongTin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLHD = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtErr1 = new System.Windows.Forms.Label();
            this.txtERR = new System.Windows.Forms.Label();
            this.btnHuyBo2 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKHienTai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyBo);
            this.groupBox1.Controls.Add(this.btnSuaThongTin);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cá Nhân";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(173, 372);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(83, 38);
            this.btnHuyBo.TabIndex = 11;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Image = global::BTL_CaPhe.Properties.Resources.update;
            this.btnSuaThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaThongTin.Location = new System.Drawing.Point(22, 372);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(145, 38);
            this.btnSuaThongTin.TabIndex = 10;
            this.btnSuaThongTin.Text = "Cập nhật thông tin";
            this.btnSuaThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(81, 106);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(80, 20);
            this.txtNgaySinh.TabIndex = 9;
            this.txtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdNu);
            this.groupBox3.Controls.Add(this.rdNam);
            this.groupBox3.Location = new System.Drawing.Point(19, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(165, 41);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(62, 41);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(73, 264);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(175, 64);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(73, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(175, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSLHD);
            this.groupBox2.Controls.Add(this.txtHeSoLuong);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(324, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hệ thống quản lí";
            // 
            // txtSLHD
            // 
            this.txtSLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLHD.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtSLHD.Location = new System.Drawing.Point(397, 45);
            this.txtSLHD.Name = "txtSLHD";
            this.txtSLHD.ReadOnly = true;
            this.txtSLHD.Size = new System.Drawing.Size(56, 20);
            this.txtSLHD.TabIndex = 7;
            this.txtSLHD.Text = "0";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(89, 109);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.ReadOnly = true;
            this.txtHeSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtHeSoLuong.TabIndex = 5;
            this.txtHeSoLuong.Text = "XXXX";
            this.txtHeSoLuong.TextChanged += new System.EventHandler(this.txtHeSoLuong_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(89, 46);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.Text = "NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng HĐ tháng này";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hệ Số Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtErr1);
            this.groupBox4.Controls.Add(this.txtERR);
            this.groupBox4.Controls.Add(this.btnHuyBo2);
            this.groupBox4.Controls.Add(this.btnXacNhan);
            this.groupBox4.Controls.Add(this.txtXacNhanMK);
            this.groupBox4.Controls.Add(this.txtMKMoi);
            this.groupBox4.Controls.Add(this.txtMKHienTai);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(324, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 246);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đổi mật khẩu truy cập";
            // 
            // txtErr1
            // 
            this.txtErr1.AutoSize = true;
            this.txtErr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErr1.ForeColor = System.Drawing.Color.Red;
            this.txtErr1.Location = new System.Drawing.Point(361, 50);
            this.txtErr1.Name = "txtErr1";
            this.txtErr1.Size = new System.Drawing.Size(0, 13);
            this.txtErr1.TabIndex = 9;
            // 
            // txtERR
            // 
            this.txtERR.AutoSize = true;
            this.txtERR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtERR.ForeColor = System.Drawing.Color.Red;
            this.txtERR.Location = new System.Drawing.Point(361, 148);
            this.txtERR.Name = "txtERR";
            this.txtERR.Size = new System.Drawing.Size(0, 13);
            this.txtERR.TabIndex = 8;
            // 
            // btnHuyBo2
            // 
            this.btnHuyBo2.Location = new System.Drawing.Point(264, 181);
            this.btnHuyBo2.Name = "btnHuyBo2";
            this.btnHuyBo2.Size = new System.Drawing.Size(75, 36);
            this.btnHuyBo2.TabIndex = 7;
            this.btnHuyBo2.Text = "Hủy bỏ";
            this.btnHuyBo2.UseVisualStyleBackColor = true;
            this.btnHuyBo2.Click += new System.EventHandler(this.btnHuyBo2_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Image = global::BTL_CaPhe.Properties.Resources.update;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(158, 181);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 36);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(183, 145);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.ReadOnly = true;
            this.txtXacNhanMK.Size = new System.Drawing.Size(156, 20);
            this.txtXacNhanMK.TabIndex = 5;
            this.txtXacNhanMK.UseSystemPasswordChar = true;
            this.txtXacNhanMK.TextChanged += new System.EventHandler(this.txtXacNhanMK_TextChanged);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(183, 93);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.ReadOnly = true;
            this.txtMKMoi.Size = new System.Drawing.Size(156, 20);
            this.txtMKMoi.TabIndex = 4;
            this.txtMKMoi.UseSystemPasswordChar = true;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.txtMKMoi_TextChanged);
            // 
            // txtMKHienTai
            // 
            this.txtMKHienTai.Location = new System.Drawing.Point(183, 47);
            this.txtMKHienTai.Name = "txtMKHienTai";
            this.txtMKHienTai.Size = new System.Drawing.Size(156, 20);
            this.txtMKHienTai.TabIndex = 3;
            this.txtMKHienTai.UseSystemPasswordChar = true;
            this.txtMKHienTai.TextChanged += new System.EventHandler(this.txtMKHienTai_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Xác Nhận Mật Khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mật Khẩu Mới";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mật Khẩu Hiện Tại";
            // 
            // QuanLyThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyThongTin";
            this.Size = new System.Drawing.Size(862, 497);
            this.Load += new System.EventHandler(this.QuanLyThongTin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLHD;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHuyBo2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKHienTai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtERR;
        private System.Windows.Forms.Label txtErr1;
    }
}
