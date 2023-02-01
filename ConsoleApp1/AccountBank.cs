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


        static private long NumberCheck;
        public long NumLogin;
        private long BalanceD;
        private long BalanceC;

        public AccountBank(long balanceD, long balanceC)
        {
            BalanceD = balanceD;
            BalanceC = balanceC;
            NumLogin = GenerateNum();
        }

        public static long GenerateNum()
        {
            Random genr = new Random();
            NumberCheck = genr.Next(9999999);
            return NumberCheck;

        }

        public void ReadBank()
        {
            Console.WriteLine($"\nНомер счета: {NumLogin}\n{AccType.Credit} баланс: {BalanceC}\n{AccType.Deposit} баланс: {BalanceD} ");
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
