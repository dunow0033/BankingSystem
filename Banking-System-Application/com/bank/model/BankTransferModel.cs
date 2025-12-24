using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class BankTransferModel
    {
        //public static void transfer(UserBankAccount userBankAccount, int otherUserBankAccountID)
        //{
        //    transferMoney(UserBankAccount, otherUserBankAccountID);
        //}

        //public static void transferMoney(UserBankAccount userBankAccount)
        //{
        //    int transferredMoney = takeMoneyToBeTransferred(userBankAccount);
        //    transferMoneyToOtherUserBankAccount(transferredMoney, otherUserBankAccountID);
        //    withdrawMoneyFromThisUserBankAccount(userBankAccount, transferredMoney);

        //}

        //public static int takeMoneyToBeTransferred(UserBankAccount userBankAcount)
        //{
        //    string moneyToBeTransferred;

        //    do
        //    {
        //        moneyToBeTransferred = BankTransferView.takeMoney();
        //    } while (!Regex.IsMatch(moneyToBeTransferred, "[0-9]+") || int.Parse(moneyToBeTransferred) > userBankAcount.balance);

        //    return int.Parse(moneyToBeTransferred);
        //}

        public static void transferMoneyToOtherUserBankAccount(int amount, int otherUserBankAccountID)
        {
            //updateUserBankAccountTable(transferMoney, otherUserBankAccountID);

        }

        public static void updateUserBankAccountTable(int transferredMoney, int bankAccountID)
        {

        }

        //public static bool checkValidAccount(UserBankAccount userBankAccount, int accountID)
        //{
        //    bool isValidBankAccount
        //}
    }
}
