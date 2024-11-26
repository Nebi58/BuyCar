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
        public string serialno, brand, model, year, price, color, fueltype;
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
            model=txtModel.Text;
            if (txtModel.Text == "")
            {
                MessageBox.Show("Tablodan araba seçmeyi unuttunuz...");
            }
            else
            {
                if (model == "X1")
                {
                    BMW_Designer1 bMW_Designer1 = new BMW_Designer1();
                    bMW_Designer1.Bserialno = serialno;
                    bMW_Designer1.Bbrand = brand;
                    bMW_Designer1.Bmodel = model;
                    bMW_Designer1.Byear = year;
                    bMW_Designer1.Bprice = price;
                    bMW_Designer1.Bfueltype = fueltype;

                    bMW_Designer1.Show();
                }
                else if(model == "X8")
                {
                    BMW_Designer2 bMW_Designer2 = new BMW_Designer2();
                    bMW_Designer2.Bserialno = serialno;
                    bMW_Designer2.Bbrand = brand;
                    bMW_Designer2.Bmodel = model;
                    bMW_Designer2.Byear = year;
                    bMW_Designer2.Bprice = price;
                    bMW_Designer2.Bfueltype = fueltype;

                    bMW_Designer2.Show();
                }
                else
                {
                    MessageBox.Show("Araba seçiminde yanlışlık var.");
                }
            }
        }

        private void dgwBMW_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwBMW.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwBMW.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwBMW.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwBMW.Rows[selected].Cells[2].Value.ToString();

            //Diğer sayfada kullanacağımız değişkenlere ekleme yapar
            serialno = dgwBMW.Rows[selected].Cells[0].Value.ToString();
            brand = dgwBMW.Rows[selected].Cells[1].Value.ToString();
            model = dgwBMW.Rows[selected].Cells[2].Value.ToString();
            year = dgwBMW.Rows[selected].Cells[3].Value.ToString();
            price = dgwBMW.Rows[selected].Cells[4].Value.ToString();
            color = dgwBMW.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwBMW.Rows[selected].Cells[6].Value.ToString();
        }
    }
}
