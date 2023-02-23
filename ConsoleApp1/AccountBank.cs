using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    class AccountBank
    {
        public enum AccType
        {
            Deposit,
            Credit
        }

        public int a;


        static private long numberCheck;
        public long NumberCheck
        {
            get;
            private set;
        }
        private long BalanceD;
        private long BalanceC;

        public AccountBank(long balanceD, long balanceC)
        {
            BalanceD = balanceD;
            BalanceC = balanceC;
            NumberCheck = GenerateNum();
        }

        public static long GenerateNum()
        {
            Random genr = new Random();
            numberCheck = genr.Next(9999999);
            return numberCheck;

        }

        public void ReadBank()
        {
            Console.WriteLine($"\nНомер счета: {NumberCheck}\n{AccType.Credit} баланс: {BalanceC}\n{AccType.Deposit} баланс: {BalanceD} ");
        }

        public void Transaction(AccountBank accountBank, long sum)
        {
            if (accountBank.BalanceD >= sum)
            {
                accountBank.BalanceD -= sum;
                BalanceD += sum;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для транзакции.");
            }
        }

        public string RetString(string text)
        {
            char[] chars = text.ToCharArray();
            text = null;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                text += $"{chars[i]}";
            }
            return text;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as AccountBank);
        }
         
        public bool Equals(AccountBank other)
        {
            return other != null &&
                    BalanceC == other.BalanceC &&
                    BalanceD == other.BalanceD;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        /*
        public static bool operator ==(AccountBank a, AccountBank b)
        {
            return (a.BalanceC == b.BalanceC && a.BalanceD == b.BalanceD);
        }

        public static bool operator !=(AccountBank a, AccountBank b)
        {
            return (a.BalanceD != b.BalanceD || a.BalanceC != b.BalanceC);
        }

        public bool Equals(AccountBank check)
        {
            if (BalanceD == check.BalanceD && BalanceC == check.BalanceC)
                return true;
            else
                return false;
        }
        */
    }
}
