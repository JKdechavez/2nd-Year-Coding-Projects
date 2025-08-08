namespace MachPro3
{
    partial class OrdersAndHistory
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
            label1 = new Label();
            label2 = new Label();
            OrderStatusesDataGridView = new DataGridView();
            OrderHistoryDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OrderStatusesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderHistoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Order Statuses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 248);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Order History:";
            // 
            // OrderStatusesDataGridView
            // 
            OrderStatusesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderStatusesDataGridView.Location = new Point(12, 44);
            OrderStatusesDataGridView.Name = "OrderStatusesDataGridView";
            OrderStatusesDataGridView.Size = new Size(373, 183);
            OrderStatusesDataGridView.TabIndex = 4;
            // 
            // OrderHistoryDataGridView
            // 
            OrderHistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderHistoryDataGridView.Location = new Point(12, 266);
            OrderHistoryDataGridView.Name = "OrderHistoryDataGridView";
            OrderHistoryDataGridView.Size = new Size(576, 173);
            OrderHistoryDataGridView.TabIndex = 5;
            // 
            // OrdersAndHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 460);
            Controls.Add(OrderHistoryDataGridView);
            Controls.Add(OrderStatusesDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrdersAndHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders And History";
            Load += OrdersAndHistory_Load;
            ((System.ComponentModel.ISupportInitialize)OrderStatusesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderHistoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView OrderStatusesDataGridView;
        private DataGridView OrderHistoryDataGridView;
    }
}