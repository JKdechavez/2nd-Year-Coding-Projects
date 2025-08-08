namespace MachPro3
{
    partial class CheckOut
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
            AddressTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CodRadioButton = new RadioButton();
            PaymentEwallRadiobutton = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            ConfirmOrderButton = new Button();
            OrderSummaryListBox = new ListBox();
            label5 = new Label();
            TotalAmountTextBox = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 26);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(14, 44);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(294, 86);
            AddressTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 34);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 3;
            label3.Text = "Order Summary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 142);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 5;
            label4.Text = "Payment Method:";
            // 
            // CodRadioButton
            // 
            CodRadioButton.AutoSize = true;
            CodRadioButton.Checked = true;
            CodRadioButton.Location = new Point(14, 170);
            CodRadioButton.Name = "CodRadioButton";
            CodRadioButton.Size = new Size(113, 19);
            CodRadioButton.TabIndex = 6;
            CodRadioButton.TabStop = true;
            CodRadioButton.Text = "Cash on Delivery";
            CodRadioButton.UseVisualStyleBackColor = true;
            // 
            // PaymentEwallRadiobutton
            // 
            PaymentEwallRadiobutton.AutoSize = true;
            PaymentEwallRadiobutton.Location = new Point(14, 195);
            PaymentEwallRadiobutton.Name = "PaymentEwallRadiobutton";
            PaymentEwallRadiobutton.Size = new Size(69, 19);
            PaymentEwallRadiobutton.TabIndex = 7;
            PaymentEwallRadiobutton.Text = "E-Wallet";
            PaymentEwallRadiobutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PaymentEwallRadiobutton);
            groupBox1.Controls.Add(CodRadioButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(AddressTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 224);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shipping Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ConfirmOrderButton
            // 
            ConfirmOrderButton.Location = new Point(361, 214);
            ConfirmOrderButton.Name = "ConfirmOrderButton";
            ConfirmOrderButton.Size = new Size(103, 35);
            ConfirmOrderButton.TabIndex = 9;
            ConfirmOrderButton.Text = "Confirm Order";
            ConfirmOrderButton.UseVisualStyleBackColor = true;
            ConfirmOrderButton.Click += ConfirmOrderButton_Click;
            // 
            // OrderSummaryListBox
            // 
            OrderSummaryListBox.FormattingEnabled = true;
            OrderSummaryListBox.ItemHeight = 15;
            OrderSummaryListBox.Location = new Point(358, 52);
            OrderSummaryListBox.Name = "OrderSummaryListBox";
            OrderSummaryListBox.Size = new Size(300, 139);
            OrderSummaryListBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 199);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "Total Amount: ";
            // 
            // TotalAmountTextBox
            // 
            TotalAmountTextBox.Location = new Point(540, 217);
            TotalAmountTextBox.Name = "TotalAmountTextBox";
            TotalAmountTextBox.Size = new Size(118, 23);
            TotalAmountTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 220);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 13;
            label6.Text = "P";
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 272);
            Controls.Add(label6);
            Controls.Add(TotalAmountTextBox);
            Controls.Add(label5);
            Controls.Add(OrderSummaryListBox);
            Controls.Add(ConfirmOrderButton);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox AddressTextBox;
        private Label label3;
        private Label label4;
        private RadioButton CodRadioButton;
        private RadioButton PaymentEwallRadiobutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button ConfirmOrderButton;
        private ListBox OrderSummaryListBox;
        private Label label5;
        private TextBox TotalAmountTextBox;
        private Label label6;
    }
}