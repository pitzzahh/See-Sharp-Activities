namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Item = new TextBox();
            Discount = new TextBox();
            label3 = new Label();
            Price = new TextBox();
            label4 = new Label();
            Quantity = new TextBox();
            ComputeBtn = new Button();
            label5 = new Label();
            TotalAmount = new Label();
            Payment = new TextBox();
            label6 = new Label();
            SubmitBtn = new Button();
            label7 = new Label();
            Change = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 22);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Discount (%):";
            // 
            // Item
            // 
            Item.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Item.Location = new Point(27, 45);
            Item.Name = "Item";
            Item.Size = new Size(218, 27);
            Item.TabIndex = 2;
            // 
            // Discount
            // 
            Discount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Discount.Location = new Point(251, 45);
            Discount.Name = "Discount";
            Discount.Size = new Size(131, 27);
            Discount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 79);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // Price
            // 
            Price.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(77, 76);
            Price.Name = "Price";
            Price.Size = new Size(168, 27);
            Price.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 79);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.Location = new Point(316, 76);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(66, 27);
            Quantity.TabIndex = 7;
            // 
            // ComputeBtn
            // 
            ComputeBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ComputeBtn.Location = new Point(156, 118);
            ComputeBtn.Name = "ComputeBtn";
            ComputeBtn.Size = new Size(80, 35);
            ComputeBtn.TabIndex = 8;
            ComputeBtn.Text = "Compute";
            ComputeBtn.UseVisualStyleBackColor = true;
            ComputeBtn.Click += ComputeBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 177);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Total amount:";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmount.Location = new Point(183, 177);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(0, 20);
            TotalAmount.TabIndex = 10;
            // 
            // Payment
            // 
            Payment.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Payment.Location = new Point(156, 224);
            Payment.Name = "Payment";
            Payment.Size = new Size(124, 27);
            Payment.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 227);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 11;
            label6.Text = "Payment received:";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitBtn.Location = new Point(302, 216);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(80, 35);
            SubmitBtn.TabIndex = 13;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(99, 270);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 14;
            label7.Text = "Change:";
            // 
            // Change
            // 
            Change.AutoSize = true;
            Change.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(167, 270);
            Change.Name = "Change";
            Change.Size = new Size(0, 20);
            Change.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(394, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(180, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 313);
            Controls.Add(Change);
            Controls.Add(label7);
            Controls.Add(SubmitBtn);
            Controls.Add(Payment);
            Controls.Add(label6);
            Controls.Add(TotalAmount);
            Controls.Add(label5);
            Controls.Add(ComputeBtn);
            Controls.Add(Quantity);
            Controls.Add(label4);
            Controls.Add(Price);
            Controls.Add(label3);
            Controls.Add(Discount);
            Controls.Add(Item);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Discount Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Item;
        private TextBox Discount;
        private Label label3;
        private TextBox Price;
        private Label label4;
        private TextBox Quantity;
        private Button ComputeBtn;
        private Label label5;
        private Label TotalAmount;
        private TextBox Payment;
        private Label label6;
        private Button SubmitBtn;
        private Label label7;
        private Label Change;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}