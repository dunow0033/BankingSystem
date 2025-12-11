using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public enum BankAccountStatus
    {
        Closed = 0,
        Active = 1,
        Pending = 2
    }

    //public const String name;

    public class BankAccountStatusUtils
    {
        private String name;

        BankAccountStatusUtils(String name)
        {
            this.name = name;
        }

        public static BankAccountStatus TypeInIndex(int index)
        {
            return (BankAccountStatus)index;
        }

        public override string ToString()
        {
            return name;
        }
    }

}
