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
    public partial class Audi_Designer2 : Form
    {
        public Audi_Designer2()
        {
            InitializeComponent();
        }
        public string Aserialno, Abrand, Amodel, Ayear, Aprice, Afueltype;

        private void Audi_Designer2_Load(object sender, EventArgs e)
        {
            lblSerialNo.Text = Aserialno;
            lblBrand.Text = Abrand;
            lblModel.Text = Amodel;
            lblYear.Text = Ayear;
            lblPrice.Text = Aprice;
            lblFuelType.Text = Afueltype;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_g_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi2\\bin\\Debug\\resimler\\audi_11_g.png");
        }

        private void btn_s_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi2\\bin\\Debug\\resimler\\audi_11_s.png");
        }

        private void btn_m_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi2\\bin\\Debug\\resimler\\audi_11_m.png");
        }

        private void btn_k_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi2\\bin\\Debug\\resimler\\audi_11_k.png");
        }

        private void btn_b_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi2\\bin\\Debug\\resimler\\audi_11_b.png");
        }
    }
}
