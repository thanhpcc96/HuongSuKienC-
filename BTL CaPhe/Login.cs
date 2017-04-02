using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace BTL_CaPhe
{
    public partial class Login : Form
    {
        DBConnect conn;
        public Login()
        {
            conn = new DBConnect();
            InitializeComponent();
        }
        private void checkForm()
        {
            btnDangnhap.Enabled = (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0);
        }
        public Form loadForm(string tenForm)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(tenForm))
                {
                    return f;
                }
            }
            return null;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable tbl = conn.checkLogin(txtUsername.Text);
            if (tbl.Rows.Count > 0)
            {
               
                if (tbl.Rows[0]["sPassword"].Equals(txtPassword.Text))
                {
                    Form f=null;
                    if (tbl.Rows[0]["sChucVu"].Equals("admin"))
                    {
                        f = loadForm("admin");
                        if (f == null)
                        {
                            f = new admin.admin();
                        }
                    }
                    else
                    {
                        f = loadForm("User");
                        if (f == null)
                        {
                            f = new User.User(tbl.Rows[0]["sMaNV"].ToString(), tbl.Rows[0]["sTenNV"].ToString());
                        }

                    }

                    this.Hide();
                    f.ShowDialog(this);
                    this.Show();



                }
                else
                {
                    MessageBox.Show("Sai password!");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Người dùng này không tồn tại!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkForm();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            checkForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }
    }
}
