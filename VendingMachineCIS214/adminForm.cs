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
    public partial class AdminForm : Form
    {
        private bool adminEnabled = false;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void adminSubmitButton_Click(object sender, EventArgs e)
        {
            if (adminPINTextBox.Text == "1234")
            {
                adminEnabled = true;
                this.Close();
            }

            else 
            {
                adminErrorLabel.Visible = true;
                adminPINTextBox.Text = "";
            }
        }

        public bool getAdminBool() 
        {
            return adminEnabled;
        }
    }
}
