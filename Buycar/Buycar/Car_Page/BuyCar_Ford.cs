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
    public partial class BuyCar_Ford : Form
    {
        public BuyCar_Ford()
        {
            InitializeComponent();
        }
        public string Ford2;
        public string serialno, brand, model, year, price, color, fueltype;
        private void BuyCar_Ford_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Ford2;
            Ford_List ford_List=new Ford_List();
            dgwFord.DataSource= ford_List.selectFord();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwFord.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwFord.Columns["Car_Brand"].HeaderText = "Brand";
            dgwFord.Columns["Car_Model"].HeaderText = "Model";
            dgwFord.Columns["Property_Year"].HeaderText = "Year";
            dgwFord.Columns["Property_Price"].HeaderText = "Price";
            dgwFord.Columns["Property_Color"].HeaderText = "Color";
            dgwFord.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar buyCar = new BuyCar();
            buyCar.Show();
            this.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            model = txtModel.Text;
            if (txtModel.Text == "")
            {
                MessageBox.Show("Tablodan araba seçmeyi unuttunuz...");
            }
            else
            {
                if (model == "Mustang")
                {
                    Ford_Designer1 ford_Designer1 = new Ford_Designer1();
                    ford_Designer1.Bserialno = serialno;
                    ford_Designer1.Bbrand = brand;
                    ford_Designer1.Bmodel = model;
                    ford_Designer1.Byear = year;
                    ford_Designer1.Bprice = price;
                    ford_Designer1.Bfueltype = fueltype;

                    ford_Designer1.Show();
                }
                else if (model == "Fiesta")
                {
                    Ford_Designer2 ford_Designer2 = new Ford_Designer2();
                    ford_Designer2.Bserialno = serialno;
                    ford_Designer2.Bbrand = brand;
                    ford_Designer2.Bmodel = model;
                    ford_Designer2.Byear = year;
                    ford_Designer2.Bprice = price;
                    ford_Designer2.Bfueltype = fueltype;

                    ford_Designer2.Show();
                }
                else
                {
                    MessageBox.Show("Araba seçiminde yanlışlık var.");
                }
            }
        }

        private void dgwFord_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwFord.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwFord.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwFord.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwFord.Rows[selected].Cells[2].Value.ToString();

            //Diğer sayfada kullanacağımız değişkenlere ekleme yapar
            serialno = dgwFord.Rows[selected].Cells[0].Value.ToString();
            brand = dgwFord.Rows[selected].Cells[1].Value.ToString();
            model = dgwFord.Rows[selected].Cells[2].Value.ToString();
            year = dgwFord.Rows[selected].Cells[3].Value.ToString();
            price = dgwFord.Rows[selected].Cells[4].Value.ToString();
            color = dgwFord.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwFord.Rows[selected].Cells[6].Value.ToString();
        }
    }
}
