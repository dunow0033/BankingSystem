using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class UserBankAccount
    {
        public String username = "";
        public int bankAccountID = 1;
        //public BankAccountType type;
        public BankAccountStatus status = 0;
        public int balance = 0;
        //public Currency currency;
        public int withdrawalLimit = 0;
        public String createdAt = "";

        public UserBankAccount(String username, 
                                int bankAccountID, 
                                //BankAccountType type,
                                //Currency currency,
                                BankAccountStatus status, 
                                int balance, 
                                int withdrawalLimit, 
                                String createdAt)
        {
            this.username = username;
            this.bankAccountID = bankAccountID;
            //this.type = type;
            this.status = status;
            this.balance = balance;
            //this.currency = currency;
            this.withdrawalLimit = withdrawalLimit;
            this.createdAt = createdAt;
        }
    }
}
