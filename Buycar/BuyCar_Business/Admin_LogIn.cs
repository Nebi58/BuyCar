using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Admin_LogIn
    {
        public SqlDataReader Log(int mersisno, string password)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("Select * from Tbl_Company where Company_MersisNo=@p1 and Company_Password=@p2", connection.connection());
            command.Parameters.AddWithValue("@p1", mersisno);
            command.Parameters.AddWithValue("@p2", password);
            SqlDataReader reader = command.ExecuteReader();
            connection.connection().Close();
            return reader;
        }
    }
}
