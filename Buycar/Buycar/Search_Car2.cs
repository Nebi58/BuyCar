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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Buycar
{
    public partial class Search_Car2 : Form
    {
        public Search_Car2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Car2_Load(object sender, EventArgs e)
        {
            Car_List car_List = new Car_List();
            dgwCarList.DataSource = car_List.selectCar();
            dgwCarList.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Car_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Car_Model"].HeaderText = "Model";
            dgwCarList.Columns["Property_Year"].HeaderText = "Year";
            dgwCarList.Columns["Property_Price"].HeaderText = "Price";
            dgwCarList.Columns["Property_Color"].HeaderText = "Color";
            dgwCarList.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? year = string.IsNullOrEmpty(txtYear.Text) ? (int?)null : (int?)Convert.ToInt32(txtYear.Text);
            string color = string.IsNullOrEmpty(cmbColor.Text) ? null : cmbColor.Text;
            decimal? price = string.IsNullOrEmpty(txtPrice.Text) ? (decimal?)null : (decimal?)Convert.ToDecimal(txtPrice.Text);
            string fueltype = string.IsNullOrEmpty(cmbFueltype.Text) ? null : cmbFueltype.Text;

            Car_List car_List2 = new Car_List();
            dgwCarList.DataSource = car_List2.selectProperty(year, price, color, fueltype);
            dgwCarList.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Car_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Car_Model"].HeaderText = "Model";
            dgwCarList.Columns["Property_Year"].HeaderText = "Year";
            dgwCarList.Columns["Property_Price"].HeaderText = "Price";
            dgwCarList.Columns["Property_Color"].HeaderText = "Color";
            dgwCarList.Columns["Property_FuelType"].HeaderText = "FuelType";
        }
        public int serialno;
        public string brand, model;

        private void dgwCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dgwCarList.SelectedCells[0].RowIndex;

            serialno = Convert.ToInt32(dgwCarList.Rows[selected].Cells[0].Value);
            model = dgwCarList.Rows[selected].Cells[1].Value.ToString();
            brand = dgwCarList.Rows[selected].Cells[2].Value.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                Car_Buy car_Buy = new Car_Buy();
                car_Buy.Sales(new SalesCar
                {
                    SerialNo = serialno,
                    Brand = brand,
                    Model = model
                });
                car_Buy.DeleteCar(serialno);
                MessageBox.Show("Satın alındı...");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Araç satin alindi");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData2();
        }

        public void GetData2()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT t1.Car_SerialNo,t1.Car_Brand,t1.Car_Model" +
                ", t2.Property_Year,t2.Property_Price,t2.Property_Color,t2.Property_FuelType FROM Tbl_Car t1 " +
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwCarList.DataSource = dataTable;
        }
    }
}
