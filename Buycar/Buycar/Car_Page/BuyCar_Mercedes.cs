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
    public partial class BuyCar_Mercedes : Form
    {
        public BuyCar_Mercedes()
        {
            InitializeComponent();
        }
        public string Mercedes2;
        public string serialno, brand, model, year, price, color, fueltype;
        private void BuyCar_Mercedes_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Mercedes2;
            Mercedes_List mercedes_List = new Mercedes_List();
            dgwMercedes.DataSource=mercedes_List.selectMercedes();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwMercedes.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwMercedes.Columns["Car_Brand"].HeaderText = "Brand";
            dgwMercedes.Columns["Car_Model"].HeaderText = "Model";
            dgwMercedes.Columns["Property_Year"].HeaderText = "Year";
            dgwMercedes.Columns["Property_Price"].HeaderText = "Price";
            dgwMercedes.Columns["Property_Color"].HeaderText = "Color";
            dgwMercedes.Columns["Property_FuelType"].HeaderText = "FuelType";
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
                if (model == "C-Class")
                {
                    Mercedes_Designer1 mercedes_Designer1 = new Mercedes_Designer1();
                    mercedes_Designer1.Bserialno = serialno;
                    mercedes_Designer1.Bbrand = brand;
                    mercedes_Designer1.Bmodel = model;
                    mercedes_Designer1.Byear = year;
                    mercedes_Designer1.Bprice = price;
                    mercedes_Designer1.Bfueltype = fueltype;

                    mercedes_Designer1.Show();
                }
                else if (model == "G-Class")
                {
                    mercedes_designer2 mercedes_Designer2 = new mercedes_designer2();
                    mercedes_Designer2.Bserialno = serialno;
                    mercedes_Designer2.Bbrand = brand;
                    mercedes_Designer2.Bmodel = model;
                    mercedes_Designer2.Byear = year;
                    mercedes_Designer2.Bprice = price;
                    mercedes_Designer2.Bfueltype = fueltype;

                    mercedes_Designer2.Show();
                }
                else
                {
                    MessageBox.Show("Araba seçiminde yanlışlık var.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar buycar = new BuyCar();
            buycar.Show();
            this.Hide();
        }

        private void dgwMercedes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwMercedes.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwMercedes.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwMercedes.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwMercedes.Rows[selected].Cells[2].Value.ToString();

            //Diğer sayfada kullanacağımız değişkenlere ekleme yapar
            serialno = dgwMercedes.Rows[selected].Cells[0].Value.ToString();
            brand = dgwMercedes.Rows[selected].Cells[1].Value.ToString();
            model = dgwMercedes.Rows[selected].Cells[2].Value.ToString();
            year = dgwMercedes.Rows[selected].Cells[3].Value.ToString();
            price = dgwMercedes.Rows[selected].Cells[4].Value.ToString();
            color = dgwMercedes.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwMercedes.Rows[selected].Cells[6].Value.ToString();
        }
    }
}
