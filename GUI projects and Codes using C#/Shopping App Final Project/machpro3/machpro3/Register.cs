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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.BackColor = Color.DarkTurquoise;
        }

        private void RegNewAccButton_Click(object sender, EventArgs e)
        {
            string username = RegUsernameTextBox.Text;
            string password = RegPasswordTextBox.Text;
            string email = EmailTextBox.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.");
                RegUsernameTextBox.Clear();
                RegPasswordTextBox.Clear();
                EmailTextBox.Clear();
                return;
            }
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=051604gwen;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO users(Username, Password, Email, Role) VALUES (@username, @password, @email, @usertype)";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@usertype", "customer");
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Account successfully registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                RegUsernameTextBox.Clear();
                RegPasswordTextBox.Clear();
                EmailTextBox.Clear();
            }
        }

        private void RegCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
