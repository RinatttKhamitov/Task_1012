using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_1012
{
    internal class Bank2
    {
        public BankAccount this[long accountNumber]
        {
            get
            {
                return (BankAccount)accounts[accountNumber];
            }
        }
        internal BankAccount2 CreateAccount()
        {
            BankAccount2 opened = new BankAccount2();
            accounts[opened.Number()] = opened;
            return opened;
        }
        internal void DeleteAccount(int number)
        {
            accounts.Remove(number);
        }
        public Hashtable accounts = new Hashtable();
    }
}
