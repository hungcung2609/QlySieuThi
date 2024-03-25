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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1.Quanly
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
            Load_dta1();
        }

        public string chuoi = "Select * from chitietdonhang";

        public void Load_dta1()
        {
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            db1.Columns[0].HeaderText = "Mã đơn"; db1.Columns[0].Width = 80;
            db1.Columns[1].HeaderText = "Tên và số lượng"; db1.Columns[1].Width = 200;
            db1.Columns[2].HeaderText = "Ngày bán"; db1.Columns[2].Width = 140;
            db1.Columns[3].HeaderText = "Tổng giá trị"; db1.Columns[3].Width = 100;
            db1.Columns[4].HeaderText = "Người nhập"; db1.Columns[4].Width = 190;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.Main main = new Main.Main();
            main.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitietdonhang where maphieuxuat= '" + textBox1.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            clear();
        }

        private void clear()
        {
            db1.Columns[0].HeaderText = "Mã đơn"; db1.Columns[0].Width = 80;
            db1.Columns[1].HeaderText = "Tên và số lượng"; db1.Columns[1].Width = 200;
            db1.Columns[2].HeaderText = "Ngày bán"; db1.Columns[2].Width = 140;
            db1.Columns[3].HeaderText = "Tổng giá trị"; db1.Columns[3].Width = 100;
            db1.Columns[4].HeaderText = "Người nhập"; db1.Columns[4].Width = 190;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            textBox1.Text = db1.Rows[curow].Cells[0].Value.ToString();
            textBox2.Text = db1.Rows[curow].Cells[1].Value.ToString();
            textBox3.Text = db1.Rows[curow].Cells[2].Value.ToString();
            textBox4.Text = db1.Rows[curow].Cells[3].Value.ToString();
            textBox5.Text = db1.Rows[curow].Cells[4].Value.ToString();
        }
    }
}
