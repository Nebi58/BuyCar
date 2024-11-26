using BuyCar_Business;
using BuyCar_DataAccess;
using iTextSharp.text.pdf.qrcode;
using Org.BouncyCastle.Math;
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
    public partial class BuyCar_BMW2 : Form
    {
        public BuyCar_BMW2()
        {
            InitializeComponent();
        }
        public string BMW3;
        private void BuyCar_BMW2_Load(object sender, EventArgs e)
        {
            txtBrand.Text = BMW3;
            BMW_List bMW = new BMW_List();
            dgwBMW2.DataSource = bMW.selectBMW();
            //Datagridview'daki sütun başlıklarını değiştirdik
            dgwBMW2.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwBMW2.Columns["Car_Brand"].HeaderText = "Brand";
            dgwBMW2.Columns["Car_Model"].HeaderText = "Model";
            dgwBMW2.Columns["Property_Year"].HeaderText = "Year";
            dgwBMW2.Columns["Property_Price"].HeaderText = "Price";
            dgwBMW2.Columns["Property_Color"].HeaderText = "Color";
            dgwBMW2.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
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
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo where Car_Brand='BMW'", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwBMW2.DataSource = dataTable;
        }
        private void dgwBMW2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwBMW2.SelectedCells[0].RowIndex;
            txtSerialNo.Text = dgwBMW2.Rows[selected].Cells[0].Value.ToString();
            txtBrand.Text = dgwBMW2.Rows[selected].Cells[1].Value.ToString();
            txtModel.Text = dgwBMW2.Rows[selected].Cells[2].Value.ToString();

            serialno = dgwBMW2.Rows[selected].Cells[0].Value.ToString();
            brand = dgwBMW2.Rows[selected].Cells[1].Value.ToString();
            model = dgwBMW2.Rows[selected].Cells[2].Value.ToString();
            year = dgwBMW2.Rows[selected].Cells[3].Value.ToString();
            price = dgwBMW2.Rows[selected].Cells[4].Value.ToString();
            color = dgwBMW2.Rows[selected].Cells[5].Value.ToString();
            fueltype = dgwBMW2.Rows[selected].Cells[6].Value.ToString();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            model = txtModel.Text;
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
                else if (model == "X8")
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
            catch
            {
                MessageBox.Show("Araç seçmeyi unuttunuz ya da bu araba daha önceden alındı");
            }
        }
    }
}
