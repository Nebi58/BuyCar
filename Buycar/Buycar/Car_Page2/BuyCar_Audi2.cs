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
    public partial class BuyCar_Audi2 : Form
    {
        public BuyCar_Audi2()
        {
            InitializeComponent();
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
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo where Car_Brand='Audi'", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwAudi2.DataSource = dataTable;
        }
        private void dgwAudi2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //BuyCar_Audi2'deki toolbox bölümlerine ekleme yapar
            int selected = dgwAudi2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwAudi2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwAudi2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwAudi2.Rows[selected].Cells[2].Value.ToString();

            //Diğer sayfada kullanacağımız değişkenlere ekleme yapar
            serialno = dgwAudi2.Rows[selected].Cells[0].Value.ToString();
            brand = dgwAudi2.Rows[selected].Cells[1].Value.ToString();
            model = dgwAudi2.Rows[selected].Cells[2].Value.ToString();
            year = dgwAudi2.Rows[selected].Cells[3].Value.ToString();
            price = dgwAudi2.Rows[selected].Cells[4].Value.ToString();
            color = dgwAudi2.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwAudi2.Rows[selected].Cells[6].Value.ToString();
        }
        private void btnBuy_Click_1(object sender, EventArgs e)
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
            catch(Exception exception)
            {
                MessageBox.Show("Araç satin alindi");
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                MessageBox.Show("Tablodan araba seçmeyi unuttunuz...");
            }
            else
            {
                model = txtModel.Text;
                if (model == "A3")
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
                else if (model == "A5")
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
    }
}
