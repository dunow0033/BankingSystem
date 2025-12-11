//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Banking_System_Application.com.bank.model
//{
//    public class BankLoginModel
//    {
//        public static String getPasswordOf(String username)
//        {
//            String password = null;

//            //try
//            //{
//                using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
//                {
//                    connection.Open();

//                    using(SqlCommand command = new SqlCommand("getUserPassword", connection))
//                    {
//                        command.CommandType = CommandType.StoredProcedure;
//                        command.Parameters.AddWithValue("@username", username);

//                        using(SqlDataReader reader = command.ExecuteReader())
//                        {
//                            if(reader.Read())
//                            {
//                                password = reader["password"].ToString();
//                            }
//                        }
//                    }
//                }
//            //}
//            return password;
//        }
//    }
//}
