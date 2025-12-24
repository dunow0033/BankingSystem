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
    public class BankOpenAccount
    {
        public BankOpenAccount() 
        { }

        public static void Run(User user)
        {
            UserBankAccount newAccount;
            int typeID, statusID, balance;
            int? currencyID;
            string nickName;
            BankAccountType bankAccountType;
            nickName = takeAccountNickname();
            BankAccountTypeInfo bankAccountTypeInfo;
            Currency currencyType;
            BankAccountStatus bankAccountStatusType;
            typeID = takeAccountType();
            bankAccountType = BankAccountTypeInfo.typeInIndex(typeID - 1);
            BankAccountType typeEnum = BankAccountTypeInfo.typeInIndex(typeID - 1);
            bankAccountTypeInfo = BankAccountTypeInfo.FromType(typeEnum);
            currencyID = takeAccountCurrency();
            Currency currencyEnum  = CurrencyInfo.typeInIndex(currencyID - 1);
            CurrencyInfo currencyInfo = CurrencyInfo.FromType(currencyEnum);
            //statusID = (int)BankAccountStatus.Pending;
            //bankAccountStatusType = BankAccountStatusUtils.typeInIndex(statusID - 1);
            bankAccountStatusType = BankAccountStatus.Pending;
            balance = takeBalance(bankAccountTypeInfo);
            newAccount = new UserBankAccount(user.Username, nickName, bankAccountStatusType, balance, typeID, currencyID, null);
            newAccount.TypeId = typeID;
            newAccount.CurrencyId = currencyID;
            BankOpenAccountModel.saveNewAccount(user, newAccount);
        }

        private static string takeAccountNickname()
        {
            String nickname;
            
            do
            {
                nickname = BankOpenAccountView.takeNickname();
            } while (!Regex.IsMatch(nickname, "^[A-Za-z][A-Za-z0-9]{0,49}$"));

            return nickname;
        }

        private static int takeAccountType()
        {
            BankAccountTypeInfo.showAll();
            String typeID;
            do
            {
                typeID = BankOpenAccountView.takeType();
            } while (!Regex.IsMatch(typeID, "^[1 - 2]$"));

            return int.Parse(typeID);
        }

        private static int takeAccountCurrency()
        {
            String typeID;
            CurrencyInfo.showAll();
            do
            {
                typeID = BankOpenAccountView.takeType();
            } while (!Regex.IsMatch(typeID, "^[1 - 2]$"));
            return int.Parse(typeID);
        }

        private static int takeBalance(BankAccountTypeInfo bankAccountTypeInfo)
        {
            string balance;
            do
            {
                balance = BankOpenAccountView.takeInitialBalance();
            } while (int.Parse(balance) < 0 || int.Parse(balance) > 1000 || !bankAccountTypeInfo.checkValidBalance(int.Parse(balance)));

            return int.Parse(balance);
        }
    }
}
