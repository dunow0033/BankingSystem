using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Application.com.bank.model
{
    public enum Currency
    {
        Dollar,
        Euro,
        JapaneseYen,
        GreatBritishPound
    }

    public class CurrencyInfo
    {
        public string Type { get; set; }
        public char Symbol { get; set; }

        public static readonly Dictionary<Currency, CurrencyInfo> Info =
            new ()
            {
                { Currency.Dollar, new CurrencyInfo ("Dollar", '$') },
                { Currency.Euro, new CurrencyInfo("Euro", '€') },
                { Currency.JapaneseYen, new CurrencyInfo("Japanese yen", '¥') },
                { Currency.GreatBritishPound, new CurrencyInfo ("Great British Pound", '£') }
            };

        CurrencyInfo(string type, char symbol)
        {
            Type = type;
            Symbol = symbol;
        }

        public static void showAll()
        {
            BankUtil.createMessage("There are 4 types of currencies");
            Console.WriteLine($"1. {Currency.Dollar} ");
            Console.WriteLine($"2. {Currency.Euro} ");
            Console.WriteLine($"3. {Currency.JapaneseYen} ");
            Console.WriteLine($"4. {Currency.GreatBritishPound}");
        }

        public static Currency typeInIndex(int? index)
        {
            return (Currency)index;
        }

        public static CurrencyInfo FromType(Currency currency)
        {
            return Info[currency];
        }
    }

    public static class CurrencyExtensions
    {
        public static string ToDisplayString(this Currency currency)
        {
            int indexPlusOne = (int)currency + 1;
            CurrencyInfo info = CurrencyInfo.Info[currency];

            return $"{indexPlusOne} - {info.Type} ({info.Symbol})";
        }
    }
}
