using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Car_List
    {
        public DataTable selectCar()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("sp_GetCars", connection.connection());
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            reader.Close();
            connection.connection().Close();

            return table;
        }

        public DataTable selectProperty(int? year,decimal? price,string color,string fueltype)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("sp_GetProperties", connection.connection());
            command.CommandType = CommandType.StoredProcedure;

            // Parametre ekleme işlemleri
            command.Parameters.Add("@PropertyYear", SqlDbType.Int).Value = (object)year ?? DBNull.Value;
            command.Parameters.Add("@Property_Price", SqlDbType.Money).Value = (object)price ?? DBNull.Value;
            command.Parameters.Add("@PropertyColor", SqlDbType.VarChar).Value = color;
            command.Parameters.Add("@Property_FuelType", SqlDbType.VarChar).Value = fueltype;

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            reader.Close();
            connection.connection().Close();

            return table;
        }


        public DataTable selectSalesCar()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("sp_GetSalesCars", connection.connection());
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            reader.Close();
            connection.connection().Close();

            return table;
        }
    }
}
