namespace BTL_CaPhe.User
{
    partial class User
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.pnUser = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.btnLapHD);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 45);
            this.panel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(269, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(127, 42);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Đăng xuất";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnLapHD
            // 
            this.btnLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHD.Location = new System.Drawing.Point(136, 0);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(127, 42);
            this.btnLapHD.TabIndex = 1;
            this.btnLapHD.Text = "Lập hóa đơn bán hàng";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.Location = new System.Drawing.Point(3, 0);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(127, 42);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông tin cá nhân";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // pnUser
            // 
            this.pnUser.Location = new System.Drawing.Point(3, 54);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(862, 497);
            this.pnUser.TabIndex = 1;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 553);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Panel pnUser;
    }
}