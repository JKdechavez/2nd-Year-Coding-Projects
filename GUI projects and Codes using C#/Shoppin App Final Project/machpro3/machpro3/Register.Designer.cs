namespace MachPro3
{
    partial class Register
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
            label3 = new Label();
            RegUsernameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            RegPasswordTextBox = new TextBox();
            RegNewAccButton = new Button();
            RegCancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 53);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 111);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 82);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // RegUsernameTextBox
            // 
            RegUsernameTextBox.Location = new Point(108, 50);
            RegUsernameTextBox.Name = "RegUsernameTextBox";
            RegUsernameTextBox.Size = new Size(254, 23);
            RegUsernameTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(108, 108);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(254, 23);
            EmailTextBox.TabIndex = 4;
            // 
            // RegPasswordTextBox
            // 
            RegPasswordTextBox.Location = new Point(108, 79);
            RegPasswordTextBox.Name = "RegPasswordTextBox";
            RegPasswordTextBox.Size = new Size(254, 23);
            RegPasswordTextBox.TabIndex = 5;
            // 
            // RegNewAccButton
            // 
            RegNewAccButton.Location = new Point(39, 158);
            RegNewAccButton.Name = "RegNewAccButton";
            RegNewAccButton.Size = new Size(166, 23);
            RegNewAccButton.TabIndex = 6;
            RegNewAccButton.Text = "Register New Account";
            RegNewAccButton.UseVisualStyleBackColor = true;
            RegNewAccButton.Click += RegNewAccButton_Click;
            // 
            // RegCancelButton
            // 
            RegCancelButton.Location = new Point(211, 158);
            RegCancelButton.Name = "RegCancelButton";
            RegCancelButton.Size = new Size(84, 23);
            RegCancelButton.TabIndex = 7;
            RegCancelButton.Text = "Cancel";
            RegCancelButton.UseVisualStyleBackColor = true;
            RegCancelButton.Click += RegCancelButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 219);
            Controls.Add(RegCancelButton);
            Controls.Add(RegNewAccButton);
            Controls.Add(RegPasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(RegUsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox RegUsernameTextBox;
        private TextBox EmailTextBox;
        private TextBox RegPasswordTextBox;
        private Button RegNewAccButton;
        private Button RegCancelButton;
    }
}