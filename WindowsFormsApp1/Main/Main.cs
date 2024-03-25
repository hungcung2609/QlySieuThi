using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SieuThiMini.Quanlytk quanlytk = new SieuThiMini.Quanlytk();
            quanlytk.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanly.DonHang donHang = new Quanly.DonHang();
            donHang.Show();
            this.Close();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanly.SanPham sanPham = new Quanly.SanPham();
            sanPham.Show();
            this.Close();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SieuThiMini.Quanlyncp quanlyncp =  new SieuThiMini.Quanlyncp();
            quanlyncp.Show();
            this.Close();
        }

        private void giaoDiệnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDienBanHang.GDBanHang banHang = new GiaoDienBanHang.GDBanHang();
            banHang.Show();
        }

        public Label GetLabel()
        {
            return label2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
