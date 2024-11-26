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
    public partial class Search_Car : Form
    {
        public Search_Car()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar buyCar = new BuyCar();
            buyCar.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Car_Load(object sender, EventArgs e)
        {
            Car_List car_List = new Car_List();
            dgwCarList.DataSource = car_List.selectCar();
            dgwCarList.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Car_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Car_Model"].HeaderText = "Model";
            dgwCarList.Columns["Property_Year"].HeaderText = "Year";
            dgwCarList.Columns["Property_Price"].HeaderText = "Price";
            dgwCarList.Columns["Property_Color"].HeaderText = "Color";
            dgwCarList.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? year = string.IsNullOrEmpty(txtYear.Text) ? (int?)null : (int?)Convert.ToInt32(txtYear.Text);
            string color = string.IsNullOrEmpty(cmbColor.Text) ? null : cmbColor.Text;
            decimal? price = string.IsNullOrEmpty(txtPrice.Text) ? (decimal?)null : (decimal?)Convert.ToDecimal(txtPrice.Text);
            string fueltype = string.IsNullOrEmpty(cmbFueltype.Text) ? null : cmbFueltype.Text;

            Car_List car_List2 = new Car_List();
            dgwCarList.DataSource = car_List2.selectProperty(year, price, color, fueltype);
            dgwCarList.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Car_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Car_Model"].HeaderText = "Model";
            dgwCarList.Columns["Property_Year"].HeaderText = "Year";
            dgwCarList.Columns["Property_Price"].HeaderText = "Price";
            dgwCarList.Columns["Property_Color"].HeaderText = "Color";
            dgwCarList.Columns["Property_FuelType"].HeaderText = "FuelType";
        }
    }
}
