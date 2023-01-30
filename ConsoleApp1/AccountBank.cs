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
            Deposit = 1,
            Credit
        }

        static private long NumberCheck;
        private long BalanceD;
        private long BalanceC;
        private long NumLogin;

        public AccountBank(AccType acc)
        {
            switch (acc)
            {
                case AccType.Deposit: Console.WriteLine($"Баланс депозитного: {BalanceD}"); break;
                case AccType.Credit: Console.WriteLine($"Баланс кредитного: {BalanceC}"); break;
            }

            NumLogin = GenerateNum();
        }

        public AccountBank(long balanceD, long balanceC)
        {
            BalanceD = balanceD;
            BalanceC = balanceC;
            NumLogin = GenerateNum();
        }

        public AccountBank(long balanceD, long balanceC, AccType acc)
        {
            switch (acc)
            {
                case AccType.Deposit: Console.WriteLine($"Баланс депозитного: {BalanceD}"); break;
                case AccType.Credit: Console.WriteLine($"Баланс кредитного: {BalanceC}"); break;
            }

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
    }
}
