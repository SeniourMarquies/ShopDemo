namespace ShopDemo
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
            this.storeItemslbl = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartListBoxlbl = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.VendorsListbox = new System.Windows.Forms.ListBox();
            this.VendorsListlbl = new System.Windows.Forms.Label();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeItemslbl
            // 
            this.storeItemslbl.AutoSize = true;
            this.storeItemslbl.Location = new System.Drawing.Point(39, 72);
            this.storeItemslbl.Name = "storeItemslbl";
            this.storeItemslbl.Size = new System.Drawing.Size(66, 15);
            this.storeItemslbl.TabIndex = 0;
            this.storeItemslbl.Text = "Store Items";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 15;
            this.ItemListBox.Location = new System.Drawing.Point(39, 110);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(170, 184);
            this.ItemListBox.TabIndex = 1;
            this.ItemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Location = new System.Drawing.Point(276, 180);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(75, 23);
            this.AddToCartBtn.TabIndex = 2;
            this.AddToCartBtn.Text = "Add ->";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(422, 110);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(170, 184);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // ShoppingCartListBoxlbl
            // 
            this.ShoppingCartListBoxlbl.AutoSize = true;
            this.ShoppingCartListBoxlbl.Location = new System.Drawing.Point(422, 72);
            this.ShoppingCartListBoxlbl.Name = "ShoppingCartListBoxlbl";
            this.ShoppingCartListBoxlbl.Size = new System.Drawing.Size(83, 15);
            this.ShoppingCartListBoxlbl.TabIndex = 3;
            this.ShoppingCartListBoxlbl.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(465, 320);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(75, 23);
            this.makePurchase.TabIndex = 5;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // VendorsListbox
            // 
            this.VendorsListbox.FormattingEnabled = true;
            this.VendorsListbox.ItemHeight = 15;
            this.VendorsListbox.Location = new System.Drawing.Point(39, 381);
            this.VendorsListbox.Name = "VendorsListbox";
            this.VendorsListbox.Size = new System.Drawing.Size(170, 184);
            this.VendorsListbox.TabIndex = 7;
            // 
            // VendorsListlbl
            // 
            this.VendorsListlbl.AutoSize = true;
            this.VendorsListlbl.Location = new System.Drawing.Point(39, 343);
            this.VendorsListlbl.Name = "VendorsListlbl";
            this.VendorsListlbl.Size = new System.Drawing.Size(70, 15);
            this.VendorsListlbl.TabIndex = 6;
            this.VendorsListlbl.Text = "Vendors List";
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Location = new System.Drawing.Point(397, 381);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(72, 15);
            this.StoreProfitLabel.TabIndex = 8;
            this.StoreProfitLabel.Text = "Store Profit: ";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Location = new System.Drawing.Point(475, 381);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(40, 15);
            this.StoreProfitValue.TabIndex = 9;
            this.StoreProfitValue.Text = "$0.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorsListbox);
            this.Controls.Add(this.VendorsListlbl);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.ShoppingCartListBoxlbl);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.storeItemslbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label storeItemslbl;
        private ListBox ItemListBox;
        private Button AddToCartBtn;
        private ListBox ShoppingCartListBox;
        private Label ShoppingCartListBoxlbl;
        private Button makePurchase;
        private ListBox VendorsListbox;
        private Label VendorsListlbl;
        private Label StoreProfitLabel;
        private Label StoreProfitValue;
    }
}