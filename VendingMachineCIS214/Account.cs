using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Account
    {
        private int accountNumber;
        private string firstName;
        private string lastName;
        private double balance;

        public int getAccountNumber()
        {
            return accountNumber;
        }

        public string getFirstName() 
        {
            return firstName;
        }

        public string getLastName() 
        {
            return lastName;
        }

        public double getBalance() 
        {
            return balance;
        }

        public Account(int newAccountNumber, string newFirstName, string newLastName, double newBalance) 
        {
            accountNumber = newAccountNumber;
            firstName = newFirstName;
            lastName = newLastName;
            balance = newBalance;
        }
    }
}
