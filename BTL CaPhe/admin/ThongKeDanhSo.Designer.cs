namespace BTL_CaPhe.admin
{
    partial class ThongKeDanhSo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvToanTime = new System.Windows.Forms.DataGridView();
            this.txtTodayTien = new System.Windows.Forms.Label();
            this.txtLuotMua = new System.Windows.Forms.Label();
            this.txtToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.charThongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToanTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTodayTien);
            this.groupBox1.Controls.Add(this.txtLuotMua);
            this.groupBox1.Controls.Add(this.txtToday);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Danh Số";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvBanChay);
            this.groupBox3.Location = new System.Drawing.Point(567, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản Phẩm Bán Chạy";
            // 
            // dgvBanChay
            // 
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSP,
            this.sTenSP,
            this.soluong});
            this.dgvBanChay.Location = new System.Drawing.Point(13, 15);
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.Size = new System.Drawing.Size(313, 156);
            this.dgvBanChay.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvToanTime);
            this.groupBox2.Location = new System.Drawing.Point(314, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toàn thời gian";
            // 
            // dgvToanTime
            // 
            this.dgvToanTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToanTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaylap,
            this.tien});
            this.dgvToanTime.Location = new System.Drawing.Point(2, 15);
            this.dgvToanTime.Name = "dgvToanTime";
            this.dgvToanTime.Size = new System.Drawing.Size(234, 160);
            this.dgvToanTime.TabIndex = 0;
            // 
            // txtTodayTien
            // 
            this.txtTodayTien.AutoSize = true;
            this.txtTodayTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTodayTien.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtTodayTien.Location = new System.Drawing.Point(131, 123);
            this.txtTodayTien.Name = "txtTodayTien";
            this.txtTodayTien.Size = new System.Drawing.Size(55, 15);
            this.txtTodayTien.TabIndex = 7;
            this.txtTodayTien.Text = "500000";
            // 
            // txtLuotMua
            // 
            this.txtLuotMua.AutoSize = true;
            this.txtLuotMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuotMua.ForeColor = System.Drawing.Color.Chocolate;
            this.txtLuotMua.Location = new System.Drawing.Point(131, 80);
            this.txtLuotMua.Name = "txtLuotMua";
            this.txtLuotMua.Size = new System.Drawing.Size(51, 15);
            this.txtLuotMua.TabIndex = 6;
            this.txtLuotMua.Text = "30 lượt";
            // 
            // txtToday
            // 
            this.txtToday.AutoSize = true;
            this.txtToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToday.ForeColor = System.Drawing.Color.Chocolate;
            this.txtToday.Location = new System.Drawing.Point(131, 34);
            this.txtToday.Name = "txtToday";
            this.txtToday.Size = new System.Drawing.Size(79, 15);
            this.txtToday.TabIndex = 4;
            this.txtToday.Text = "20/10/2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doanh thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượt mua hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm Nay:";
            // 
            // charThongke
            // 
            chartArea3.Name = "ChartArea1";
            this.charThongke.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.charThongke.Legends.Add(legend3);
            this.charThongke.Location = new System.Drawing.Point(3, 203);
            this.charThongke.Name = "charThongke";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.charThongke.Series.Add(series3);
            this.charThongke.Size = new System.Drawing.Size(905, 274);
            this.charThongke.TabIndex = 1;
            this.charThongke.Text = "chart1";
            // 
            // sMaSP
            // 
            this.sMaSP.DataPropertyName = "sMaSP";
            this.sMaSP.HeaderText = "Mã sản phẩm";
            this.sMaSP.Name = "sMaSP";
            // 
            // sTenSP
            // 
            this.sTenSP.DataPropertyName = "sTenSP";
            this.sTenSP.HeaderText = "Tên sản phẩm";
            this.sTenSP.Name = "sTenSP";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            // 
            // tien
            // 
            this.tien.DataPropertyName = "tien";
            this.tien.HeaderText = "Tiền";
            this.tien.Name = "tien";
            // 
            // ThongKeDanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.charThongke);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeDanhSo";
            this.Size = new System.Drawing.Size(911, 479);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToanTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtTodayTien;
        private System.Windows.Forms.Label txtLuotMua;
        private System.Windows.Forms.Label txtToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charThongke;
        private System.Windows.Forms.DataGridView dgvToanTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBanChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
    }
}
