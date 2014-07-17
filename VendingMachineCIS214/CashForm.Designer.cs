namespace VendingMachineCIS214
{
    partial class CashForm
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
            this.nickelButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashDoneButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Press buttons to increment amount:";
            // 
            // nickelButton
            // 
            this.nickelButton.Location = new System.Drawing.Point(12, 69);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(79, 23);
            this.nickelButton.TabIndex = 2;
            this.nickelButton.Text = "Nickel $0.05";
            this.nickelButton.UseVisualStyleBackColor = true;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(50, 98);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(90, 23);
            this.quarterButton.TabIndex = 3;
            this.quarterButton.Text = "Quarter $0.25";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.Location = new System.Drawing.Point(97, 69);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(79, 23);
            this.dimeButton.TabIndex = 4;
            this.dimeButton.Text = "Dime $0.10";
            this.dimeButton.UseVisualStyleBackColor = true;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(12, 142);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(79, 23);
            this.oneButton.TabIndex = 5;
            this.oneButton.Text = "One $1.00";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(97, 142);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(79, 23);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "Five $5.00";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bills:";
            // 
            // cashDoneButton
            // 
            this.cashDoneButton.Location = new System.Drawing.Point(15, 185);
            this.cashDoneButton.Name = "cashDoneButton";
            this.cashDoneButton.Size = new System.Drawing.Size(161, 23);
            this.cashDoneButton.TabIndex = 9;
            this.cashDoneButton.Text = "Done";
            this.cashDoneButton.UseVisualStyleBackColor = true;
            this.cashDoneButton.Click += new System.EventHandler(this.cashDoneButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Enabled = false;
            this.amountTextBox.Location = new System.Drawing.Point(97, 6);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(79, 20);
            this.amountTextBox.TabIndex = 10;
            this.amountTextBox.Text = "$0.00";
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 220);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.cashDoneButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.dimeButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.nickelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cashDoneButton;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}