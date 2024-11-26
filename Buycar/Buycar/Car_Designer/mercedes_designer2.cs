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
    public partial class mercedes_designer2 : Form
    {
        public mercedes_designer2()
        {
            InitializeComponent();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes1\\bin\\Debug\\resimler\\mercedes_1_b.png");
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes1\\bin\\Debug\\resimler\\mercedes_1_k.png");
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes1\\bin\\Debug\\resimler\\mercedes_1_m.png");
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes1\\bin\\Debug\\resimler\\mercedes_1_g.png");
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("C:\\Users\\ucarn\\OneDrive\\Masaüstü\\PROJEĞ\\mercedes1\\bin\\Debug\\resimler\\mercedes_1_s.png");
        }
        public string Bserialno, Bbrand, Bmodel, Byear, Bprice, Bfueltype;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mercedes_designer2_Load(object sender, EventArgs e)
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
