using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{

    public static class BankBalance
    {
        private static double CreditBalance { get; set; }

        private static double DepositBalance { get; set; }

        private static bool BankStatus { get; set; }

        static BankBalance()
        {
            CreditBalance = 0;
            DepositBalance = 1000000000;
            BankStatus = true;
        }
        public static double GetCreditBalance() { return CreditBalance; }
        public static double GetDepositBalance() { return DepositBalance; }
        public static double SetCreditBalance(double creditBalance) 
        { 
           return CreditBalance += creditBalance;        
        }
        public static double SetDepositBalance(double deposititBalance)
        {
            return DepositBalance += deposititBalance;
        }
        public static bool BankStatusCheck(int credit)
        {
            if(DepositBalance - credit > CreditBalance) return BankStatus = true;
            else return BankStatus = false;
        }
        public static bool GetBankStatus() { return BankStatus; }
    }
}
