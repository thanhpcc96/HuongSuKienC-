namespace BTL_CaPhe.admin
{
    partial class QLLuong
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
            this.btnIN = new System.Windows.Forms.Button();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoaHong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoluonghoadon = new System.Windows.Forms.MaskedTextBox();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIN);
            this.groupBox1.Controls.Add(this.txtTongLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtHeSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Lương";
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(21, 429);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(180, 23);
            this.btnIN.TabIndex = 6;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Location = new System.Drawing.Point(101, 349);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.ReadOnly = true;
            this.txtTongLuong.Size = new System.Drawing.Size(100, 20);
            this.txtTongLuong.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(9, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng Lương:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(21, 400);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoaHong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoluonghoadon);
            this.groupBox2.Controls.Add(this.txtPhanTram);
            this.groupBox2.Location = new System.Drawing.Point(21, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoa Hồng từ hóa đơn:";
            // 
            // txtHoaHong
            // 
            this.txtHoaHong.AutoSize = true;
            this.txtHoaHong.Location = new System.Drawing.Point(77, 72);
            this.txtHoaHong.Name = "txtHoaHong";
            this.txtHoaHong.Size = new System.Drawing.Size(0, 13);
            this.txtHoaHong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // txtSoluonghoadon
            // 
            this.txtSoluonghoadon.Location = new System.Drawing.Point(22, 35);
            this.txtSoluonghoadon.Name = "txtSoluonghoadon";
            this.txtSoluonghoadon.ReadOnly = true;
            this.txtSoluonghoadon.Size = new System.Drawing.Size(70, 20);
            this.txtSoluonghoadon.TabIndex = 1;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(118, 35);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(39, 20);
            this.txtPhanTram.TabIndex = 0;
            this.txtPhanTram.TextChanged += new System.EventHandler(this.txtPhanTram_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSize = true;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Blue;
            this.txtTenNV.Location = new System.Drawing.Point(67, 116);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(46, 15);
            this.txtTenNV.TabIndex = 6;
            this.txtTenNV.Text = "txtTen";
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Blue;
            this.txtMaNV.Location = new System.Drawing.Point(67, 54);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(42, 15);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.Text = "txtMA";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(55, 171);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(123, 20);
            this.txtHeSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HSL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // dgvLuong
            // 
            this.dgvLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(236, 57);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.Size = new System.Drawing.Size(631, 419);
            this.dgvLuong.TabIndex = 1;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quản Lý Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lương Cơ Bản";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(690, 34);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(102, 20);
            this.txtLuongCB.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(798, 31);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // QLLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLLuong";
            this.Size = new System.Drawing.Size(867, 479);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtHoaHong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtSoluonghoadon;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Label txtTenNV;
        private System.Windows.Forms.Label txtMaNV;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnIN;
    }
}
