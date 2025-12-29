using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public enum TransactionType
    {
        DEPOSIT("Deposit"),
        WITHDRAWAL("Withdrawal"),
        TRANSFER("Transfer");

        public const string name;
    }
}
