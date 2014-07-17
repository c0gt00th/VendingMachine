namespace VendingMachineCIS214
{
    partial class AdminForm
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
            this.adminSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPINTextBox = new System.Windows.Forms.TextBox();
            this.adminErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminSubmitButton
            // 
            this.adminSubmitButton.Location = new System.Drawing.Point(12, 50);
            this.adminSubmitButton.Name = "adminSubmitButton";
            this.adminSubmitButton.Size = new System.Drawing.Size(137, 23);
            this.adminSubmitButton.TabIndex = 0;
            this.adminSubmitButton.Text = "Submit";
            this.adminSubmitButton.UseVisualStyleBackColor = true;
            this.adminSubmitButton.Click += new System.EventHandler(this.adminSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIN: ";
            // 
            // adminPINTextBox
            // 
            this.adminPINTextBox.Location = new System.Drawing.Point(49, 6);
            this.adminPINTextBox.Name = "adminPINTextBox";
            this.adminPINTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminPINTextBox.TabIndex = 2;
            // 
            // adminErrorLabel
            // 
            this.adminErrorLabel.AutoSize = true;
            this.adminErrorLabel.ForeColor = System.Drawing.Color.Tomato;
            this.adminErrorLabel.Location = new System.Drawing.Point(24, 32);
            this.adminErrorLabel.Name = "adminErrorLabel";
            this.adminErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.adminErrorLabel.TabIndex = 3;
            this.adminErrorLabel.Text = "ERROR: Incorrect Pin";
            this.adminErrorLabel.Visible = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 87);
            this.Controls.Add(this.adminErrorLabel);
            this.Controls.Add(this.adminPINTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminSubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminPINTextBox;
        private System.Windows.Forms.Label adminErrorLabel;
    }
}