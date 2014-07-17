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
    public partial class PurchaseReportForm : Form
    {
        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeText(string newString) 
        {
            label1.Text = "Enjoy your " + newString + "!";
        }
    }
}
