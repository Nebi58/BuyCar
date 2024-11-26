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
    public partial class BMW_Designer2 : Form
    {
        public BMW_Designer2()
        {
            InitializeComponent();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\beyaz\\2.png");
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\kırmızı\\2.png");
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\mavi\\2.png");
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\gri\\2.png");
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\WinFormsApp19\\WinFormsApp19\\araba\\siyah\\2.png");
        }
        public string Bserialno, Bbrand, Bmodel, Byear, Bprice, Bfueltype;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BMW_Designer2_Load(object sender, EventArgs e)
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
    
