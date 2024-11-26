using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCar_Business
{
    public class CSignUp
    {
        public void Add(Customer customer)
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("INSERT Tbl_Customer values (@Customer_TC,@Customer_Name,@Customer_Surname,@Customer_City,@Customer_Email,@Customer_Phone,@Customer_Nick,@Customer_Password)", connection.connection());
            command.Parameters.AddWithValue("@Customer_TC", customer.TC);
            command.Parameters.AddWithValue("@Customer_Name", customer.Name);
            command.Parameters.AddWithValue("@Customer_Surname", customer.Surname);
            command.Parameters.AddWithValue("@Customer_City", customer.City);
            command.Parameters.AddWithValue("@Customer_Email", customer.Email);
            command.Parameters.AddWithValue("@Customer_Phone", customer.Phone);
            command.Parameters.AddWithValue("@Customer_Nick", customer.Nick);
            command.Parameters.AddWithValue("Customer_Password", customer.Password);
            command.ExecuteNonQuery();
            connection.connection().Close();
        }
    }
}
