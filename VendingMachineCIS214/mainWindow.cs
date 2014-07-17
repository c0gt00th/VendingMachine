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
    public partial class mainWindow : Form
    {
        VendingMachine VendingMachine = new VendingMachine();
        PurchaseReportForm PurchaseReportForm = new PurchaseReportForm();
        BalanceErrorForm BalanceErrorForm = new BalanceErrorForm();
        ChangeErrorForm ChangeErrorForm = new ChangeErrorForm();

        public mainWindow()
        {
            InitializeComponent();
        }

        // Opening Up Cash/Credit Form Windows

        private void useCashButton_Click(object sender, EventArgs e)
        {
            CashForm form2 = new CashForm();
            form2.ShowDialog();
            VendingMachine.increaseVendingBalance(form2.getCashTotal());
            updateTextBox();
            updateButtons();
        }

        private void useCreditButton_Click(object sender, EventArgs e)
        {
            CreditForm form2 = new CreditForm();
            form2.ShowDialog();
            VendingMachine.increaseVendingBalance(form2.getTransactionAmount());
            updateTextBox();
            updateButtons();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminForm form2 = new AdminForm();
            form2.ShowDialog();
            refillChangeButton.Visible = true;
            refillProductsButton.Visible = true;
            inventoryButton.Visible = true;
        }

        private void refillProductsButton_Click(object sender, EventArgs e)
        {
            VendingMachine.refillMachine();
            StockForm form2 = new StockForm();
            form2.ShowDialog();
        }

        private void refillChangeButton_Click(object sender, EventArgs e)
        {
            VendingMachine.refillChange();
            ChangeRefillForm form2 = new ChangeRefillForm();
            form2.ShowDialog();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm form2 = new InventoryForm();
            int[] productQuantities = VendingMachine.queryQuantity();
            form2.populateArray(productQuantities);
            form2.ShowDialog();
        }

        private void changeOutButton_Click(object sender, EventArgs e)
        {
            ChangeReportForm form2 = new ChangeReportForm();
            VendingMachine.makeChange();
            if (VendingMachine.checkSufficientChange())
            {
                form2.passChangeData(VendingMachine.getChangeQuarters(), VendingMachine.getChangeDimes(), VendingMachine.getChangeNickels());
                form2.ShowDialog();
                updateTextBox();
                resetAllRows();
            }

            else 
            { 
                ChangeErrorForm.ShowDialog();
            }
        }

        // Update mainWindow after payment method

        private void updateTextBox() {
            mainAmountTextBox.Text = "$" + VendingMachine.getVendingBalance().ToString("0.00");
        }

        private void updateButtons()
        {
            if (VendingMachine.getVendingBalance() >= .8 && VendingMachine.getVendingBalance() < 1)
            {
                updateOne();
            }

            else if (VendingMachine.getVendingBalance() >= 1 && VendingMachine.getVendingBalance() < 1.25)
            {
                updateTwo();
            }

            else if (VendingMachine.getVendingBalance() >= 1.25 && VendingMachine.getVendingBalance() < 1.5)
            {
                updateThree();
            }

            else if (VendingMachine.getVendingBalance() >= 1.5)
            {
                updateFour();
            }

            else
            {
                //Do nothing.
            }
        }

        private void updateOne() 
        {
            resetAllRows();
            if (A1Button.Enabled == true)
            {
                A1Button.Enabled = false;
                A2Button.Enabled = false;
                A3Button.Enabled = false;
                A4Button.Enabled = false;
                A5Button.Enabled = false;
            }

            else 
            {
                A1Button.Enabled = true;
                A2Button.Enabled = true;
                A3Button.Enabled = true;
                A4Button.Enabled = true;
                A5Button.Enabled = true;
            }
        }

        private void updateTwo()
        {
            resetAllRows();
            if (B1Button.Enabled == true)
            {
                A1Button.Enabled = false;
                A2Button.Enabled = false;
                A3Button.Enabled = false;
                A4Button.Enabled = false;
                A5Button.Enabled = false;
                B1Button.Enabled = false;
                B2Button.Enabled = false;
                B3Button.Enabled = false;
                B4Button.Enabled = false;
                B5Button.Enabled = false;
            }

            else
            {
                A1Button.Enabled = true;
                A2Button.Enabled = true;
                A3Button.Enabled = true;
                A4Button.Enabled = true;
                A5Button.Enabled = true;
                B1Button.Enabled = true;
                B2Button.Enabled = true;
                B3Button.Enabled = true;
                B4Button.Enabled = true;
                B5Button.Enabled = true;
            }
        }

        private void updateThree()
        {
            resetAllRows();
            if (C1Button.Enabled == true)
            {
                A1Button.Enabled = false;
                A2Button.Enabled = false;
                A3Button.Enabled = false;
                A4Button.Enabled = false;
                A5Button.Enabled = false;
                B1Button.Enabled = false;
                B2Button.Enabled = false;
                B3Button.Enabled = false;
                B4Button.Enabled = false;
                B5Button.Enabled = false;
                C1Button.Enabled = false;
                C2Button.Enabled = false;
                C3Button.Enabled = false;
                C4Button.Enabled = false;
                C5Button.Enabled = false;
            }

            else
            {
                A1Button.Enabled = true;
                A2Button.Enabled = true;
                A3Button.Enabled = true;
                A4Button.Enabled = true;
                A5Button.Enabled = true;
                B1Button.Enabled = true;
                B2Button.Enabled = true;
                B3Button.Enabled = true;
                B4Button.Enabled = true;
                B5Button.Enabled = true;
                C1Button.Enabled = true;
                C2Button.Enabled = true;
                C3Button.Enabled = true;
                C4Button.Enabled = true;
                C5Button.Enabled = true;
            }
        }

        private void updateFour()
        {
            resetAllRows();
            if (D1Button.Enabled == true)
            {
                A1Button.Enabled = false;
                A2Button.Enabled = false;
                A3Button.Enabled = false;
                A4Button.Enabled = false;
                A5Button.Enabled = false;
                B1Button.Enabled = false;
                B2Button.Enabled = false;
                B3Button.Enabled = false;
                B4Button.Enabled = false;
                B5Button.Enabled = false;
                C1Button.Enabled = false;
                C2Button.Enabled = false;
                C3Button.Enabled = false;
                C4Button.Enabled = false;
                C5Button.Enabled = false;
                D1Button.Enabled = false;
                D2Button.Enabled = false;
                D3Button.Enabled = false;
                D4Button.Enabled = false;
                D5Button.Enabled = false;
            }

            else
            {
                A1Button.Enabled = true;
                A2Button.Enabled = true;
                A3Button.Enabled = true;
                A4Button.Enabled = true;
                A5Button.Enabled = true;
                B1Button.Enabled = true;
                B2Button.Enabled = true;
                B3Button.Enabled = true;
                B4Button.Enabled = true;
                B5Button.Enabled = true;
                C1Button.Enabled = true;
                C2Button.Enabled = true;
                C3Button.Enabled = true;
                C4Button.Enabled = true;
                C5Button.Enabled = true;
                D1Button.Enabled = true;
                D2Button.Enabled = true;
                D3Button.Enabled = true;
                D4Button.Enabled = true;
                D5Button.Enabled = true;
            }
        }

        private void resetAllRows() 
        {
            A1Button.Enabled = false;
            A2Button.Enabled = false;
            A3Button.Enabled = false;
            A4Button.Enabled = false;
            A5Button.Enabled = false;
            B1Button.Enabled = false;
            B2Button.Enabled = false;
            B3Button.Enabled = false;
            B4Button.Enabled = false;
            B5Button.Enabled = false;
            C1Button.Enabled = false;
            C2Button.Enabled = false;
            C3Button.Enabled = false;
            C4Button.Enabled = false;
            C5Button.Enabled = false;
            D1Button.Enabled = false;
            D2Button.Enabled = false;
            D3Button.Enabled = false;
            D4Button.Enabled = false;
            D5Button.Enabled = false;
        }
        
        // Ordering Methods

        private void A1Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.A1))
            {
                VendingMachine.adjustQuantity(VendingMachine.A1);
                VendingMachine.purchaseBalanceChange(VendingMachine.A1);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.A1));
                PurchaseReportForm.ShowDialog();
            }

            else 
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void A2Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.A2))
            {
                VendingMachine.adjustQuantity(VendingMachine.A2);
                VendingMachine.purchaseBalanceChange(VendingMachine.A2);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.A2));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void A3Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.A3))
            {
                VendingMachine.adjustQuantity(VendingMachine.A3);
                VendingMachine.purchaseBalanceChange(VendingMachine.A3);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.A3));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void A4Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.A4))
            {
                VendingMachine.adjustQuantity(VendingMachine.A4);
                VendingMachine.purchaseBalanceChange(VendingMachine.A4);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.A4));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void A5Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.A5))
            {
                VendingMachine.adjustQuantity(VendingMachine.A5);
                VendingMachine.purchaseBalanceChange(VendingMachine.A5);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.A5));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void B1Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.B1))
            {
                VendingMachine.adjustQuantity(VendingMachine.B1);
                VendingMachine.purchaseBalanceChange(VendingMachine.B1);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.B1));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void B2Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.B2))
            {
                VendingMachine.adjustQuantity(VendingMachine.B2);
                VendingMachine.purchaseBalanceChange(VendingMachine.B2);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.B2));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void B3Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.B3))
            {
                VendingMachine.adjustQuantity(VendingMachine.B3);
                VendingMachine.purchaseBalanceChange(VendingMachine.B3);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.B3));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void B4Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.B4))
            {
                VendingMachine.adjustQuantity(VendingMachine.B4);
                VendingMachine.purchaseBalanceChange(VendingMachine.B4);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.B4));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void B5Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.B5))
            {
                VendingMachine.adjustQuantity(VendingMachine.B5);
                VendingMachine.purchaseBalanceChange(VendingMachine.B5);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.B5));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void C1Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.C1))
            {
                VendingMachine.adjustQuantity(VendingMachine.C1);
                VendingMachine.purchaseBalanceChange(VendingMachine.C1);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.C1));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void C2Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.C2))
            {
                VendingMachine.adjustQuantity(VendingMachine.C2);
                VendingMachine.purchaseBalanceChange(VendingMachine.C2);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.C2));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void C3Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.C3))
            {
                VendingMachine.adjustQuantity(VendingMachine.C3);
                VendingMachine.purchaseBalanceChange(VendingMachine.C3);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.C3));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void C4Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.C4))
            {
                VendingMachine.adjustQuantity(VendingMachine.C4);
                VendingMachine.purchaseBalanceChange(VendingMachine.C4);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.C4));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void C5Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.C5))
            {
                VendingMachine.adjustQuantity(VendingMachine.C5);
                VendingMachine.purchaseBalanceChange(VendingMachine.C5);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.C5));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void D1Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.D1))
            {
                VendingMachine.adjustQuantity(VendingMachine.D1);
                VendingMachine.purchaseBalanceChange(VendingMachine.D1);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.D1));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void D2Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.D2))
            {
                VendingMachine.adjustQuantity(VendingMachine.D2);
                VendingMachine.purchaseBalanceChange(VendingMachine.D2);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.D2));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void D3Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.D3))
            {
                VendingMachine.adjustQuantity(VendingMachine.D3);
                VendingMachine.purchaseBalanceChange(VendingMachine.D3);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.D3));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void D4Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.D4))
            {
                VendingMachine.adjustQuantity(VendingMachine.D4);
                VendingMachine.purchaseBalanceChange(VendingMachine.D4);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.D4));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }

        private void D5Button_Click(object sender, EventArgs e)
        {
            if (VendingMachine.checkSufficientFunds(VendingMachine.D5))
            {
                VendingMachine.adjustQuantity(VendingMachine.D5);
                VendingMachine.purchaseBalanceChange(VendingMachine.D5);
                updateTextBox();
                PurchaseReportForm.changeText(VendingMachine.retrieveProductName(VendingMachine.D5));
                PurchaseReportForm.ShowDialog();
            }

            else
            {
                BalanceErrorForm.ShowDialog();
            }
        }
    }
}
