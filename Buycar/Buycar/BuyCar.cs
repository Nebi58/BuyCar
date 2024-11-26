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
    public partial class BuyCar : Form
    {
        public BuyCar()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
                BuyCar_SignLog signLog = new BuyCar_SignLog();
                signLog.Show();
                this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBMW_Click(object sender, EventArgs e)
        {
                string BMW1 = "BMW";
                BuyCar_BMW buyCar_BMW = new BuyCar_BMW();
                buyCar_BMW.BMW2 = BMW1;
                buyCar_BMW.Show();
                this.Hide();
        }

        private void btnMercedes_Click(object sender, EventArgs e)
        {
            string Mercedes1 = "Mercedes";
            BuyCar_Mercedes mercedes = new BuyCar_Mercedes();
            mercedes.Mercedes2 = Mercedes1;
            mercedes.Show();
            this.Hide();
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            string Audi1 = "Audi";
            BuyCar_Audi buyCar_Audi = new BuyCar_Audi();
            buyCar_Audi.Audi2 = Audi1;
            buyCar_Audi.Show();
            this.Hide();
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            string ford1 = "Ford";
            BuyCar_Ford ford = new BuyCar_Ford();
            ford.Ford2 = ford1;
            ford.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Car search_Car = new Search_Car();
            search_Car.Show();
            this.Hide();
        }
    }
}


