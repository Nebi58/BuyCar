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
    public partial class BuyCar_Ford2 : Form
    {
        public BuyCar_Ford2()
        {
            InitializeComponent();
        }
        public string Ford4;
        private void BuyCar_Ford2_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Ford4;
            Ford_List ford_List = new Ford_List();
            dgwFord2.DataSource = ford_List.selectFord();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwFord2.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwFord2.Columns["Car_Brand"].HeaderText = "Brand";
            dgwFord2.Columns["Car_Model"].HeaderText = "Model";
            dgwFord2.Columns["Property_Year"].HeaderText = "Year";
            dgwFord2.Columns["Property_Price"].HeaderText = "Price";
            dgwFord2.Columns["Property_Color"].HeaderText = "Color";
            dgwFord2.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void dgwFord2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwFord2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwFord2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwFord2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwFord2.Rows[selected].Cells[2].Value.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Ford_Buy ford_Buy = new Ford_Buy();
            ford_Buy.Show();
            this.Hide();
        }
    }
}
