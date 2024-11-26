using BuyCar_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class Quit : Form
    {
        public Quit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            string password = mskPassword.Text;
            Quit_Member quit_Member = new Quit_Member();
            quit_Member.Quit(tc,password);
            MessageBox.Show("Deleted");
            BuyCar buyCar=new BuyCar();
            buyCar.Show();
            this.Hide();
        }
    }
}
