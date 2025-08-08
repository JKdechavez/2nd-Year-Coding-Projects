namespace Lab22
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            IDTextBox = new TextBox();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 45);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 103);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 132);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 161);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(84, 71);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(164, 23);
            FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(84, 100);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(164, 23);
            LastNameTextBox.TabIndex = 6;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(84, 129);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(164, 23);
            PhoneTextBox.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(84, 158);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(164, 23);
            EmailTextBox.TabIndex = 8;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(84, 42);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(164, 23);
            IDTextBox.TabIndex = 9;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(11, 202);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(92, 202);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(173, 202);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(285, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(492, 271);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpdateButton);
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(IDTextBox);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(PhoneTextBox);
            groupBox1.Controls.Add(LastNameTextBox);
            groupBox1.Controls.Add(FirstNameTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 256);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Data Modify Tools";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Student Data Information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox IDTextBox;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
    }
}