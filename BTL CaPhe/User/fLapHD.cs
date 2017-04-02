using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CaPhe.User
{
    public partial class fLapHD : Form
    {
        public string sMaHD { get; set; }
        DBConnect connect;
        public fLapHD()
        {
            InitializeComponent();
            connect = new DBConnect();
        }
        public fLapHD(string mahd)
        {
            InitializeComponent();
            this.sMaHD = mahd;
        }

        private void fLapHD_Load(object sender, EventArgs e)
        {
            DataTable tblReportData = connect.reportHoaDon(sMaHD);
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"C:\Users\Admin\OneDrive\C# Procject\BTL CaPhe\BTL CaPhe\reports\user_hoadon.rpt");
            rdoc.SetDataSource(tblReportData);
            crptViewer.ReportSource = rdoc;
        }
    }
}
