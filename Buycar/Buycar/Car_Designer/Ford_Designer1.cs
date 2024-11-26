using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Buycar
{
    public partial class Ford_Designer1 : Form
    {
        public Ford_Designer1()
        {
            InitializeComponent();
        }
        public string Bserialno, Bbrand, Bmodel, Byear, Bprice, Bfueltype;

        private void btn_g_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\gri\\1.png");
        }

        private void btn_s_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\siyah\\1.png");
        }

        private void btn_m_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\mavi\\1.png");
        }

        private void btn_k_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\kırmızı\\1.png");
        }

        private void btn_b_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\beyaz\\1.png");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Ford_Designer1_Load(object sender, EventArgs e)
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
