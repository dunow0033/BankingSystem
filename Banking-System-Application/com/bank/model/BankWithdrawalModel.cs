using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankWithdrawalModel
    {
        public static void Withdraw(int withdrawalMoney, UserBankAccount userBankAccount)
        {
            withdrawMoneyFromUserBankAccount(withdrawalMoney, userBankAccount);
        }

        public static void withdrawMoneyFromUserBankAccount(int withdrawalMoney, UserBankAccount userBankAccount)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("WithdrawMoneyFromUserBankAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@WithdrawalMoney", SqlDbType.Int).Value = withdrawalMoney;
                    command.Parameters.Add("@BankAccountID", SqlDbType.Int).Value = userBankAccount.BankAccountID;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
