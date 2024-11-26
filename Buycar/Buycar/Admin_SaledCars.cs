using BuyCar_Business;
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
    public partial class Admin_SaledCars : Form
    {
        public Admin_SaledCars()
        {
            InitializeComponent();
        }

        private void Admin_SaledCars_Load(object sender, EventArgs e)
        {
            Car_List car_List = new Car_List();
            dgwCarList.DataSource = car_List.selectSalesCar();
            dgwCarList.Columns["Sales_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Sales_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Sales_Model"].HeaderText = "Model";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar_Admin buyCar_Admin = new BuyCar_Admin();
            buyCar_Admin.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaledZed_Click(object sender, EventArgs e)
        {
            ZedGraph_SaledCars zedGraph_SaledCars= new ZedGraph_SaledCars();
            zedGraph_SaledCars.Show();
            this.Hide();
        }
    }
}
