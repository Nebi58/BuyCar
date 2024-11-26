using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Import
    {
        Connection connection=new Connection();

        public void Import_Car(string Car_Brand, string Car_Model)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("INSERT Tbl_Car (Car_Brand,Car_Model) VALUES (@p1,@p2)", connection.connection());
            command.Parameters.AddWithValue("@p1", Car_Brand);
            command.Parameters.AddWithValue("@p2", Car_Model);
            command.ExecuteNonQuery();
        }
        public int Car_Id()
        {
            int id = -1;
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT TOP 1 Car_SerialNo from Tbl_Car ORDER BY Car_SerialNo DESC", connection.connection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["Car_SerialNo"]);
            }
            else
            {
                Console.WriteLine("Message don't have");
            }
            return id;
        }
        public void Import_Property(int Id, int year,int price,string color,string fueltype)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("INSERT Tbl_Property (Property_Year,Property_Price,Property_Color,Property_FuelType,Car_SerialNo) VALUES (@p1,@p2,@p3,@p4,@p5)", connection.connection());
            command.Parameters.AddWithValue("@p1", year);
            command.Parameters.AddWithValue("@p2", price);
            command.Parameters.AddWithValue("@p3", color);
            command.Parameters.AddWithValue("@p4", fueltype);
            command.Parameters.AddWithValue("@p5", Id);
            command.ExecuteNonQuery();
        }
    }
}
