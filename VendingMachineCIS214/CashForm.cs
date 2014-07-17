using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineCIS214
{
    public partial class CashForm : Form
    {
        private mainWindow mainWindow;
        private double currentTotal = 0;

        public CashForm()
        {
            InitializeComponent();
        }

        public CashForm(mainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public double getCashTotal() {
            return currentTotal;
        }

        private void displayAmount()
        {
            amountTextBox.Text = "$" + currentTotal.ToString("0.00");
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            currentTotal += .05;
            displayAmount();
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            currentTotal += .1;
            displayAmount();
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            currentTotal += .25;
            displayAmount();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            currentTotal += 1;
            displayAmount();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            currentTotal += 5;
            displayAmount();
        }

        private void cashDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
