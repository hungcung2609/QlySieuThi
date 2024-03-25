using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SieuThiMini
{
    public partial class Quanlyncp : Form
    {
        public string chuoi = "Select * from nhacungcap";
        public Quanlyncp()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();

        }
        public void clear()
        {
            dta1.Columns[0].HeaderText = "Mã nhà cung cấp"; dta1.Columns[0].Width = 150;
            dta1.Columns[1].HeaderText = "Tên nhà cung cấp"; dta1.Columns[1].Width = 160;
            dta1.Columns[2].HeaderText = "Địa chỉ";
            dta1.Columns[3].HeaderText = "Số điện thoại";
            dta1.Columns[4].HeaderText = "Công nợ";
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_diachi.Text = "";
            txt_congno.Text = "";
            txt_sdt.Text = "";
        }
        
    

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "" || txt_diachi.Text == "" || txt_sdt.Text == "" || txt_congno.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into nhacungcap values(N'" + txt_manv.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "','" + txt_congno.Text + "' )";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update nhacungcap set tenncc = N'" + txt_tennv.Text + "',diachi = N'" + txt_diachi.Text + "',sdt = '" + txt_sdt.Text + "',congno = '" + txt_congno.Text + "' Where mancc = '" + txt_manv.Text + "' ";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            string sql = "Delete from nhacungcap where mancc= '" + txt_manv.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
            WindowsFormsApp1.Main.Main main = new WindowsFormsApp1.Main.Main();
            main.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from nhacungcap where tenncc like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }
        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_manv.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tennv.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_diachi.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_sdt.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_congno.Text = dta1.Rows[curow].Cells[4].Value.ToString();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_congno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
    }

