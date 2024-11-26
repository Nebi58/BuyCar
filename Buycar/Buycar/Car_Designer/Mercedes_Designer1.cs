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
    public partial class Mercedes_Designer1 : Form
    {
        public Mercedes_Designer1()
        {
            InitializeComponent();
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes2\\bin\\Debug\\resimler\\mercedes_2_k.png");
        }

        private void btn_m_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes2\\bin\\Debug\\resimler\\mercedes_2_m.png");
        }

        private void btn_g_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes2\\bin\\Debug\\resimler\\mercedes_2_g.png");
        }

        private void btn_s_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes2\\bin\\Debug\\resimler\\mercedes_2_s.png");
        }

        private void btn_b_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes2\\bin\\Debug\\resimler\\mercedes_2_b.png");
        }
        public string Bserialno, Bbrand, Bmodel, Byear, Bprice, Bfueltype;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Mercedes_Designer1_Load(object sender, EventArgs e)
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
