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
    public class BankTransfer
    {
        public BankTransfer() { }

        public static void Run(UserBankAccount userBankAccount)
        {
            if (userBankAccount.WithdrawalLimit == 0)
            {
                BankWithdrawalView.showWithdrawalEnd();
                return;
            }

            int otherUserBankAccountID = connectToAnotherUserBankAccount(userBankAccount);


            if (otherUserBankAccountID.Equals(-1)) return;
            BankTransferModel.Transfer(userBankAccount, otherUserBankAccountID);
        }

        public static int connectToAnotherUserBankAccount(UserBankAccount userBankAccount)
        {
            string otherUserBankAccountID;

            do
            {
                otherUserBankAccountID = BankTransferView.takeOtherAccount();

                if (otherUserBankAccountID.Equals(-1)) return -1;
            } while(!checkValidOtherUserBankAccountID(userBankAccount, otherUserBankAccountID));

            return int.Parse(otherUserBankAccountID);
        }

        public static bool checkValidOtherUserBankAccountID(UserBankAccount userBankAccount, string otherUserBankAccountID)
        {
            if(!Regex.IsMatch(otherUserBankAccountID, "[0-9]+"))
            {
                return false;
            }

            if (int.Parse(otherUserBankAccountID).Equals(userBankAccount.BankAccountID))
            {
                BankTransferView.showSameAccount();
                return false;
            }

            return BankTransferModel.checkValidAccount(userBankAccount, otherUserBankAccountID);
        }
    }
}
