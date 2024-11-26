using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class BMW_Designer1 : Form
    {
        public BMW_Designer1()
        {
            InitializeComponent();
        }
        private void btn_b_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\beyaz\\1.png");
        }

        private void btn_k_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\kırmızı\\1.png");
        }

        private void btn_m_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\mavi\\1.png");
        }

        private void btn_g_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\gri\\1.png");
        }

        private void btn_s_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\siyah\\1.png");
        }
        public string Bserialno, Bbrand, Bmodel, Byear, Bprice, Bfueltype;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BMW_Designer1_Load(object sender, EventArgs e)
        {
            lblSerialNo.Text = Bserialno;
            lblBrand.Text = Bbrand;
            lblModel.Text = Bmodel;
            lblYear.Text = Byear;
            lblPrice.Text = Bprice;
            lblFuelType.Text = Bfueltype;
        }
    }
    
}
