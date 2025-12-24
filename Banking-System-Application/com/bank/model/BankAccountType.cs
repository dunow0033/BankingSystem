using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public enum BankAccountType
    {
        Basic,
        Saving
    }

    public class BankAccountTypeInfo
    {
        public string Name { get; set; }
        public int MinBalance { get; set; }
        public int WithdrawLimit { get; set; }
        public int DepositLimit {  get; set; }
        public int InterestRate { get; set; }
        public int Fee { get; set; }

        public static readonly Dictionary<BankAccountType, BankAccountTypeInfo> Info =
            new Dictionary<BankAccountType, BankAccountTypeInfo>()
            {
                { BankAccountType.Basic, new BankAccountTypeInfo ( "Basic", 0, 2, 4, 1000, 50 ) },
                { BankAccountType.Saving, new BankAccountTypeInfo ( "Saving", 500, 3, 5, 750, 150 ) },
            };

        BankAccountTypeInfo(string name, int minBalance, int withdrawLimit, int depositLimit, int interestRate, int fee)
        {
            Name = name;
            MinBalance = minBalance;
            WithdrawLimit = withdrawLimit;
            DepositLimit = depositLimit;
            InterestRate = interestRate;
            Fee = fee;
        }

        public static void showAll()
        {
            BankUtil.createMessage("There are 2 types of bank accounts");
            Console.WriteLine($"1. {BankAccountType.Basic}");
            Console.WriteLine();
            Console.WriteLine($"2. {BankAccountType.Saving}");
        }

        public static BankAccountType typeInIndex(int index)
        {
            return (BankAccountType)index;
        }

        public static BankAccountTypeInfo FromType(BankAccountType type)
        {
            return Info[type];
        }

        public bool checkValidBalance(int balance)
        {
            return balance >= this.MinBalance;
        }
    }
}
