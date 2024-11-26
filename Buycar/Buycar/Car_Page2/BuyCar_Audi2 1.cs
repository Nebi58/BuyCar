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
    public partial class BuyCar_Audi2 : Form
    {
        public BuyCar_Audi2()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }
        public string Audi3;
        private void BuyCar_Audi2_Load(object sender, EventArgs e)
        {
            txtBrand.Text=Audi3;
            Audi_List audi_List=new Audi_List();
            dgwAudi2.DataSource = audi_List.selectAudi();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwAudi2.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwAudi2.Columns["Car_Brand"].HeaderText = "Brand";
            dgwAudi2.Columns["Car_Model"].HeaderText = "Model";
            dgwAudi2.Columns["Property_Year"].HeaderText = "Year";
            dgwAudi2.Columns["Property_Price"].HeaderText = "Price";
            dgwAudi2.Columns["Property_Color"].HeaderText = "Color";
            dgwAudi2.Columns["Property_FuelType"].HeaderText = "FuelType";
        }
        private void dgwAudi2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwAudi2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwAudi2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwAudi2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwAudi2.Rows[selected].Cells[2].Value.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Audi_Buy audi_Buy = new Audi_Buy();
            audi_Buy.Show();
            this.Hide();
        }
    }
}
