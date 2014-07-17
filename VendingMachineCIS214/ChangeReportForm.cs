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
    public partial class ChangeReportForm : Form
    {
        private double quarters;
        private double dimes;
        private double nickels;
        public ChangeReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeReportForm_Load(object sender, EventArgs e)
        {
            quartersLabel.Text = quarters.ToString("0") + " quarters";
            dimesLabel.Text = dimes.ToString("0") + " dimes";
            nickelsLabel.Text = nickels.ToString("0") + " nickels"; 
        }

        public void passChangeData(double changeQuarters, double changeDimes, double changeNickels) 
        {
            quarters = changeQuarters;
            dimes = changeDimes;
            nickels = changeNickels;
        }
    }
}
