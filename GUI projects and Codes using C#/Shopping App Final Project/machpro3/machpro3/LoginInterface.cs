using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MachPro3
{
    public partial class LoginInterface : Form
    {
        Register registerWindow;
        Form1 mainInterface;
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public LoginInterface()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            this.BackColor = Color.DarkTurquoise;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM users WHERE username = @username AND password = @password";
                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Form1.userType = reader["Role"].ToString();
                    Form1.userID = Convert.ToInt32(reader["UserID"]);
                    conn.Close();

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Logins FROM users WHERE UserID = @userID";
                    cmd.Parameters.AddWithValue("@userID", Form1.userID);
                    int logins = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Parameters.Clear();
                    conn.Close();

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "UPDATE users SET Logins = @logins WHERE UserID = @userID";
                    cmd.Parameters.AddWithValue("@userID", Form1.userID);
                    cmd.Parameters.AddWithValue("@logins", logins + 1);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conn.Close();

                    this.Hide();
                    mainInterface = new Form1();
                    mainInterface.Show();
                    
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Invalid Username or Password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (registerWindow == null)
            {
                registerWindow = new Register();
                registerWindow.MdiParent = this.MdiParent;
                registerWindow.FormClosed += new FormClosedEventHandler(registerWindow_FormClosed);
                registerWindow.Show();
                this.Hide();
            }
            else
                registerWindow.Activate();
        }
        private void registerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            registerWindow = null;
            this.Show();
        }

        private void ContAsGuestButton_Click(object sender, EventArgs e)
        {
            Form1.userType = "guest";
            this.Hide();
            mainInterface = new Form1();
            mainInterface.Show();
        }

        private void LoginCustButton_Click(object sender, EventArgs e)
        {
            Form1.userType = "customer";
            Form1.userID = 2;
            this.Hide();
            mainInterface = new Form1();
            mainInterface.Show();
        }

        private void LogAdminButton_Click(object sender, EventArgs e)
        {
            Form1.userType = "admin";
            Form1.userID = 1;
            this.Hide();
            mainInterface = new Form1();
            mainInterface.Show();
        }
    }
}
