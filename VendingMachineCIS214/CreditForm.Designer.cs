namespace VendingMachineCIS214
{
    partial class CreditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creditAmountTextBox = new System.Windows.Forms.TextBox();
            this.cardNoTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.doneCreditButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Last 4 of Card #: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the amount: ";
            // 
            // creditAmountTextBox
            // 
            this.creditAmountTextBox.Location = new System.Drawing.Point(134, 30);
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.Size = new System.Drawing.Size(58, 20);
            this.creditAmountTextBox.TabIndex = 2;
            this.creditAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cardNoTextBox
            // 
            this.cardNoTextBox.Location = new System.Drawing.Point(134, 6);
            this.cardNoTextBox.Name = "cardNoTextBox";
            this.cardNoTextBox.Size = new System.Drawing.Size(58, 20);
            this.cardNoTextBox.TabIndex = 1;
            this.cardNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(13, 126);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(91, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check Balance";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // doneCreditButton
            // 
            this.doneCreditButton.Enabled = false;
            this.doneCreditButton.Location = new System.Drawing.Point(110, 126);
            this.doneCreditButton.Name = "doneCreditButton";
            this.doneCreditButton.Size = new System.Drawing.Size(82, 23);
            this.doneCreditButton.TabIndex = 6;
            this.doneCreditButton.Text = "Done";
            this.doneCreditButton.UseVisualStyleBackColor = true;
            this.doneCreditButton.Click += new System.EventHandler(this.doneCreditButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(78, 55);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(78, 79);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Tomato;
            this.errorLabel.Location = new System.Drawing.Point(37, 107);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(135, 13);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "ERROR: Insufficient Funds";
            this.errorLabel.Visible = false;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.successLabel.Location = new System.Drawing.Point(37, 107);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(139, 13);
            this.successLabel.TabIndex = 10;
            this.successLabel.Text = "SUCCESS: Sufficient Funds";
            this.successLabel.Visible = false;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 159);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doneCreditButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.cardNoTextBox);
            this.Controls.Add(this.creditAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditAmountTextBox;
        private System.Windows.Forms.TextBox cardNoTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button doneCreditButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label successLabel;
    }
}