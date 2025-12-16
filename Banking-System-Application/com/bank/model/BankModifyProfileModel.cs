using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankModifyProfileModel
    {
        public static void updateUsername(String newAddress, String userName)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateAddressByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@NewAddress", newAddress);

                    command.ExecuteNonQuery();

                }
            }
        }

        public static void updatePassword(String newPassword,  String userName)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdatePasswordByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    command.ExecuteNonQuery();
                    
                }
            }
        }

        public static void updatePhoneNumber(String newPhoneNumber, String userName)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdatePhoneNumberByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);

                    command.ExecuteNonQuery();

                }
            }
        }

        public static void updateAddress(String newAddress, String userName)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateAddressByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@NewAddress", newAddress);

                    command.ExecuteNonQuery();

                }
            }
        }

        public static void updateEmail(String newEmail, String userName)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateEmailByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", userName);
                    command.Parameters.AddWithValue("@NewEmail", newEmail);

                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
