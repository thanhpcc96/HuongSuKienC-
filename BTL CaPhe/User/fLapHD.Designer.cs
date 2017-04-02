namespace BTL_CaPhe.User
{
    partial class fLapHD
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
            this.crptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptViewer
            // 
            this.crptViewer.ActiveViewIndex = -1;
            this.crptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptViewer.Location = new System.Drawing.Point(0, 0);
            this.crptViewer.Name = "crptViewer";
            this.crptViewer.ShowCloseButton = false;
            this.crptViewer.ShowGroupTreeButton = false;
            this.crptViewer.ShowLogo = false;
            this.crptViewer.ShowParameterPanelButton = false;
            this.crptViewer.Size = new System.Drawing.Size(760, 392);
            this.crptViewer.TabIndex = 0;
            this.crptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fLapHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 392);
            this.Controls.Add(this.crptViewer);
            this.Name = "fLapHD";
            this.Text = "Xem Hóa đơn  trước khi in!";
            this.Load += new System.EventHandler(this.fLapHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewer;
    }
}