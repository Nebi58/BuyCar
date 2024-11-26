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
    public partial class BuyCar_BMW : Form
    {
        public BuyCar_BMW()
        {
            InitializeComponent();
        }
        public string BMW2;
        private void BuyCar_BMW_Load(object sender, EventArgs e)
        {
            txtBrand.Text = BMW2;
            BMW_List bMW = new BMW_List();
            dgwBMW.DataSource= bMW.selectBMW();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwBMW.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwBMW.Columns["Car_Brand"].HeaderText = "Brand";
            dgwBMW.Columns["Car_Model"].HeaderText = "Model";
            dgwBMW.Columns["Property_Year"].HeaderText = "Year";
            dgwBMW.Columns["Property_Price"].HeaderText = "Price";
            dgwBMW.Columns["Property_Color"].HeaderText = "Color";
            dgwBMW.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar buycar = new BuyCar();
            buycar.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BMW_Show bMW_Show = new BMW_Show();
            bMW_Show.Show();
            this.Hide();
        }
    }
}
