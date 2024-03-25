using SieuThiMini;
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

namespace WindowsFormsApp1.GiaoDienBanHang
{
    public partial class GDBanHang : Form
    {
        public int a = 0;
        public int y = 0;

        public string chuoi = "Select masp,tensp,donvitinh,solg,giaban from sanpham";

        public GDBanHang()
        {
            InitializeComponent();
            Load_dta1();
        }

        public void Load_dta1()
        {
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham where tensp like N'%" + textBox9.Text + "%' ";
            chuoiketnoi.timkiem(load1, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public Label GetLabel()
        {
            return label11;
        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            textBox1.Text = db1.Rows[curow].Cells[0].Value.ToString();
            textBox2.Text = db1.Rows[curow].Cells[1].Value.ToString();
            textBox3.Text = db1.Rows[curow].Cells[2].Value.ToString();
            textBox4.Text = db1.Rows[curow].Cells[4].Value.ToString();
            textBox5.Text = db1.Rows[curow].Cells[3].Value.ToString();
        }

        private void dta2_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int curow = dta2.CurrentRow.Index;

                textBox1.Text = dta2.Rows[curow].Cells[0].Value.ToString();
                textBox2.Text = dta2.Rows[curow].Cells[1].Value.ToString();
                textBox3.Text = dta2.Rows[curow].Cells[2].Value.ToString();
                textBox4.Text = dta2.Rows[curow].Cells[3].Value.ToString();
                textBox5.Text = dta2.Rows[curow].Cells[4].Value.ToString();
                y = int.Parse(textBox5.Text);

                string solg = "Select solg from sanpham where masp ='" + textBox1.Text + "'";
                SqlDataReader rd3 = chuoiketnoi.showtext(solg);
                while (rd3.Read())
                {
                    a = int.Parse(rd3[0].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Trong ! ", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(textBox4.Text);
                int b = int.Parse(textBox6.Text);
                int d = int.Parse(textBox5.Text);
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng bán ! ", "Thông báo", MessageBoxButtons.OK);
                }

                else if (b > d)
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho không đủ để bán\nBạn hãy nhập thêm hàng", "Thông báo ", MessageBoxButtons.OK);

                }

                else
                {
                    int x = d - b;

                    int s = a * b;
                    int n = dta2.Rows.Add();
                    double thanhtien = 0;
                    dta2.Rows[n].Cells[0].Value = textBox1.Text;
                    dta2.Rows[n].Cells[1].Value = textBox2.Text;
                    dta2.Rows[n].Cells[2].Value = textBox3.Text;
                    dta2.Rows[n].Cells[3].Value = textBox4.Text;
                    dta2.Rows[n].Cells[4].Value = textBox6.Text;
                    dta2.Rows[n].Cells[5].Value = s.ToString();

                    string sql1 = "Update sanpham set solg ='" + x.ToString() + "'   WHERE masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    chuoiketnoi.luu(sql1);
                    string load1 = "Select masp,tensp,donvitinh,solg,giaban from  sanpham where  masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    chuoiketnoi.Chuoiketnoi(load1, db1);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox5.Text = "";

                    textBox6.Text = "1";

                    int sc = dta2.Rows.Count;

                    Load_dta1();



                    for (int i = 0; i < sc - 1; i++)
                    {

                        thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                    }
                    textBox7.Text = thanhtien.ToString() + " VNĐ";
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                int h = a + y;
                string sql1 = "Update sanpham set Solg ='" + h.ToString() + "' WHERE masp ='" + textBox1.Text + "'";
                chuoiketnoi.Execute(sql1);
                string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham  where  masp ='" + textBox1.Text + "' ";
                chuoiketnoi.Chuoiketnoi(load1, db1);
                int seleRow = dta2.CurrentCell.RowIndex;
                dta2.Rows.RemoveAt(seleRow);
                double thanhtien = 0;
                int sc = dta2.Rows.Count;
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";

                textBox6.Text = "1";

                for (int i = 0; i < sc - 1; i++)
                {
                    thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());
                }
                textBox7.Text = thanhtien.ToString();
            }
            catch
            {
                MessageBox.Show("Ban chua chọn thuoc sản phẩm để xóa ! ", "Thong bao", MessageBoxButtons.OK);
            }
            Load_dta1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox6.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
                this.Close();
        }


    }
}
