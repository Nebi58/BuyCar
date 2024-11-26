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
    public class Member_List
    {
        public DataTable MyMember()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Customer", connection.connection());
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            connection.connection().Close();

            return table;
        }

        public DataTable DeleteMember()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_QuitMember", connection.connection());
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            connection.connection().Close();

            return table;
        }
    }
}
