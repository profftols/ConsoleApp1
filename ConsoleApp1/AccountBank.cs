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
    }
}
