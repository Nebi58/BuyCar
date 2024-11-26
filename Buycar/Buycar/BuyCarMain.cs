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
    public partial class BuyCarMain : Form
    {
        public BuyCarMain()
        {
            InitializeComponent();
        }
        public string nick;
        private void BuyCarMain_Load(object sender, EventArgs e)
        {
            lblNick.Text = nick;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=MessageBox.Show("Çıkmak istediğine emin misin?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sonuc==DialogResult.Yes)
            {
                this.Hide();
                BuyCar_SignLog buyCar_SignLog = new BuyCar_SignLog();
                buyCar_SignLog.Show();
            }
            else
            {
                
            }
        }
        private void btnBMW_Click(object sender, EventArgs e)
        {
            string BMW = "BMW";
            BuyCar_BMW2 bMW = new BuyCar_BMW2();
            bMW.BMW3 = BMW;
            bMW.Show();
            this.Hide();
        }

        private void btnMercedes_Click(object sender, EventArgs e)
        {
            string Mercedes = "Mercedes";
            BuyCar_Mercedes2 buyCar_Mercedes2 = new BuyCar_Mercedes2();
            buyCar_Mercedes2.Mercedes3 = Mercedes;
            buyCar_Mercedes2.Show();
            this.Hide();
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            string Audi = "Audi";
            BuyCar_Audi2 audi2 = new BuyCar_Audi2();
            audi2.Audi3 = Audi;
            audi2.Show();
            this.Hide();
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            string Ford3 = "Ford";
            BuyCar_Ford2 buyCar_Ford = new BuyCar_Ford2();
            buyCar_Ford.Ford4 = Ford3;
            buyCar_Ford.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBreakCar_Click(object sender, EventArgs e)
        {
            BrokenCar brokenCar = new BrokenCar();
            brokenCar.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Car2 searchCar = new Search_Car2();
            searchCar.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Quit quit = new Quit();
            quit.Show();
            this.Hide();
        }
    }
}
