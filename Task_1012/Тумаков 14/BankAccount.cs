using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task_1012
{

    internal class BankAccount2
    {
        /// <summary>
        /// тип аккаунта
        /// </summary>
        private AccountType accountType;
        internal AccountType AccountType { get { return accountType; } }
        static long numbers = 1000000000000;
        internal decimal money;
        /// <summary>
        /// номер аккаунта
        /// </summary>
        private long accountNumber;
        internal long AccountNumber { get { return accountNumber; } }
        public long Number()
        {
            Random rnd = new Random();
            accountType = (AccountType)rnd.Next(0,3);
            numbers++;
            accountNumber = numbers;
            return accountNumber;
        }
        public void Deposit(decimal amount)
        {
            money += amount;
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер аккаунта: <<{accountNumber}>>");
            Console.WriteLine($"Тип аккаунта: <<{accountType}>>");
            Console.WriteLine($"Деньги на счету: <<{money}>>");
        }

    }
}
