namespace MachPro3
{
    partial class ShoppingCart
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
            AllItemsInCartDataGridView = new DataGridView();
            label1 = new Label();
            CartQuantiOfSelectItemTextBox = new TextBox();
            AddToSelectButton = new Button();
            UpdateQuantiButton = new Button();
            RemoveInCartButton = new Button();
            label2 = new Label();
            TotalCartItemPriceTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CheckOutAllButton = new Button();
            SelectiveCheckoutListBox = new ListBox();
            CheckOutSelectItemsButton = new Button();
            TotalSelectPriceTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)AllItemsInCartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AllItemsInCartDataGridView
            // 
            AllItemsInCartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllItemsInCartDataGridView.Location = new Point(24, 29);
            AllItemsInCartDataGridView.Name = "AllItemsInCartDataGridView";
            AllItemsInCartDataGridView.Size = new Size(429, 150);
            AllItemsInCartDataGridView.TabIndex = 0;
            AllItemsInCartDataGridView.SelectionChanged += AllItemsInCartDataGridView_SelectionChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Quantity: ";
            // 
            // CartQuantiOfSelectItemTextBox
            // 
            CartQuantiOfSelectItemTextBox.Location = new Point(536, 36);
            CartQuantiOfSelectItemTextBox.Name = "CartQuantiOfSelectItemTextBox";
            CartQuantiOfSelectItemTextBox.Size = new Size(90, 23);
            CartQuantiOfSelectItemTextBox.TabIndex = 2;
            CartQuantiOfSelectItemTextBox.Enter += CartQuantiOfSelectItemTextBox_Enter;
            // 
            // AddToSelectButton
            // 
            AddToSelectButton.Location = new Point(471, 76);
            AddToSelectButton.Name = "AddToSelectButton";
            AddToSelectButton.Size = new Size(97, 54);
            AddToSelectButton.TabIndex = 3;
            AddToSelectButton.Text = "Add to Selective Checkout";
            AddToSelectButton.UseVisualStyleBackColor = true;
            AddToSelectButton.Click += AddToSelectButton_Click;
            // 
            // UpdateQuantiButton
            // 
            UpdateQuantiButton.Location = new Point(647, 35);
            UpdateQuantiButton.Name = "UpdateQuantiButton";
            UpdateQuantiButton.Size = new Size(127, 24);
            UpdateQuantiButton.TabIndex = 4;
            UpdateQuantiButton.Text = "Update Quantity";
            UpdateQuantiButton.UseVisualStyleBackColor = true;
            UpdateQuantiButton.Click += UpdateQuantiButton_Click;
            // 
            // RemoveInCartButton
            // 
            RemoveInCartButton.Location = new Point(574, 76);
            RemoveInCartButton.Name = "RemoveInCartButton";
            RemoveInCartButton.Size = new Size(97, 54);
            RemoveInCartButton.TabIndex = 5;
            RemoveInCartButton.Text = "Remove";
            RemoveInCartButton.UseVisualStyleBackColor = true;
            RemoveInCartButton.Click += RemoveInCartButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 154);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 6;
            label2.Text = "Total Price of Items in Cart: ";
            // 
            // TotalCartItemPriceTextBox
            // 
            TotalCartItemPriceTextBox.Location = new Point(647, 151);
            TotalCartItemPriceTextBox.Name = "TotalCartItemPriceTextBox";
            TotalCartItemPriceTextBox.Size = new Size(127, 23);
            TotalCartItemPriceTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 11);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 8;
            label3.Text = "All Items in Shopping Cart";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 195);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 9;
            label4.Text = "Selective Checkout";
            // 
            // CheckOutAllButton
            // 
            CheckOutAllButton.Location = new Point(677, 76);
            CheckOutAllButton.Name = "CheckOutAllButton";
            CheckOutAllButton.Size = new Size(97, 54);
            CheckOutAllButton.TabIndex = 10;
            CheckOutAllButton.Text = "Checkout All Items";
            CheckOutAllButton.UseVisualStyleBackColor = true;
            CheckOutAllButton.Click += CheckOutAllButton_Click;
            // 
            // SelectiveCheckoutListBox
            // 
            SelectiveCheckoutListBox.FormattingEnabled = true;
            SelectiveCheckoutListBox.ItemHeight = 15;
            SelectiveCheckoutListBox.Location = new Point(24, 213);
            SelectiveCheckoutListBox.Name = "SelectiveCheckoutListBox";
            SelectiveCheckoutListBox.Size = new Size(429, 139);
            SelectiveCheckoutListBox.TabIndex = 11;
            // 
            // CheckOutSelectItemsButton
            // 
            CheckOutSelectItemsButton.Location = new Point(471, 261);
            CheckOutSelectItemsButton.Name = "CheckOutSelectItemsButton";
            CheckOutSelectItemsButton.Size = new Size(97, 43);
            CheckOutSelectItemsButton.TabIndex = 12;
            CheckOutSelectItemsButton.Text = "Checkout Selected Items";
            CheckOutSelectItemsButton.UseVisualStyleBackColor = true;
            CheckOutSelectItemsButton.Click += CheckOutSelectItemsButton_Click;
            // 
            // TotalSelectPriceTextBox
            // 
            TotalSelectPriceTextBox.Location = new Point(647, 227);
            TotalSelectPriceTextBox.Name = "TotalSelectPriceTextBox";
            TotalSelectPriceTextBox.Size = new Size(127, 23);
            TotalSelectPriceTextBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 230);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 13;
            label5.Text = "Total Price of Selected Items: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 230);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 15;
            label6.Text = "P";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 154);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 16;
            label7.Text = "P";
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TotalSelectPriceTextBox);
            Controls.Add(label5);
            Controls.Add(CheckOutSelectItemsButton);
            Controls.Add(SelectiveCheckoutListBox);
            Controls.Add(CheckOutAllButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TotalCartItemPriceTextBox);
            Controls.Add(label2);
            Controls.Add(RemoveInCartButton);
            Controls.Add(UpdateQuantiButton);
            Controls.Add(AddToSelectButton);
            Controls.Add(CartQuantiOfSelectItemTextBox);
            Controls.Add(label1);
            Controls.Add(AllItemsInCartDataGridView);
            Name = "ShoppingCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping Cart";
            FormClosed += ShoppingCart_FormClosed;
            Load += ShoppingCart_Load;
            ((System.ComponentModel.ISupportInitialize)AllItemsInCartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AllItemsInCartDataGridView;
        private Label label1;
        private TextBox CartQuantiOfSelectItemTextBox;
        private Button AddToSelectButton;
        private Button UpdateQuantiButton;
        private Button RemoveInCartButton;
        private Label label2;
        private TextBox TotalCartItemPriceTextBox;
        private Label label3;
        private Label label4;
        private Button CheckOutAllButton;
        private ListBox SelectiveCheckoutListBox;
        private Button CheckOutSelectItemsButton;
        private TextBox TotalSelectPriceTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}