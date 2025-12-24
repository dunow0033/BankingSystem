//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankLoginModel
    {
        public static User getUsername(string username, string password)
        {

            //try
            //{
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getUserByPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Username = reader["Username"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
