namespace Lab14
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
            CustomerNameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            SelectedAutoTextBox = new TextBox();
            groupBox1 = new GroupBox();
            TelephoneTextBox = new MaskedTextBox();
            visibilityCheckBox = new CheckBox();
            NewJaguarRadButton = new RadioButton();
            UsedJaguarRadButton = new RadioButton();
            ClassicJaguarRadButton = new RadioButton();
            groupBox2 = new GroupBox();
            DisplayButton = new Button();
            button2 = new Button();
            ResetButton = new Button();
            button4 = new Button();
            MultilineTextBox = new TextBox();
            Gray = new RadioButton();
            Blue = new RadioButton();
            Green = new RadioButton();
            Yellow = new RadioButton();
            groupBox3 = new GroupBox();
            ClassicJaguarPicBox = new PictureBox();
            UsedJaguarPicBox = new PictureBox();
            NewJaguarPicBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassicJaguarPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsedJaguarPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewJaguarPicBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(17, 112);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(17, 54);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(17, 83);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Selected Auto:";
            label4.Click += label4_Click;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(120, 22);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(200, 23);
            CustomerNameTextBox.TabIndex = 4;
            CustomerNameTextBox.KeyDown += button1_KeyDown;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(120, 109);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.ReadOnly = true;
            PriceTextBox.Size = new Size(127, 23);
            PriceTextBox.TabIndex = 5;
            PriceTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SelectedAutoTextBox
            // 
            SelectedAutoTextBox.Location = new Point(120, 80);
            SelectedAutoTextBox.Name = "SelectedAutoTextBox";
            SelectedAutoTextBox.ReadOnly = true;
            SelectedAutoTextBox.Size = new Size(294, 23);
            SelectedAutoTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TelephoneTextBox);
            groupBox1.Controls.Add(visibilityCheckBox);
            groupBox1.Controls.Add(SelectedAutoTextBox);
            groupBox1.Controls.Add(PriceTextBox);
            groupBox1.Controls.Add(CustomerNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(24, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 150);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer and Automobile Information";
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.Location = new Point(120, 51);
            TelephoneTextBox.Mask = "(999) 000-0000";
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(145, 23);
            TelephoneTextBox.TabIndex = 9;
            TelephoneTextBox.KeyDown += button3_KeyDown;
            // 
            // visibilityCheckBox
            // 
            visibilityCheckBox.AutoSize = true;
            visibilityCheckBox.Checked = true;
            visibilityCheckBox.CheckState = CheckState.Checked;
            visibilityCheckBox.ForeColor = SystemColors.MenuText;
            visibilityCheckBox.Location = new Point(331, 118);
            visibilityCheckBox.Name = "visibilityCheckBox";
            visibilityCheckBox.Size = new Size(113, 19);
            visibilityCheckBox.TabIndex = 8;
            visibilityCheckBox.Text = "Visible/Invisible";
            visibilityCheckBox.UseVisualStyleBackColor = true;
            visibilityCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // NewJaguarRadButton
            // 
            NewJaguarRadButton.AutoSize = true;
            NewJaguarRadButton.Checked = true;
            NewJaguarRadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewJaguarRadButton.ForeColor = SystemColors.MenuText;
            NewJaguarRadButton.Location = new Point(19, 22);
            NewJaguarRadButton.Name = "NewJaguarRadButton";
            NewJaguarRadButton.Size = new Size(87, 19);
            NewJaguarRadButton.TabIndex = 9;
            NewJaguarRadButton.TabStop = true;
            NewJaguarRadButton.Text = "New Jaguar";
            NewJaguarRadButton.UseVisualStyleBackColor = true;
            NewJaguarRadButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // UsedJaguarRadButton
            // 
            UsedJaguarRadButton.AutoSize = true;
            UsedJaguarRadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsedJaguarRadButton.ForeColor = SystemColors.MenuText;
            UsedJaguarRadButton.Location = new Point(19, 47);
            UsedJaguarRadButton.Name = "UsedJaguarRadButton";
            UsedJaguarRadButton.Size = new Size(89, 19);
            UsedJaguarRadButton.TabIndex = 10;
            UsedJaguarRadButton.Text = "Used Jaguar";
            UsedJaguarRadButton.UseVisualStyleBackColor = true;
            UsedJaguarRadButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // ClassicJaguarRadButton
            // 
            ClassicJaguarRadButton.AutoSize = true;
            ClassicJaguarRadButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClassicJaguarRadButton.ForeColor = SystemColors.MenuText;
            ClassicJaguarRadButton.Location = new Point(19, 72);
            ClassicJaguarRadButton.Name = "ClassicJaguarRadButton";
            ClassicJaguarRadButton.Size = new Size(98, 19);
            ClassicJaguarRadButton.TabIndex = 11;
            ClassicJaguarRadButton.Text = "Classic Jaguar";
            ClassicJaguarRadButton.UseVisualStyleBackColor = true;
            ClassicJaguarRadButton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ClassicJaguarRadButton);
            groupBox2.Controls.Add(UsedJaguarRadButton);
            groupBox2.Controls.Add(NewJaguarRadButton);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.MenuHighlight;
            groupBox2.Location = new Point(24, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 103);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Auto";
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(24, 283);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(75, 23);
            DisplayButton.TabIndex = 13;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += button1_Click_1;
            DisplayButton.KeyDown += button1_KeyDown;
            // 
            // button2
            // 
            button2.Location = new Point(105, 312);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(105, 283);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 15;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button3_Click_1;
            ResetButton.KeyDown += button3_KeyDown;
            // 
            // button4
            // 
            button4.Location = new Point(24, 312);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MultilineTextBox
            // 
            MultilineTextBox.Location = new Point(368, 188);
            MultilineTextBox.Multiline = true;
            MultilineTextBox.Name = "MultilineTextBox";
            MultilineTextBox.Size = new Size(247, 147);
            MultilineTextBox.TabIndex = 17;
            MultilineTextBox.Text = "l";
            MultilineTextBox.TextChanged += textBox5_TextChanged;
            // 
            // Gray
            // 
            Gray.AutoSize = true;
            Gray.Checked = true;
            Gray.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Gray.ForeColor = SystemColors.MenuText;
            Gray.Location = new Point(20, 30);
            Gray.Name = "Gray";
            Gray.Size = new Size(49, 19);
            Gray.TabIndex = 12;
            Gray.TabStop = true;
            Gray.Text = "Gray";
            Gray.UseVisualStyleBackColor = true;
            Gray.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Blue
            // 
            Blue.AutoSize = true;
            Blue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Blue.ForeColor = SystemColors.MenuText;
            Blue.Location = new Point(20, 105);
            Blue.Name = "Blue";
            Blue.Size = new Size(48, 19);
            Blue.TabIndex = 18;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = true;
            Blue.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // Green
            // 
            Green.AutoSize = true;
            Green.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Green.ForeColor = SystemColors.MenuText;
            Green.Location = new Point(20, 80);
            Green.Name = "Green";
            Green.Size = new Size(56, 19);
            Green.TabIndex = 19;
            Green.Text = "Green";
            Green.UseVisualStyleBackColor = true;
            Green.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // Yellow
            // 
            Yellow.AutoSize = true;
            Yellow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Yellow.ForeColor = SystemColors.MenuText;
            Yellow.Location = new Point(20, 55);
            Yellow.Name = "Yellow";
            Yellow.Size = new Size(59, 19);
            Yellow.TabIndex = 20;
            Yellow.Text = "Yellow";
            Yellow.UseVisualStyleBackColor = true;
            Yellow.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Yellow);
            groupBox3.Controls.Add(Green);
            groupBox3.Controls.Add(Blue);
            groupBox3.Controls.Add(Gray);
            groupBox3.ForeColor = SystemColors.MenuHighlight;
            groupBox3.Location = new Point(505, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(110, 150);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Color";
            // 
            // ClassicJaguarPicBox
            // 
            ClassicJaguarPicBox.Image = Properties.Resources.JaguarClassic;
            ClassicJaguarPicBox.Location = new Point(166, 174);
            ClassicJaguarPicBox.Name = "ClassicJaguarPicBox";
            ClassicJaguarPicBox.Size = new Size(193, 103);
            ClassicJaguarPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ClassicJaguarPicBox.TabIndex = 22;
            ClassicJaguarPicBox.TabStop = false;
            // 
            // UsedJaguarPicBox
            // 
            UsedJaguarPicBox.Image = Properties.Resources.JaguarUsed;
            UsedJaguarPicBox.Location = new Point(166, 174);
            UsedJaguarPicBox.Name = "UsedJaguarPicBox";
            UsedJaguarPicBox.Size = new Size(193, 103);
            UsedJaguarPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UsedJaguarPicBox.TabIndex = 23;
            UsedJaguarPicBox.TabStop = false;
            UsedJaguarPicBox.Click += UsedJaguarPicBox_Click;
            // 
            // NewJaguarPicBox
            // 
            NewJaguarPicBox.Image = Properties.Resources.JaguaNew;
            NewJaguarPicBox.Location = new Point(165, 174);
            NewJaguarPicBox.Name = "NewJaguarPicBox";
            NewJaguarPicBox.Size = new Size(193, 103);
            NewJaguarPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NewJaguarPicBox.TabIndex = 24;
            NewJaguarPicBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 359);
            Controls.Add(NewJaguarPicBox);
            Controls.Add(UsedJaguarPicBox);
            Controls.Add(ClassicJaguarPicBox);
            Controls.Add(groupBox3);
            Controls.Add(MultilineTextBox);
            Controls.Add(button4);
            Controls.Add(ResetButton);
            Controls.Add(button2);
            Controls.Add(DisplayButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bock Jaguar Sales";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClassicJaguarPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsedJaguarPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewJaguarPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CustomerNameTextBox;
        private TextBox PriceTextBox;
        private TextBox SelectedAutoTextBox;
        private GroupBox groupBox1;
        private CheckBox visibilityCheckBox;
        private RadioButton NewJaguarRadButton;
        private RadioButton UsedJaguarRadButton;
        private RadioButton ClassicJaguarRadButton;
        private GroupBox groupBox2;
        private Button DisplayButton;
        private Button button2;
        private Button ResetButton;
        private Button button4;
        private TextBox MultilineTextBox;
        private RadioButton Gray;
        private RadioButton Blue;
        private RadioButton Green;
        private RadioButton Yellow;
        private GroupBox groupBox3;
        private PictureBox ClassicJaguarPicBox;
        private MaskedTextBox TelephoneTextBox;
        private PictureBox UsedJaguarPicBox;
        private PictureBox NewJaguarPicBox;
    }
}