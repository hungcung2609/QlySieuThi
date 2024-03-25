using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Main;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        public static string sqlcon = @"Data Source=LAPTOP-2VNLJD6R\MSSQLSERVER02;Initial Catalog=QLST;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection mycon;
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlCommandBuilder bd;

        public static string getNameUser(string fullname)
        {
            return fullname;
        }

        public static string username;

        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        public DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sql1 = "Select count(*) from taikhoan where username='" + Tkhoan.Text.Trim() + "' and password='" + Mkhau.Text.Trim() + "' ";
            if (Tkhoan.Text == "" || Mkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin! ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                int a = 0;
                mycon = new SqlConnection(sqlcon);
                mycon.Open();

                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();

                if (a == 0)
                {
                    string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "Select isAdmin from taikhoan where username='" + Tkhoan.Text.Trim() + "'";
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    SqlCommand getIsAdmin = new SqlCommand(sql, mycon);
                    int getRole = (int)getIsAdmin.ExecuteScalar();

                    if (getRole == 0)
                    {

                        MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                        Main.Main main = new Main.Main();
                        GiaoDienBanHang.GDBanHang banHang = new GiaoDienBanHang.GDBanHang();

                        main.GetLabel().Text = GetFullname(0, Tkhoan.Text.Trim()) + " (Quản trị)";
                        banHang.GetLabel().Text = GetFullname(0, Tkhoan.Text.Trim()) + " (Quản trị)";

                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ban dang nhap vao tai khoan Nhân Vien", "Thong bao ", MessageBoxButtons.OK);

                        GiaoDienBanHang.GDBanHang banHang = new GiaoDienBanHang.GDBanHang();
                        banHang.GetLabel().Text = GetFullname(1, Tkhoan.Text.Trim()) + " (Nhân viên)";
                        banHang.Show();
                        this.Hide();

                    }
                }
            }


        }
        public static string GetFullname(int isAdmin, string username)
        {
            string sqlGetFullname = "Select fullname from taikhoan where isAdmin=" + isAdmin + " and username='" + username + "'";
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            SqlCommand getFullname = new SqlCommand(sqlGetFullname, mycon);
            string Fullname = getFullname.ExecuteScalar().ToString();

            return Fullname;
        }

        private void Hien_CheckedChanged(object sender, EventArgs e)
        {
            if (Hien.Checked)
            {
                Mkhau.UseSystemPasswordChar = false;
            }
            else
            {
                Mkhau.UseSystemPasswordChar = true;
            }
        }

        private void Tkhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.DangKy dangKy = new Login.DangKy();
            dangKy.Show();
            this.Hide();
        }
    }
}
