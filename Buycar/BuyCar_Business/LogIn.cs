using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class LogIn
    {
        public SqlDataReader Log(string tc, string password)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("Select * from Tbl_Customer where Customer_Nick=@p1 and Customer_Password=@p2", connection.connection());
            command.Parameters.AddWithValue("@p1", tc);
            command.Parameters.AddWithValue("@p2", password);
            SqlDataReader reader = command.ExecuteReader();
            connection.connection().Close();
            return reader;
        }
    }
}
