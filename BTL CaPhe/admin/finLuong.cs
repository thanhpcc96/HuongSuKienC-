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

namespace BTL_CaPhe.admin
{
    public partial class finLuong : Form
    {
        public float phantramhoahong { get; set; }
        public int sohoadon { get; set; }
        public int luongcoban { get; set; }
        DBConnect connect;
        public finLuong()
        {
            InitializeComponent();
            connect = new DBConnect();
        }

        private void finLuong_Load(object sender, EventArgs e)
        {
            DataTable tblDataReport = connect.inLuong(phantramhoahong, sohoadon, luongcoban);
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"C:\Users\Admin\OneDrive\C# Procject\BTL CaPhe\BTL CaPhe\reports\in_dsLuong.rpt");
            rdoc.SetDataSource(tblDataReport);
            crpViewer.ReportSource = rdoc;
        }

    }
}

