using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class VendingMachine
    {
        private double quarters = 40;
        private double dimes = 100;
        private double nickels = 200;

        private double changeQuarters;
        private double changeDimes;
        private double changeNickels;

        private double currentVendingBalance = 0;

        public Slot A1 = new Slot(10, "Big Red", .8);
        public Slot A2 = new Slot(10, "Double Mint", .8);
        public Slot A3 = new Slot(10, "Fruit Stripe", .8);
        public Slot A4 = new Slot(10, "Lifesavers", .8);
        public Slot A5 = new Slot(10, "Juicy Fruit", .8);

        public Slot B1 = new Slot(10, "Crunch", 1);
        public Slot B2 = new Slot(10, "Hershey's", 1);
        public Slot B3 = new Slot(10, "Milky Way", 1);
        public Slot B4 = new Slot(10, "Snickers", 1);
        public Slot B5 = new Slot(10, "Three Musketeers", 1);

        public Slot C1 = new Slot(10, "Fritos", 1.25);
        public Slot C2 = new Slot(10, "Doritos: Cool Ranch", 1.25);
        public Slot C3 = new Slot(10, "Lays", 1.25);
        public Slot C4 = new Slot(10, "Flamin' Hot Cheetos", 1.25);
        public Slot C5 = new Slot(10, "Doritos: Nacho Cheese", 1.25);

        public Slot D1 = new Slot(10, "Coffee Cake", 1.5);
        public Slot D2 = new Slot(10, "Cupcakes", 1.5);
        public Slot D3 = new Slot(10, "Fruit Pie", 1.5);
        public Slot D4 = new Slot(10, "Honey Bun", 1.5);
        public Slot D5 = new Slot(10, "Swiss Cake Roll", 1.5);

        QuantityErrorForm form2 = new QuantityErrorForm();

        public void adjustQuantity(Slot slot) 
        {
            if (slot.getQuantity() > 0)
            {
                slot.decrementQuantity();
            }

            else 
            {
                form2.ShowDialog();
            }
        }

        public void refillMachine() 
        {
            A1.refillStock();
            A2.refillStock();
            A3.refillStock();
            A4.refillStock();
            A5.refillStock();
            B1.refillStock();
            B2.refillStock();
            B3.refillStock();
            B4.refillStock();
            B5.refillStock();
            C1.refillStock();
            C2.refillStock();
            C3.refillStock();
            C4.refillStock();
            D5.refillStock();
            D1.refillStock();
            D2.refillStock();
            D3.refillStock();
            D4.refillStock();
            D5.refillStock();
        }

        public int[] queryQuantity()
        {
            int[] quantities = new int[20];
            quantities[0] = A1.getQuantity();
            quantities[1] = A2.getQuantity();
            quantities[2] = A3.getQuantity();
            quantities[3] = A4.getQuantity();
            quantities[4] = A5.getQuantity();
            quantities[5] = B1.getQuantity();
            quantities[6] = B2.getQuantity();
            quantities[7] = B3.getQuantity();
            quantities[8] = B4.getQuantity();
            quantities[9] = B5.getQuantity();
            quantities[10] = C1.getQuantity();
            quantities[11] = C2.getQuantity();
            quantities[12] = C3.getQuantity();
            quantities[13] = C4.getQuantity();
            quantities[14] = D5.getQuantity();
            quantities[15] = D1.getQuantity();
            quantities[16] = D2.getQuantity();
            quantities[17] = D3.getQuantity();
            quantities[18] = D4.getQuantity();
            quantities[19] = D5.getQuantity();

            return quantities;
        }

        public void refillChange() 
        { 
            quarters = 40;
            dimes = 100;
            nickels = 200;
        }

        public void increaseVendingBalance(double amount) 
        {
            currentVendingBalance += amount;
        }

        private void decreaseVendingBalance(double amount) 
        {
            currentVendingBalance -= amount;
        }

        public double getVendingBalance() 
        {
            return currentVendingBalance;
        }

        public void purchaseBalanceChange(Slot slot) 
        {
            decreaseVendingBalance(slot.getPrice());
        }

        public double getChangeQuarters() 
        {
            return changeQuarters;
        }

        public double getChangeDimes() 
        {
            return changeDimes;
        }

        public double getChangeNickels() 
        {
            return changeNickels;
        }

        public void makeChange() 
        {
            changeQuarters = Math.Truncate(currentVendingBalance / .25);
            currentVendingBalance -= changeQuarters * .25;
            changeDimes = Math.Truncate(currentVendingBalance / .1);
            currentVendingBalance -= changeDimes * .10;
            changeNickels = currentVendingBalance / .05;
            currentVendingBalance -= changeNickels * .05;
        }

        public bool checkSufficientChange() 
        {
            if (quarters > changeQuarters && dimes > changeDimes && nickels > changeNickels)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }

        public string retrieveProductName(Slot slot) 
        {
            return slot.getProductName();
        }

        public bool checkSufficientFunds(Slot slot) 
        {
            if (currentVendingBalance - slot.getPrice() >= 0)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }
    }
}
