using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Car_Add
    {
        public void Add_Car(Car car)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("INSERT Tbl_Car (Car_Brand,Car_Model) VALUES (@p1,@p2)", connection.connection());
            command.Parameters.AddWithValue("@p1", car.Brand);
            command.Parameters.AddWithValue("@p2", car.Model);
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
        public void Add_Property(int Id,Property property)
        {
            Connection connection=new Connection();
            SqlCommand command = new SqlCommand("INSERT Tbl_Property (Property_Year,Property_Price,Property_Color,Property_FuelType,Car_SerialNo) VALUES (@p1,@p2,@p3,@p4,@p5)", connection.connection());
            command.Parameters.AddWithValue("@p1", property.Year);
            command.Parameters.AddWithValue("@p2", property.Price);
            command.Parameters.AddWithValue("@p3", property.Color);
            command.Parameters.AddWithValue("@p4", property.FuelType);
            command.Parameters.AddWithValue("@p5", Id);
            command.ExecuteNonQuery();
        }
    }
}
