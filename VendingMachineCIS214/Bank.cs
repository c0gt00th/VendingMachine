using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Bank
    {
        private Account account1 = new Account(0001, "Sam", "Brogan", 1.00);
        private Account account2 = new Account(0002, "Devin", "Elterman", 0.85);
        private Account account3 = new Account(0003, "Kyle", "Loyd", 0.35);
        private Account account4 = new Account(0004, "Andre", "Mikkelsen", 1.85);
        private Account account5 = new Account(0005, "Gary", "Brogan", 1.10);
        private Account accountError = new Account(9999, "ERROR", "ERROR", 0.00);

        public double getBalance(int accountNumber) 
        {
            return queryAccounts(accountNumber).getBalance();
        }

        public string getFirstName(int accountNumber) 
        {
            return queryAccounts(accountNumber).getFirstName();
        }

        public string getLastName(int accountNumber) 
        {
            return queryAccounts(accountNumber).getLastName();
        }

        private Account queryAccounts(int id) 
        {
            if (id == 0001)
            {
                return account1;
            }

            else if (id == 0002)
            {
                return account2;
            }

            else if (id == 0003)
            {
                return account3;
            }

            else if (id == 0004)
            {
                return account4;
            }

            else if (id == 0005)
            {
                return account5;
            }

            else
            {
                return accountError;
            }
        }
    }
}
