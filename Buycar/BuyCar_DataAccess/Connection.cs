using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_DataAccess
{
    public class Connection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection(@"server=NEBI\SQLEXPRESS;initial catalog=BuyCar;integrated security=true");
            connection.Open();
            return connection;
        }
    }
}
