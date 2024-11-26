using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class Admin_Info
    {
        public SqlDataReader admininfo(int mersisno)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("sp_GetCompanyInfo", connection.connection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p1", mersisno);
            SqlDataReader reader = command.ExecuteReader();
            connection.connection().Close();

            return reader;
        }
    }
}
