using SieuThiMini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Login
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString().Trim();
            string password = textBox2.Text.ToString().Trim();
            string remk = textBox3.Text.ToString().Trim();
            string fullname = textBox4.Text.ToString().Trim();
            string isAdmin = cbbRole.SelectedIndex.ToString();

            if (username == "" || password == "" || remk == "" || fullname == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string sql = "Select count(*) from taikhoan where username ='" + username + "'";



                string sql1 = "Insert into taikhoan (username,password,fullname,isAdmin) values('" + username + "','" + password + "','" + fullname + "','" + isAdmin + "')";
                if (password == remk)
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {

                        chuoiketnoi.Themdangky(sql, username, password, sql1);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
