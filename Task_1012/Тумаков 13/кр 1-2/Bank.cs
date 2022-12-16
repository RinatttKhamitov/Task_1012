using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_1012
{
    internal class Bank
    {
        public BankAccount this[long accountNumber]
        {
            get
            {
                return (BankAccount)accounts[accountNumber];
            }
        }
        internal BankAccount CreateAccount()
        {
            BankAccount opened = new BankAccount();
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
