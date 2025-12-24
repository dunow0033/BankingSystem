using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankDepositModel
    {
        public static void Deposit(int addedMoney, UserBankAccount userBankAccount)
        {
            //try
            //{
                depositMoneyToUserBankAccount(addedMoney, userBankAccount);
            //}
        }

        public static void depositMoneyToUserBankAccount(int addedMoney, UserBankAccount userBankAccount)
        {
            using (SqlConnection connection = new SqlConnection(BankUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateBankAccountBalance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AddedMoney", SqlDbType.Int).Value = addedMoney;
                    command.Parameters.Add("@BankAccountID", SqlDbType.Int).Value = userBankAccount.BankAccountID;

                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
