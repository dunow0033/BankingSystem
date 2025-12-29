using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankOpenAccountModel
    {
        public static void saveNewAccount(User user, UserBankAccount newAccount)
        {

            //try
            //{
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                //Console.WriteLine($"DEBUG: newAccount.status = {newAccount.status} ({(int)newAccount.status})");

                //Thread.Sleep(8000);


                using (SqlCommand command = new SqlCommand("saveNewAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@TypeId", newAccount.TypeId);
                    command.Parameters.AddWithValue("@CurrencyId", newAccount.CurrencyId);
                    command.Parameters.AddWithValue("@Balance", newAccount.Balance);
                    command.Parameters.AddWithValue("@Status", (int)newAccount.status);
                    command.Parameters.AddWithValue("@Nickname", newAccount.Nickname);
                    command.Parameters.AddWithValue("@WithdrawalLimit", newAccount.WithdrawalLimit);

                    command.ExecuteNonQuery();
                }
            }

            //return null;
        }

        public static bool checkUniqueNickname(User user, String nickname)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("checkUniqueNickname", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", user.Username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string existingNickname = reader.GetString(reader.GetOrdinal("Nickname"));

                            if (existingNickname.Equals(nickname, StringComparison.OrdinalIgnoreCase))
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
