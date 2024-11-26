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
using ZedGraph;

namespace Buycar
{
    public partial class ZedGraph_SaledCars : Form
    {
        public ZedGraph_SaledCars()
        {
            InitializeComponent();
            CarZedGraph();
        }
        Connection connection = new Connection();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_SaledCars admin_SaledCars = new Admin_SaledCars();
            admin_SaledCars.Show();
            this.Hide();
        }

        private void ZedGraph_SaledCars_Load(object sender, EventArgs e)
        {
            connection.connection();
        }

        private void CarZedGraph()
        {
            // Burada oluşturduğumuz tablonun ismini satırında nelerin bulunacağını ve sütununda nelerin bulunacağını gösterdik.
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "CARS";
            graphPane.XAxis.Title.Text = "Brand";
            graphPane.YAxis.Title.Text = "Number of cars ";

            // Burada arabanın ismine göre sayısını aldık yani y eksenini girdik.
            PointPairList pointPairList = GetCountCar();

            // Çubuk grafik oluştur
            BarItem barItem = graphPane.AddBar("Number of cars", pointPairList, Color.Blue);

            // Grafik özelliklerini özelleştir
            graphPane.BarSettings.ClusterScaleWidth = 0.6;
            graphPane.BarSettings.Type = BarType.Cluster;

            // X ekseni tipini metin olarak ayarla
            graphPane.XAxis.Type = AxisType.Text;

            // X ekseni üzerindeki şehir isimlerini ayarla
            string[] carNames = GetBrandNames();
            graphPane.XAxis.Scale.TextLabels = carNames;

            // Grafik güncellensin
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private PointPairList GetCountCar()
        {
            PointPairList pointPairList = new PointPairList();

            try
            {
                SqlCommand command = new SqlCommand("SELECT Sales_Brand,COUNT(*) AS CarCount FROM Tbl_CarSales GROUP BY Sales_Brand", connection.connection());
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string brand = reader["Sales_Brand"].ToString();
                    double carCount = Convert.ToDouble(reader["CarCount"]);
                    pointPairList.Add(pointPairList.Count + 1, carCount); // X değeri olarak sıralı sayı ekliyoruz.
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR... " + ex.Message);
            }

            return pointPairList;
        }

        private string[] GetBrandNames()
        {
            try
            {
                SqlCommand command2 = new SqlCommand("SELECT DISTINCT Sales_Brand FROM Tbl_CarSales", connection.connection());
                SqlDataReader reader2 = command2.ExecuteReader();

                List<string> cityNames = new List<string>();

                while (reader2.Read())
                {
                    string city = reader2["Sales_Brand"].ToString();
                    cityNames.Add(city);
                }

                reader2.Close();

                return cityNames.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR... " + ex.Message);
                return new string[0];
            }
        }
    }
}
