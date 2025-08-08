namespace MachPro3
{
    partial class Admin
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
            AdminChangeStatusOrderDataGridView = new DataGridView();
            label1 = new Label();
            ChangeOrderStatTextBox = new TextBox();
            UpdateStatusButton = new Button();
            MarkDeliveredButton = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            AdminModifyDataGridView = new DataGridView();
            AdminDescriptionTextBox = new TextBox();
            AdminAvailableStocksTextBox = new TextBox();
            AdminPriceTextBox = new TextBox();
            AdminProductNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            AdminAddNewProdButton = new Button();
            AdminDelProdButton = new Button();
            AdminUpdateProdButton = new Button();
            groupBox2 = new GroupBox();
            AdminProductPictureBox = new PictureBox();
            GenerateReportsButton = new Button();
            ReturnToMainButton = new Button();
            ImageURLTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ClearAllDetailsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AdminChangeStatusOrderDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminModifyDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminProductPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AdminChangeStatusOrderDataGridView
            // 
            AdminChangeStatusOrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminChangeStatusOrderDataGridView.Location = new Point(13, 26);
            AdminChangeStatusOrderDataGridView.Name = "AdminChangeStatusOrderDataGridView";
            AdminChangeStatusOrderDataGridView.Size = new Size(362, 150);
            AdminChangeStatusOrderDataGridView.TabIndex = 0;
            AdminChangeStatusOrderDataGridView.SelectionChanged += AdminChangeStatusOrderDataGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 40);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Change Order Status:";
            // 
            // ChangeOrderStatTextBox
            // 
            ChangeOrderStatTextBox.Location = new Point(517, 37);
            ChangeOrderStatTextBox.Name = "ChangeOrderStatTextBox";
            ChangeOrderStatTextBox.Size = new Size(233, 23);
            ChangeOrderStatTextBox.TabIndex = 2;
            // 
            // UpdateStatusButton
            // 
            UpdateStatusButton.Location = new Point(621, 66);
            UpdateStatusButton.Name = "UpdateStatusButton";
            UpdateStatusButton.Size = new Size(129, 37);
            UpdateStatusButton.TabIndex = 3;
            UpdateStatusButton.Text = "Update Status";
            UpdateStatusButton.UseVisualStyleBackColor = true;
            UpdateStatusButton.Click += UpdateStatusButton_Click;
            // 
            // MarkDeliveredButton
            // 
            MarkDeliveredButton.Location = new Point(392, 129);
            MarkDeliveredButton.Name = "MarkDeliveredButton";
            MarkDeliveredButton.Size = new Size(156, 37);
            MarkDeliveredButton.TabIndex = 4;
            MarkDeliveredButton.Text = "Mark Order as Delivered";
            MarkDeliveredButton.UseVisualStyleBackColor = true;
            MarkDeliveredButton.Click += MarkDeliveredButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 111);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Deliver item:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MarkDeliveredButton);
            groupBox1.Controls.Add(UpdateStatusButton);
            groupBox1.Controls.Add(ChangeOrderStatTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AdminChangeStatusOrderDataGridView);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 201);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Status of Orders";
            // 
            // AdminModifyDataGridView
            // 
            AdminModifyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminModifyDataGridView.Location = new Point(13, 33);
            AdminModifyDataGridView.Name = "AdminModifyDataGridView";
            AdminModifyDataGridView.Size = new Size(398, 219);
            AdminModifyDataGridView.TabIndex = 6;
            AdminModifyDataGridView.SelectionChanged += AdminModifyDataGridView_SelectionChanged;
            // 
            // AdminDescriptionTextBox
            // 
            AdminDescriptionTextBox.Location = new Point(190, 494);
            AdminDescriptionTextBox.Multiline = true;
            AdminDescriptionTextBox.Name = "AdminDescriptionTextBox";
            AdminDescriptionTextBox.Size = new Size(228, 72);
            AdminDescriptionTextBox.TabIndex = 20;
            // 
            // AdminAvailableStocksTextBox
            // 
            AdminAvailableStocksTextBox.Location = new Point(530, 552);
            AdminAvailableStocksTextBox.Name = "AdminAvailableStocksTextBox";
            AdminAvailableStocksTextBox.Size = new Size(112, 23);
            AdminAvailableStocksTextBox.TabIndex = 19;
            // 
            // AdminPriceTextBox
            // 
            AdminPriceTextBox.Location = new Point(530, 523);
            AdminPriceTextBox.Name = "AdminPriceTextBox";
            AdminPriceTextBox.Size = new Size(112, 23);
            AdminPriceTextBox.TabIndex = 18;
            // 
            // AdminProductNameTextBox
            // 
            AdminProductNameTextBox.Location = new Point(530, 494);
            AdminProductNameTextBox.Name = "AdminProductNameTextBox";
            AdminProductNameTextBox.Size = new Size(228, 23);
            AdminProductNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 555);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 16;
            label4.Text = "Available Stocks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 526);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 15;
            label3.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 497);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 14;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 497);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 13;
            label6.Text = "Product Name:";
            // 
            // AdminAddNewProdButton
            // 
            AdminAddNewProdButton.Location = new Point(429, 626);
            AdminAddNewProdButton.Name = "AdminAddNewProdButton";
            AdminAddNewProdButton.Size = new Size(98, 43);
            AdminAddNewProdButton.TabIndex = 6;
            AdminAddNewProdButton.Text = "Add New Product";
            AdminAddNewProdButton.UseVisualStyleBackColor = true;
            AdminAddNewProdButton.Click += AdminAddNewProdButton_Click;
            // 
            // AdminDelProdButton
            // 
            AdminDelProdButton.Location = new Point(544, 626);
            AdminDelProdButton.Name = "AdminDelProdButton";
            AdminDelProdButton.Size = new Size(98, 43);
            AdminDelProdButton.TabIndex = 21;
            AdminDelProdButton.Text = "Delete Selected Product";
            AdminDelProdButton.UseVisualStyleBackColor = true;
            AdminDelProdButton.Click += AdminDelProdButton_Click;
            // 
            // AdminUpdateProdButton
            // 
            AdminUpdateProdButton.Location = new Point(660, 626);
            AdminUpdateProdButton.Name = "AdminUpdateProdButton";
            AdminUpdateProdButton.Size = new Size(98, 43);
            AdminUpdateProdButton.TabIndex = 22;
            AdminUpdateProdButton.Text = "Update Product Details";
            AdminUpdateProdButton.UseVisualStyleBackColor = true;
            AdminUpdateProdButton.Click += AdminUpdateProdButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AdminProductPictureBox);
            groupBox2.Controls.Add(AdminModifyDataGridView);
            groupBox2.Location = new Point(8, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 263);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modify Products";
            // 
            // AdminProductPictureBox
            // 
            AdminProductPictureBox.Location = new Point(421, 33);
            AdminProductPictureBox.Name = "AdminProductPictureBox";
            AdminProductPictureBox.Size = new Size(329, 219);
            AdminProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AdminProductPictureBox.TabIndex = 7;
            AdminProductPictureBox.TabStop = false;
            // 
            // GenerateReportsButton
            // 
            GenerateReportsButton.Location = new Point(190, 616);
            GenerateReportsButton.Name = "GenerateReportsButton";
            GenerateReportsButton.Size = new Size(162, 53);
            GenerateReportsButton.TabIndex = 23;
            GenerateReportsButton.Text = "Generate Reports";
            GenerateReportsButton.UseVisualStyleBackColor = true;
            GenerateReportsButton.Click += GenerateReportsButton_Click;
            // 
            // ReturnToMainButton
            // 
            ReturnToMainButton.Location = new Point(22, 616);
            ReturnToMainButton.Name = "ReturnToMainButton";
            ReturnToMainButton.Size = new Size(162, 53);
            ReturnToMainButton.TabIndex = 24;
            ReturnToMainButton.Text = "Return to Product Browsing";
            ReturnToMainButton.UseVisualStyleBackColor = true;
            ReturnToMainButton.Click += ReturnToMainButton_Click;
            // 
            // ImageURLTextBox
            // 
            ImageURLTextBox.Location = new Point(530, 581);
            ImageURLTextBox.Name = "ImageURLTextBox";
            ImageURLTextBox.Size = new Size(112, 23);
            ImageURLTextBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 584);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 25;
            label7.Text = "Image URL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(516, 526);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 27;
            label8.Text = "P";
            // 
            // ClearAllDetailsButton
            // 
            ClearAllDetailsButton.Location = new Point(660, 523);
            ClearAllDetailsButton.Name = "ClearAllDetailsButton";
            ClearAllDetailsButton.Size = new Size(98, 43);
            ClearAllDetailsButton.TabIndex = 28;
            ClearAllDetailsButton.Text = "Clear All Details";
            ClearAllDetailsButton.UseVisualStyleBackColor = true;
            ClearAllDetailsButton.Click += ClearAllDetailsButton_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 722);
            Controls.Add(ClearAllDetailsButton);
            Controls.Add(label8);
            Controls.Add(ImageURLTextBox);
            Controls.Add(label7);
            Controls.Add(AdminUpdateProdButton);
            Controls.Add(ReturnToMainButton);
            Controls.Add(AdminDelProdButton);
            Controls.Add(AdminAddNewProdButton);
            Controls.Add(GenerateReportsButton);
            Controls.Add(AdminDescriptionTextBox);
            Controls.Add(groupBox2);
            Controls.Add(AdminAvailableStocksTextBox);
            Controls.Add(groupBox1);
            Controls.Add(AdminPriceTextBox);
            Controls.Add(label6);
            Controls.Add(AdminProductNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)AdminChangeStatusOrderDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminModifyDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminProductPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AdminChangeStatusOrderDataGridView;
        private Label label1;
        private TextBox ChangeOrderStatTextBox;
        private Button UpdateStatusButton;
        private Button MarkDeliveredButton;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView AdminModifyDataGridView;
        private TextBox AdminDescriptionTextBox;
        private TextBox AdminAvailableStocksTextBox;
        private TextBox AdminPriceTextBox;
        private TextBox AdminProductNameTextBox;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button AdminAddNewProdButton;
        private Button AdminDelProdButton;
        private Button AdminUpdateProdButton;
        private GroupBox groupBox2;
        private Button GenerateReportsButton;
        private Button ReturnToMainButton;
        private PictureBox AdminProductPictureBox;
        private TextBox ImageURLTextBox;
        private Label label7;
        private Label label8;
        private Button ClearAllDetailsButton;
    }
}