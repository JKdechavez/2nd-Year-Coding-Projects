namespace MachPro3
{
    partial class LoginInterface
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
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            ContAsGuestButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 75);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 104);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(113, 72);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(247, 23);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(113, 101);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(247, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(41, 163);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(131, 163);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ContAsGuestButton
            // 
            ContAsGuestButton.Location = new Point(221, 163);
            ContAsGuestButton.Name = "ContAsGuestButton";
            ContAsGuestButton.Size = new Size(139, 23);
            ContAsGuestButton.TabIndex = 6;
            ContAsGuestButton.Text = "Continue as Guest";
            ContAsGuestButton.UseVisualStyleBackColor = true;
            ContAsGuestButton.Click += ContAsGuestButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 17);
            label3.Name = "label3";
            label3.Size = new Size(313, 27);
            label3.TabIndex = 7;
            label3.Text = "Welcome To Shopper's Hub";
            // 
            // LoginInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 236);
            Controls.Add(label3);
            Controls.Add(ContAsGuestButton);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginInterface_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
        private Button ContAsGuestButton;
        private Label label3;
    }
}