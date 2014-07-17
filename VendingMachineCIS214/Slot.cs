using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Slot
    {
        private int quantity;
        private string productName;
        private double price;

        public Slot(int newQuantity, string newProductName, double newPrice) 
        {
            quantity = newQuantity;
            productName = newProductName;
            price = newPrice;
        }
        
        public int getQuantity() 
        {
            return quantity;
        }

        public string getProductName() 
        {
            return productName;
        }

        public double getPrice() 
        {
            return price;
        }

        public void decrementQuantity() 
        {
            quantity--;
        }

        public void refillStock() 
        {
            quantity = 10;
        }
    }
}
