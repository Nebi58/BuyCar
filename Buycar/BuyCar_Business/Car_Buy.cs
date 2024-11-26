using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Car_Buy
    {
        Connection connection = new Connection();
        public void Sales(SalesCar salesCar)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Tbl_CarSales (Sales_SerialNo, Sales_Brand, Sales_Model) VALUES (@p1, @p2, @p3)", connection.connection());
            command.Parameters.AddWithValue("@p1", salesCar.SerialNo);
            command.Parameters.AddWithValue("@p2", salesCar.Brand);
            command.Parameters.AddWithValue("@p3", salesCar.Model);
            command.ExecuteNonQuery();
        }
        public void DeleteCar(int serialno)
        {
            SqlCommand command = new SqlCommand("sp_DeleteRecordsBySerialNo", connection.connection());
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SerialNo", serialno);
            command.ExecuteNonQuery();
        }
    }
}












