using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков
{
    class BankIzDz
    {

        protected int accountNumber = 1234567342;
        protected string password = "123321";
        enum BankType { current, savings }
        private BankType BankAccountType = BankType.current;
        public int AccountNumber
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return accountNumber;
                }
                else
                {
                    return 0;
                }
            }
        }
        protected int balance = 10000;

        public int Balance
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return balance;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return 0;
                }
            }

        }
        public void Print()
        {
            Console.Write("Введи пароль: ");
            if (Console.ReadLine() == password)
            {
                Console.Write($"номер счета {accountNumber} \nбаланс {balance} \nтип банковского счета {BankAccountType}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }

}
