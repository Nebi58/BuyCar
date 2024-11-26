using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo where Car_Brand='Mercedes'", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwMercedes2.DataSource = dataTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
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
                    Mercedes_Designer1 mercedes_Designer2 = new Mercedes_Designer1();
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

        private void dgwMercedes2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwMercedes2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwMercedes2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwMercedes2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwMercedes2.Rows[selected].Cells[2].Value.ToString();

            serialno = dgwMercedes2.Rows[selected].Cells[0].Value.ToString();
            brand = dgwMercedes2.Rows[selected].Cells[1].Value.ToString();
            model = dgwMercedes2.Rows[selected].Cells[2].Value.ToString();
            year = dgwMercedes2.Rows[selected].Cells[3].Value.ToString();
            price = dgwMercedes2.Rows[selected].Cells[4].Value.ToString();
            color = dgwMercedes2.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwMercedes2.Rows[selected].Cells[6].Value.ToString();
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
    }
}
