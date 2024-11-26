using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        public string serialno, brand, model, year, price, color, fueltype;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData2();
        }

        public void GetData2()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT t1.Car_SerialNo,t1.Car_Brand,t1.Car_Model" +
                ", t2.Property_Year,t2.Property_Price,t2.Property_Color,t2.Property_FuelType FROM Tbl_Car t1 " +
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo where Car_Brand='Ford'", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwFord2.DataSource = dataTable;
        }

        private void dgwFord2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwFord2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwFord2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwFord2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwFord2.Rows[selected].Cells[2].Value.ToString();

            serialno = dgwFord2.Rows[selected].Cells[0].Value.ToString();
            brand = dgwFord2.Rows[selected].Cells[1].Value.ToString();
            model = dgwFord2.Rows[selected].Cells[2].Value.ToString();
            year = dgwFord2.Rows[selected].Cells[3].Value.ToString();
            price = dgwFord2.Rows[selected].Cells[4].Value.ToString();
            color = dgwFord2.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwFord2.Rows[selected].Cells[6].Value.ToString();
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int serialno = Convert.ToInt32(txtSerialNo.Text);
                Car_Buy car_Buy = new Car_Buy();
                car_Buy.Sales(new SalesCar
                {
                    SerialNo = Convert.ToInt32(txtSerialNo.Text),
                    Brand = txtBrand.Text,
                    Model = txtModel.Text
                });
                car_Buy.DeleteCar(serialno);
                MessageBox.Show("Satın alındı...");
            }
            catch
            {
                MessageBox.Show("Araç seçmeyi unuttunuz ya da bu araba daha önceden alındı");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }
    }
}
