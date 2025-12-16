using Banking_System_Application.com.bank.view;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankRegistrationModel
    {
        private static readonly BankContext bankContext = new BankContext();

        public static bool checkUniqueUsername(String username)
        {
            bool isUniqueUsername = false;

            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);   

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isUniqueUsername = !reader.Read();
                    }
                }
            }

            return isUniqueUsername;
        }

        public static bool checkUniqueEmail(String email)
        {
            bool isUniqueEmail = false;

            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getEmail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isUniqueEmail = !reader.Read();
                    }
                }
            }

            return isUniqueEmail;
        }

        public static void saveNewUser(User user)
        {
            insertIntoUsersTable(user);
        }

        private static void insertIntoUsersTable(User user)
        {
            //try {
                bankContext.Add(user);
                int saved = bankContext.SaveChanges();
                
                if(saved > 0)
                {
                    Console.WriteLine("Contact has been saved");
                }
                else
                {
                    Console.WriteLine("There was an error");
                }

            Thread.Sleep(3000);

                //Console.ReadKey();
            //}
        }
    }
}
