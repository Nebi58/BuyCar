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

        public string serialno, brand, model, year, price, color, fueltype;
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            BuyCar buycar = new BuyCar();
            buycar.Show();
            this.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                MessageBox.Show("Tablodan araba seçmeyi unuttunuz...");
            }
            else
            {
                model = txtModel.Text;
                if(model == "A3")
                {
                    Audi_designer1 audi_Designer1 = new Audi_designer1();
                    
                    audi_Designer1.Aserialno = serialno;
                    audi_Designer1.Abrand = brand;
                    audi_Designer1.Amodel = model;
                    audi_Designer1.Ayear = year;
                    audi_Designer1.Aprice = price;
                    audi_Designer1.Afueltype = fueltype;

                    audi_Designer1.Show();
                }
                else if(model == "A5")
                {
                   Audi_Designer2 audi_Designer2 = new Audi_Designer2();
                    audi_Designer2.Aserialno = serialno;
                    audi_Designer2.Abrand = brand;
                    audi_Designer2.Amodel = model;
                    audi_Designer2.Ayear = year;
                    audi_Designer2.Aprice = price;
                    audi_Designer2.Afueltype = fueltype;

                    audi_Designer2.Show();
                }
                else
                {
                    MessageBox.Show("Araba seçiminde yanlışlık var.");
                }
            }
        }

        private void dgwAudi_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwAudi.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwAudi.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwAudi.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwAudi.Rows[selected].Cells[2].Value.ToString();

            //Diğer sayfada kullanacağımız değişkenlere ekleme yapar
            serialno = dgwAudi.Rows[selected].Cells[0].Value.ToString();
            brand = dgwAudi.Rows[selected].Cells[1].Value.ToString();
            model = dgwAudi.Rows[selected].Cells[2].Value.ToString();
            year = dgwAudi.Rows[selected].Cells[3].Value.ToString();
            price = dgwAudi.Rows[selected].Cells[4].Value.ToString();
            color = dgwAudi.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwAudi.Rows[selected].Cells[6].Value.ToString();
        }
    }
}
