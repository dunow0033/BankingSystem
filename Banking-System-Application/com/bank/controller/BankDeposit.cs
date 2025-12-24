using Banking_System_Application.com.bank.model;
using Banking_System_Application.com.bank.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.controller
{
    public class BankDeposit
    {
        private BankDeposit() { }

        public static void Run(UserBankAccount userBankAccount)
        {
            int addedMoney = takeMoneyToDeposit();

            if (addedMoney.Equals(-1)) return;

            BankDepositModel.Deposit(addedMoney, userBankAccount);
        }

        public static int takeMoneyToDeposit()
        {
            string addedMoney;

            do
            {
                addedMoney = BankDepositView.takeMoney();

                if (addedMoney.Equals("-1")) return -1;
            } while (!Regex.IsMatch(addedMoney, "[0-9]+"));
            return int.Parse(addedMoney);
        }
    }
}
