namespace GC_MT_1
{
    partial class Payment
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
            this.cash = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cashAmount = new System.Windows.Forms.NumericUpDown();
            this.pay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cashAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(12, 39);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(75, 23);
            this.cash.TabIndex = 0;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(12, 68);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(75, 23);
            this.credit.TabIndex = 1;
            this.credit.Text = "Credit/Debit";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 97);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a Payment Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cashAmount
            // 
            this.cashAmount.DecimalPlaces = 2;
            this.cashAmount.Location = new System.Drawing.Point(113, 43);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(160, 20);
            this.cashAmount.TabIndex = 4;
            this.cashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cashAmount.ThousandsSeparator = true;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(280, 43);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(36, 23);
            this.pay.TabIndex = 5;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.cashAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.cash);
            this.Name = "Payment";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cashAmount;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label label2;
    }
}