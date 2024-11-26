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
    public partial class BuyCar_Mercedes2 : Form
    {
        public BuyCar_Mercedes2()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }
        public string Mercedes3;
        private void BuyCar_Mercedes2_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Mercedes3;
            Mercedes_List mercedes_List = new Mercedes_List();
            dgwMercedes2.DataSource = mercedes_List.selectMercedes();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwMercedes2.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwMercedes2.Columns["Car_Brand"].HeaderText = "Brand";
            dgwMercedes2.Columns["Car_Model"].HeaderText = "Model";
            dgwMercedes2.Columns["Property_Year"].HeaderText = "Year";
            dgwMercedes2.Columns["Property_Price"].HeaderText = "Price";
            dgwMercedes2.Columns["Property_Color"].HeaderText = "Color";
            dgwMercedes2.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void dgwMercedes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwMercedes2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwMercedes2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwMercedes2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwMercedes2.Rows[selected].Cells[2].Value.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Mercedes_Buy mercedes_Buy = new Mercedes_Buy();
            mercedes_Buy.Show();
            this.Hide();
        }
    }
}
