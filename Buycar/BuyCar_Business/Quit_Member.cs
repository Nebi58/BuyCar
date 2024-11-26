using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Quit_Member
    {
        public SqlDataReader Quit(string tc, string password)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("DELETE FROM Tbl_Customer where Customer_TC=@p1 and Customer_Password=@p2", connection.connection());
            command.Parameters.AddWithValue("@p1", tc);
            command.Parameters.AddWithValue("@p2", password);

            SqlDataReader reader = command.ExecuteReader();
            connection.connection().Close();
            return reader;
        }
    }
}
