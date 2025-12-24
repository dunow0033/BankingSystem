using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public class UserBankAccount
    {
        public UserBankAccount() { }

        [Key]
        public int BankAccountID { get; set; }
        //public int Id { get; set; }
        public String Username  { get; set; }

        public String Nickname { get; set; }

        public int TypeId { get; set; }

        public int? CurrencyId { get; set; }

        //public string StatusId { get; set; }
        public BankAccountTypeInfo type { get; set; }
        public BankAccountStatus status { get; set; }
        public int Balance { get; set; }
        //public CurrencyInfo currencyInfo {  get; set; }
        public int? WithdrawalLimit { get; set; }
        public DateTime CreatedAt { get; set; }


        //newAccount = new UserBankAccount(user.Username, nickName, bankAccountStatusType, balance, typeID, currencyID, null);

        public UserBankAccount(String username,
                                String nickname,
                                //int bankAccountID, 
                                //BankAccountTypeInfo type,
                                //CurrencyInfo currencyInfo,
                                BankAccountStatus status, 
                                int balance,
                                int typeID,
                                int? withdrawalLimit,
                                int? CurrencyId
                                //DateTime createdAt
            )
        {
            this.Username = username;
            this.Nickname = nickname;
            //this.bankAccountID = bankAccountID;
            //this.type = type;
            this.status = status;
            this.TypeId = typeID;
            this.Balance = balance;
            //this.currencyInfo = currencyInfo;
            this.WithdrawalLimit = withdrawalLimit;
            this.CurrencyId = CurrencyId;
            //this.createdAt = createdAt;
        }

        [NotMapped]
        public BankAccountTypeInfo TypeInfo
        {
            get => BankAccountTypeInfo.Info[(BankAccountType)(TypeId - 1)];
        }

        [NotMapped]
        public CurrencyInfo CurrencyInfo
        {
            get => CurrencyInfo.Info[(Currency)(CurrencyId)];
        }

        public override string ToString()
        {
            return "The nickname for this Account is (" + Nickname + ")\n" +
                "This bank account is of type (" + TypeInfo.Name + ")\n" +
                "The status of this bank account: (" + status + ")\n" +
                "The account's balance: (" + Balance + CurrencyInfo.Symbol + ")\n" +
                "The remaining withdrawal limit per month: (" + WithdrawalLimit + ")\n" +
                "This bank account is created at: (" + CreatedAt + ")\n";
        }
    }
}
