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

namespace WindowsFormsApp1.Quanly
{
    public partial class SanPham : Form
    {
        public string chuoi = "select sanpham.masp , sanpham.tensp , nhacungcap.tenncc , sanpham.gianhap , sanpham.giaban , sanpham.solg , sanpham.hsd , sanpham.noisx , sanpham.donvitinh , sanpham.nguoinhap " +
            "from sanpham INNER JOIN nhacungcap ON sanpham.mancc = nhacungcap.mancc";

        public SanPham()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }
        public void clear()
        {

            dta1.Columns[0].HeaderText = "Mã Sản phẩm"; dta1.Columns[0].Width = 110;
            dta1.Columns[1].HeaderText = "Tên sản phẩm"; dta1.Columns[1].Width = 150;
            dta1.Columns[2].HeaderText = "Nhà cung cấp"; dta1.Columns[2].Width = 110;
            dta1.Columns[3].HeaderText = "Giá  nhập"; dta1.Columns[3].Width = 110;
            dta1.Columns[4].HeaderText = "Giá bán"; dta1.Columns[4].Width = 110;
            dta1.Columns[5].HeaderText = "Số lượng"; dta1.Columns[5].Width = 110;
            dta1.Columns[6].HeaderText = "Hạn sử dụng"; dta1.Columns[6].Width = 110;
            dta1.Columns[7].HeaderText = "Nơi sản xuất"; dta1.Columns[7].Width = 110;
            dta1.Columns[8].HeaderText = "Đơn vị tính"; dta1.Columns[8].Width = 110;
            dta1.Columns[9].HeaderText = "Người nhập"; dta1.Columns[9].Width = 110;
            mancc();
            textBox1.Focus();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            txt_hsd.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            int sc = dta1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien++;
            }
            lbl_kq.Text = thanhtien.ToString() + " SP";
        }

        private void mancc()
        {

            string load_mancc = "Select mancc, tenncc from nhacungcap";
            chuoiketnoi.xulycbx(load_mancc, textBox3);
            textBox3.DisplayMember = "tenncc";
            textBox3.ValueMember = "mancc";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main.Main main = new Main.Main();
            main.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_kq_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from sanpham where tensp like N'%" + textBox10.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }

        private void dta1_Click(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            textBox1.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            textBox2.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            textBox3.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            textBox4.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            textBox5.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            textBox6.Text = dta1.Rows[curow].Cells[5].Value.ToString();
            txt_hsd.Text = dta1.Rows[curow].Cells[6].Value.ToString();
            textBox7.Text = dta1.Rows[curow].Cells[7].Value.ToString();
            textBox8.Text = dta1.Rows[curow].Cells[8].Value.ToString();
            textBox9.Text = dta1.Rows[curow].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
            textBox2.Text == "" ||
            textBox3.Text == "" ||
            textBox4.Text == "" ||
            textBox5.Text == "" ||
            textBox6.Text == "" ||
            txt_hsd.Text == "" ||
            textBox7.Text == "" ||
            textBox8.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into sanpham values(N'" + textBox2.Text + "',N'" + textBox3.SelectedValue + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + txt_hsd.Value + "',N'" + textBox7.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "')";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "Update sanpham set tensp = N'" + textBox2.Text + "',mancc = N'" + textBox3.SelectedValue + "',gianhap = '" + textBox4.Text + "',giaban = '" + textBox5.Text + "',solg = '" + textBox6.Text + "',hsd = '" + txt_hsd.Value + "',noisx = N'" + textBox7.Text + "',donvitinh = N'" + textBox8.Text + "',nguoinhap= N'" + textBox9.Text + "' where masp='" + textBox1.Text + "'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "Delete from sanpham where masp= '" + textBox1.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void lb_quyen_Click(object sender, EventArgs e)
        {

        }
    }
}
