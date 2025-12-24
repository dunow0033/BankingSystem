using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankViewAccountModel
    {
        public static List<UserBankAccount> collectUserBankAccounts(User user)
        {
            List<UserBankAccount> bankAccounts = new List<UserBankAccount>();

            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getUserBankAccounts", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = user.Username;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var account = new UserBankAccount()
                            {
                                BankAccountID = reader.GetInt32(reader.GetOrdinal("BankAccountID")),

                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Nickname = reader.GetString(reader.GetOrdinal("Nickname")),
                                TypeId = reader.GetInt32(reader.GetOrdinal("TypeId")),
                                status = (BankAccountStatus)reader.GetInt32(reader.GetOrdinal("status")),
                                CurrencyId = reader.GetInt32(reader.GetOrdinal("CurrencyId")),
                                Balance = reader.GetInt32(reader.GetOrdinal("Balance")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt")),

                                WithdrawalLimit = reader.IsDBNull(reader.GetOrdinal("WithdrawalLimit"))
                                    ? null
                                    : reader.GetInt32(reader.GetOrdinal("WithdrawalLimit"))
                            };

                            bankAccounts.Add(account);

                        }

                    }
                }

            }

            return bankAccounts;
        }
    }
}
