namespace MachPro3
{
    partial class Form1
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
            PrevMostButton = new Button();
            PrevButton = new Button();
            NextButton = new Button();
            NextMostButton = new Button();
            AllItemsComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ProductNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            AvailableStocksTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            AddToCartButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            shoppingCartToolStripMenuItem = new ToolStripMenuItem();
            ordersStatusesToolStripMenuItem = new ToolStripMenuItem();
            ProductPictureBox = new PictureBox();
            QuantiOfProdToCartTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PrevMostButton
            // 
            PrevMostButton.Location = new Point(12, 43);
            PrevMostButton.Name = "PrevMostButton";
            PrevMostButton.Size = new Size(60, 32);
            PrevMostButton.TabIndex = 0;
            PrevMostButton.Text = "I<";
            PrevMostButton.UseVisualStyleBackColor = true;
            PrevMostButton.Click += PrevMostButton_Click;
            // 
            // PrevButton
            // 
            PrevButton.Location = new Point(78, 43);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(60, 32);
            PrevButton.TabIndex = 1;
            PrevButton.Text = "<";
            PrevButton.UseVisualStyleBackColor = true;
            PrevButton.Click += PrevButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(144, 43);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(60, 32);
            NextButton.TabIndex = 2;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // NextMostButton
            // 
            NextMostButton.Location = new Point(210, 43);
            NextMostButton.Name = "NextMostButton";
            NextMostButton.Size = new Size(60, 32);
            NextMostButton.TabIndex = 3;
            NextMostButton.Text = ">I";
            NextMostButton.UseVisualStyleBackColor = true;
            NextMostButton.Click += NextMostButton_Click;
            // 
            // AllItemsComboBox
            // 
            AllItemsComboBox.FormattingEnabled = true;
            AllItemsComboBox.Location = new Point(12, 81);
            AllItemsComboBox.Name = "AllItemsComboBox";
            AllItemsComboBox.Size = new Size(767, 23);
            AllItemsComboBox.TabIndex = 4;
            AllItemsComboBox.SelectedIndexChanged += AllItemsComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 125);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 212);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 154);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 183);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Available Stocks:";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(419, 122);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(360, 23);
            ProductNameTextBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(419, 151);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(169, 23);
            PriceTextBox.TabIndex = 10;
            // 
            // AvailableStocksTextBox
            // 
            AvailableStocksTextBox.Location = new Point(419, 180);
            AvailableStocksTextBox.Name = "AvailableStocksTextBox";
            AvailableStocksTextBox.Size = new Size(169, 23);
            AvailableStocksTextBox.TabIndex = 11;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(419, 209);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(360, 72);
            DescriptionTextBox.TabIndex = 12;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(637, 303);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(142, 50);
            AddToCartButton.TabIndex = 13;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(791, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shoppingCartToolStripMenuItem, ordersStatusesToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // shoppingCartToolStripMenuItem
            // 
            shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            shoppingCartToolStripMenuItem.Size = new Size(211, 22);
            shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            shoppingCartToolStripMenuItem.Click += shoppingCartToolStripMenuItem_Click;
            // 
            // ordersStatusesToolStripMenuItem
            // 
            ordersStatusesToolStripMenuItem.Name = "ordersStatusesToolStripMenuItem";
            ordersStatusesToolStripMenuItem.Size = new Size(211, 22);
            ordersStatusesToolStripMenuItem.Text = "Orders' Status and History";
            ordersStatusesToolStripMenuItem.Click += ordersStatusesToolStripMenuItem_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(11, 122);
            ProductPictureBox.Margin = new Padding(2);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(301, 210);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPictureBox.TabIndex = 15;
            ProductPictureBox.TabStop = false;
            // 
            // QuantiOfProdToCartTextBox
            // 
            QuantiOfProdToCartTextBox.Location = new Point(541, 318);
            QuantiOfProdToCartTextBox.Name = "QuantiOfProdToCartTextBox";
            QuantiOfProdToCartTextBox.Size = new Size(90, 23);
            QuantiOfProdToCartTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 321);
            label5.Name = "label5";
            label5.Size = new Size(189, 15);
            label5.TabIndex = 17;
            label5.Text = "Quantity of Product to add to cart:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 154);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 18;
            label6.Text = "P";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 373);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(QuantiOfProdToCartTextBox);
            Controls.Add(ProductPictureBox);
            Controls.Add(AddToCartButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(AvailableStocksTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AllItemsComboBox);
            Controls.Add(NextMostButton);
            Controls.Add(NextButton);
            Controls.Add(PrevButton);
            Controls.Add(PrevMostButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopper's Hub Product Browser";
            Activated += Form1_Activated;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrevMostButton;
        private Button PrevButton;
        private Button NextButton;
        private Button NextMostButton;
        private ComboBox AllItemsComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ProductNameTextBox;
        private TextBox PriceTextBox;
        private TextBox AvailableStocksTextBox;
        private TextBox DescriptionTextBox;
        private Button AddToCartButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem shoppingCartToolStripMenuItem;
        private ToolStripMenuItem ordersStatusesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox ProductPictureBox;
        private TextBox QuantiOfProdToCartTextBox;
        private Label label5;
        private Label label6;
    }
}
