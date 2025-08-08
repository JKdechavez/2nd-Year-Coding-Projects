namespace MachPro3
{
    partial class Reports
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
            InventoryReportDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TotalNumItemsSoldTextBox = new TextBox();
            TotalRevenueTextBox = new TextBox();
            label5 = new Label();
            UserActReportDataGridView = new DataGridView();
            ReturnButton = new Button();
            SalesReportDataGridView = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)InventoryReportDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserActReportDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalesReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InventoryReportDataGridView
            // 
            InventoryReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryReportDataGridView.Location = new Point(12, 40);
            InventoryReportDataGridView.Name = "InventoryReportDataGridView";
            InventoryReportDataGridView.Size = new Size(354, 154);
            InventoryReportDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventory Report:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 22);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Sales Report:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 203);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 5;
            label3.Text = "Total Number of Items Sold:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 232);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "Total Revenue:";
            // 
            // TotalNumItemsSoldTextBox
            // 
            TotalNumItemsSoldTextBox.Location = new Point(614, 200);
            TotalNumItemsSoldTextBox.Name = "TotalNumItemsSoldTextBox";
            TotalNumItemsSoldTextBox.Size = new Size(141, 23);
            TotalNumItemsSoldTextBox.TabIndex = 7;
            // 
            // TotalRevenueTextBox
            // 
            TotalRevenueTextBox.Location = new Point(614, 229);
            TotalRevenueTextBox.Name = "TotalRevenueTextBox";
            TotalRevenueTextBox.Size = new Size(141, 23);
            TotalRevenueTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 208);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 9;
            label5.Text = "User Activity Report:";
            // 
            // UserActReportDataGridView
            // 
            UserActReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserActReportDataGridView.Location = new Point(12, 226);
            UserActReportDataGridView.Name = "UserActReportDataGridView";
            UserActReportDataGridView.Size = new Size(354, 154);
            UserActReportDataGridView.TabIndex = 10;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(630, 330);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(125, 50);
            ReturnButton.TabIndex = 11;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SalesReportDataGridView
            // 
            SalesReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesReportDataGridView.Location = new Point(401, 40);
            SalesReportDataGridView.Name = "SalesReportDataGridView";
            SalesReportDataGridView.Size = new Size(354, 154);
            SalesReportDataGridView.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 232);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 13;
            label6.Text = "P";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 401);
            Controls.Add(label6);
            Controls.Add(SalesReportDataGridView);
            Controls.Add(ReturnButton);
            Controls.Add(UserActReportDataGridView);
            Controls.Add(label5);
            Controls.Add(TotalRevenueTextBox);
            Controls.Add(TotalNumItemsSoldTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InventoryReportDataGridView);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryReportDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserActReportDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalesReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InventoryReportDataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TotalNumItemsSoldTextBox;
        private TextBox TotalRevenueTextBox;
        private Label label5;
        private DataGridView UserActReportDataGridView;
        private Button ReturnButton;
        private DataGridView SalesReportDataGridView;
        private Label label6;
    }
}