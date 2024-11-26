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
    public partial class BuyCar_BMW2 : Form
    {
        public BuyCar_BMW2()
        {
            InitializeComponent();
        }
        public string BMW3;
        private void BuyCar_BMW2_Load(object sender, EventArgs e)
        {
            txtBrand.Text = BMW3;
            BMW_List bMW = new BMW_List();
            dgwBMW2.DataSource = bMW.selectBMW();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwBMW2.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwBMW2.Columns["Car_Brand"].HeaderText = "Brand";
            dgwBMW2.Columns["Car_Model"].HeaderText = "Model";
            dgwBMW2.Columns["Property_Year"].HeaderText = "Year";
            dgwBMW2.Columns["Property_Price"].HeaderText = "Price";
            dgwBMW2.Columns["Property_Color"].HeaderText = "Color";
            dgwBMW2.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void dgwBMW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwBMW2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwBMW2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwBMW2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwBMW2.Rows[selected].Cells[2].Value.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BMW_Buy bMW_Buy = new BMW_Buy();
            bMW_Buy.Show();
            this.Hide();
        }
    }
}
