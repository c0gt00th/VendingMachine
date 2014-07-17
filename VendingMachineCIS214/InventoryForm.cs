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
    public partial class InventoryForm : Form
    {
        int[] inventoryArray = new int[20];
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            populateLabels(inventoryArray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void populateArray(int[] quantities) 
        { 
            inventoryArray[0] = quantities[0];
            inventoryArray[1] = quantities[1];
            inventoryArray[2] = quantities[2];
            inventoryArray[3] = quantities[3];
            inventoryArray[4] = quantities[4];
            inventoryArray[5] = quantities[5];
            inventoryArray[6] = quantities[6];
            inventoryArray[7] = quantities[7];
            inventoryArray[8] = quantities[8];
            inventoryArray[9] = quantities[9];
            inventoryArray[10] = quantities[10];
            inventoryArray[11] = quantities[11];
            inventoryArray[12] = quantities[12];
            inventoryArray[13] = quantities[13];
            inventoryArray[14] = quantities[14];
            inventoryArray[15] = quantities[15];
            inventoryArray[16] = quantities[16];
            inventoryArray[17] = quantities[17];
            inventoryArray[18] = quantities[18];
            inventoryArray[19] = quantities[19];
        }

        private void populateLabels(int[] quantities) 
        {
            A1Label.Text = quantities[0].ToString();
            A2Label.Text = quantities[1].ToString();
            A3Label.Text = quantities[2].ToString();
            A4Label.Text = quantities[3].ToString();
            A5Label.Text = quantities[4].ToString();
            B1Label.Text = quantities[5].ToString();
            B2Label.Text = quantities[6].ToString();
            B3Label.Text = quantities[7].ToString();
            B4Label.Text = quantities[8].ToString();
            B5Label.Text = quantities[9].ToString();
            C1Label.Text = quantities[10].ToString();
            C2Label.Text = quantities[11].ToString();
            C3Label.Text = quantities[12].ToString();
            C4Label.Text = quantities[13].ToString();
            C5Label.Text = quantities[14].ToString();
            D1Label.Text = quantities[15].ToString();
            D2Label.Text = quantities[16].ToString();
            D3Label.Text = quantities[17].ToString();
            D4Label.Text = quantities[18].ToString();
            D5Label.Text = quantities[19].ToString();
        }
    }
}
