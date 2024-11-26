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
    public partial class BuyCar_Audi : Form
    {
        public BuyCar_Audi()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            BuyCar buyCar = new BuyCar();
            buyCar.Show();
            this.Hide();
        }
        public string Audi2;
        private void BuyCar_Audi_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Audi2;
            Audi_List audi_List = new Audi_List();
            dgwAudi.DataSource = audi_List.selectAudi();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwAudi.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwAudi.Columns["Car_Brand"].HeaderText = "Brand";
            dgwAudi.Columns["Car_Model"].HeaderText = "Model";
            dgwAudi.Columns["Property_Year"].HeaderText = "Year";
            dgwAudi.Columns["Property_Price"].HeaderText = "Price";
            dgwAudi.Columns["Property_Color"].HeaderText = "Color";
            dgwAudi.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void dgwAudi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwAudi.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwAudi.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwAudi.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwAudi.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            BuyCar buycar = new BuyCar();
            buycar.Show();
            this.Hide();
        }
    }
}
