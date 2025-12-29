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
    public class BankWithdrawal
    {
        public BankWithdrawal() { }

        public static void Run(UserBankAccount userBankAccount)
        {
            if (userBankAccount.WithdrawalLimit == 0)
            {
                BankWithdrawalView.showWithdrawalEnd();
                return;
            }
            int withdrawalMoney = takeMoneyToWithdraw(userBankAccount);

            if (withdrawalMoney.Equals(-1)) return;
            BankWithdrawalModel.Withdraw(withdrawalMoney, userBankAccount);
        }

        public static int takeMoneyToWithdraw(UserBankAccount userBankAccount)
        {
            string withdrawalMoney;

            do
            {
                withdrawalMoney = BankWithdrawalView.takeMoney();
                if (withdrawalMoney.Equals("-1")) return -1;
            }while(!Regex.IsMatch(withdrawalMoney, "[0-9]+") || int.Parse(withdrawalMoney) > userBankAccount.Balance);

            return int.Parse(withdrawalMoney);
        }
    }
}
