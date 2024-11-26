using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class BuyCar_Admin : Form
    {
        public BuyCar_Admin()
        {
            InitializeComponent();
        }
        public int mersisno;
        private void BuyCar_Admin_Load(object sender, EventArgs e)
        {
            Admin_Info admin_Info = new Admin_Info();
            SqlDataReader reader = admin_Info.admininfo(mersisno);
            while (reader.Read())
            {
                lblName.Text = reader[0] + " ";
                lblSurname.Text = reader[1] + " ";
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin_AddCars admin_AddCars = new Admin_AddCars();
            admin_AddCars.Show();
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
                "INNER JOIN Tbl_Property t2 ON t1.Property_Id = t2.Property_Id",connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwCarList.DataSource = dataTable;
        }
    }
}
