using Banking_System_Application.com.bank.view;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankTransferModel
    {
        public static void Transfer(UserBankAccount userBankAccount, int otherUserBankAccountID)
        {
            transferMoney(userBankAccount, otherUserBankAccountID);
        }

        public static void transferMoney(UserBankAccount userBankAccount, int otherUserBankAccountID)
        {
            int transferredMoney = takeMoneyToBeTransferred(userBankAccount);
            transferMoneyToOtherUserBankAccount(transferredMoney, otherUserBankAccountID);
            withdrawMoneyFromThisUserBankAccount(userBankAccount, transferredMoney);

        }

        public static int takeMoneyToBeTransferred(UserBankAccount userBankAcount)
        {
            string moneyToBeTransferred;

            do
            {
                moneyToBeTransferred = BankTransferView.takeMoney();
            } while (!Regex.IsMatch(moneyToBeTransferred, "[0-9]+") || int.Parse(moneyToBeTransferred) > userBankAcount.Balance);

            return int.Parse(moneyToBeTransferred);
        }

        public static void transferMoneyToOtherUserBankAccount(int transferredMoney, int otherUserBankAccountID)
        {
            updateUserBankAccountTable(transferredMoney, otherUserBankAccountID);

        }

        private static void withdrawMoneyFromThisUserBankAccount(UserBankAccount userBankAccount, int transferredMoney)
        {
            //String SQLStatement = "call updateBankAccountBalance(-?,?)";
            updateUserBankAccountTable(transferredMoney, userBankAccount.BankAccountID);
        }

        public static void updateUserBankAccountTable(int transferredMoney, int BankAccountID)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("withdrawTransferredMoney", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAccountID", BankAccountID);
                    command.Parameters.AddWithValue("@TransferredMoney", transferredMoney);

                    command.ExecuteNonQuery();

                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{

                    //}
                }
            }
        }

        public static bool checkValidAccount(UserBankAccount userBankAccount, string otherUserBankAccountId)
        {
            bool isValidBankAccount = false;

            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("checkValidAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAccountID", otherUserBankAccountId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bankAccountId = reader.GetInt32(reader.GetOrdinal("bankAccountID"));

                            if (bankAccountId.Equals(otherUserBankAccountId))
                            {
                                isValidBankAccount = true;
                                break;
                            }
                        }
                    }
                }
            }

            return isValidBankAccount;
        }
    }
}
