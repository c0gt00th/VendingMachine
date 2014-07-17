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
    public partial class CreditForm : Form
    {
        private Bank Bank = new Bank();
        private double transactionAmount;

        public CreditForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            successLabel.Visible = false;
            double balance = Bank.getBalance(int.Parse(cardNoTextBox.Text));
            if (balance < double.Parse(creditAmountTextBox.Text))
            {
                errorLabel.Visible = true;
            }

            else 
            {
                successLabel.Visible = true;
                doneCreditButton.Enabled = true;
                firstNameTextBox.Text = Bank.getFirstName(int.Parse(cardNoTextBox.Text));
                lastNameTextBox.Text = Bank.getLastName(int.Parse(cardNoTextBox.Text));
            }
        }

        private void doneCreditButton_Click(object sender, EventArgs e)
        {
            transactionAmount = double.Parse(creditAmountTextBox.Text);
            this.Close();
        }

        public double getTransactionAmount() 
        {
            return transactionAmount;
        }
    }
}
