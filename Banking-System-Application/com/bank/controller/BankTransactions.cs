using Banking_System_Application.com.bank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankTransactions
    {
        private const int limitNumber = 5;

        public BankTransactions() { }

        public static void Run(UserBankAccount userBankAccount)
        {
            //BankTransactionsModel.
            bool wantMore;
            int numberOfLogs = BankTransactionsModel.getNumberOfTransactions(userBankAccount.Username);
            int offsetNumber = 0;

            do
            {
                List<Transaction> transactions = BankTransactionsModel.collectTransactions(userBankAccount.Username, lim)
            }
        }
    }
}
