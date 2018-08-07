namespace GC_MT_1
{
    partial class Form1
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
            this.menuSelect = new System.Windows.Forms.ComboBox();
            this.orderQuantity = new System.Windows.Forms.NumericUpDown();
            this.printMenu = new System.Windows.Forms.ListView();
            this.displayName = new System.Windows.Forms.Label();
            this.displayDesc = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.printReceipt = new System.Windows.Forms.ListView();
            this.Purchase = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSelect
            // 
            this.menuSelect.FormattingEnabled = true;
            this.menuSelect.Location = new System.Drawing.Point(348, 75);
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(165, 21);
            this.menuSelect.TabIndex = 1;
            this.menuSelect.SelectedIndexChanged += new System.EventHandler(this.menuSelect_SelectedIndexChanged);
            // 
            // orderQuantity
            // 
            this.orderQuantity.Location = new System.Drawing.Point(519, 75);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(40, 20);
            this.orderQuantity.TabIndex = 3;
            this.orderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.orderQuantity.ValueChanged += new System.EventHandler(this.orderQuantity_ValueChanged);
            // 
            // printMenu
            // 
            this.printMenu.Location = new System.Drawing.Point(13, 13);
            this.printMenu.Name = "printMenu";
            this.printMenu.Size = new System.Drawing.Size(329, 425);
            this.printMenu.TabIndex = 4;
            this.printMenu.UseCompatibleStateImageBehavior = false;
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Location = new System.Drawing.Point(348, 111);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(35, 13);
            this.displayName.TabIndex = 5;
            this.displayName.Text = "label1";
            this.displayName.Click += new System.EventHandler(this.displayName_Click);
            // 
            // displayDesc
            // 
            this.displayDesc.AutoSize = true;
            this.displayDesc.Location = new System.Drawing.Point(348, 136);
            this.displayDesc.Name = "displayDesc";
            this.displayDesc.Size = new System.Drawing.Size(35, 13);
            this.displayDesc.TabIndex = 7;
            this.displayDesc.Text = "label3";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(565, 78);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(35, 13);
            this.cost.TabIndex = 8;
            this.cost.Text = "label1";
            // 
            // printReceipt
            // 
            this.printReceipt.Location = new System.Drawing.Point(348, 204);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(276, 181);
            this.printReceipt.TabIndex = 9;
            this.printReceipt.UseCompatibleStateImageBehavior = false;
            this.printReceipt.SelectedIndexChanged += new System.EventHandler(this.printReceipt_SelectedIndexChanged);
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(607, 75);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(75, 23);
            this.Purchase.TabIndex = 10;
            this.Purchase.Text = "Purchase";
            this.Purchase.UseVisualStyleBackColor = true;
            this.Purchase.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(630, 204);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(75, 23);
            this.Checkout.TabIndex = 11;
            this.Checkout.Text = "button2";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.button2_Click);
            // 
            // subtotal
            // 
            this.subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(588, 392);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(35, 13);
            this.subtotal.TabIndex = 12;
            this.subtotal.Text = "label1";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(587, 409);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(35, 13);
            this.total.TabIndex = 13;
            this.total.Text = "label2";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.displayDesc);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.printMenu);
            this.Controls.Add(this.orderQuantity);
            this.Controls.Add(this.menuSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox menuSelect;
        private System.Windows.Forms.NumericUpDown orderQuantity;
        private System.Windows.Forms.ListView printMenu;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label displayDesc;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.ListView printReceipt;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label total;
    }
}

