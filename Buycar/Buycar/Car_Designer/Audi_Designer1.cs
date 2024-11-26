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
    public partial class Audi_designer1 : Form
    {
        public Audi_designer1()
        {
            InitializeComponent();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi1\\bin\\Debug\\resimler\\audi_1_b.png");
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi1\\bin\\Debug\\resimler\\audi_1_k.png");
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi1\\bin\\Debug\\resimler\\audi_1_m.png");
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi1\\bin\\Debug\\resimler\\audi_1_g.png");
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\audi1\\bin\\Debug\\resimler\\audi_1_s.png");
        }
        public string Aserialno, Abrand, Amodel, Ayear, Aprice, Afueltype;

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void Audi_designer1_Load(object sender, EventArgs e)
        {
            lblSerialNo.Text = Aserialno;
            lblBrand.Text = Abrand;
            lblModel.Text = Amodel;
            lblYear.Text = Ayear;
            lblPrice.Text = Aprice;
            lblFuelType.Text = Afueltype;
        }
    }
}
