namespace WindowsFormsApp1
{
    partial class ConsignmentShopUI
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxTable = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(21, 35);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(246, 31);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            this.headerText.Click += new System.EventHandler(this.headerText_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 21;
            this.itemsListBox.Location = new System.Drawing.Point(27, 98);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(240, 172);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxTable
            // 
            this.itemsListBoxTable.AutoSize = true;
            this.itemsListBoxTable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxTable.Location = new System.Drawing.Point(33, 74);
            this.itemsListBoxTable.Name = "itemsListBoxTable";
            this.itemsListBoxTable.Size = new System.Drawing.Size(96, 21);
            this.itemsListBoxTable.TabIndex = 2;
            this.itemsListBoxTable.Text = "Store Items";
            this.itemsListBoxTable.Click += new System.EventHandler(this.label1_Click);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(334, 98);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(137, 35);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to cart->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListLabel
            // 
            this.shoppingCartListLabel.AutoSize = true;
            this.shoppingCartListLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListLabel.Location = new System.Drawing.Point(532, 74);
            this.shoppingCartListLabel.Name = "shoppingCartListLabel";
            this.shoppingCartListLabel.Size = new System.Drawing.Size(119, 21);
            this.shoppingCartListLabel.TabIndex = 5;
            this.shoppingCartListLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 21;
            this.shoppingCartListBox.Location = new System.Drawing.Point(526, 98);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(240, 172);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(526, 276);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(105, 35);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.Location = new System.Drawing.Point(33, 313);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(96, 21);
            this.vendorListBoxLabel.TabIndex = 8;
            this.vendorListBoxLabel.Text = "Vendor List";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 21;
            this.vendorListBox.Location = new System.Drawing.Point(27, 337);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(240, 172);
            this.vendorListBox.TabIndex = 7;
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePayoutLabel.Location = new System.Drawing.Point(522, 337);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(101, 21);
            this.storePayoutLabel.TabIndex = 9;
            this.storePayoutLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(669, 337);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(50, 21);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 539);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxTable);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShopUI";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShopUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxTable;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

