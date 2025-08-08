using Org.BouncyCastle.Tls;
using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lab18;

namespace MachPro3
{
    public partial class Form1 : Form
    {
        public static string userType = "";
        public static int userID;
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        ProductList productList;
        int tracker = 1;
        int maxCounter = 0;
        OrdersAndHistory orderAndHistory;
        public Form1()
        {
            InitializeComponent();
            //tool strip set up
            conn = new MySqlConnection(connectionString);
            ToolStripMenuItem login = new ToolStripMenuItem("Login");
            ToolStripMenuItem loginAccount = new ToolStripMenuItem("Login Account");
            ToolStripMenuItem logoutAccount = new ToolStripMenuItem("Logout");
            ToolStripMenuItem about = new ToolStripMenuItem("About");
            ToolStripMenuItem help = new ToolStripMenuItem("Help");
            login.DropDownItems.Add(loginAccount);
            login.DropDownItems.Add(logoutAccount);
            help.DropDownItems.Add(about);
            menuStrip1.Items.Add(login);
            menuStrip1.Items.Add(help);
            if (userType == "customer")
            {
                loginAccount.Enabled = false;
            }
            else if (userType == "guest")
            {
                logoutAccount.Enabled = false;
                AddToCartButton.Enabled = false;
            }
            else
            {
                ToolStripMenuItem admin = new ToolStripMenuItem("Admin");
                ToolStripMenuItem adminInterface = new ToolStripMenuItem("Administrator Interface");
                admin.DropDownItems.Add(adminInterface);
                menuStrip1.Items.Add(admin);
                adminInterface.Click += new System.EventHandler(this.AdminInterface_Click);
                loginAccount.Enabled = false;
            }
            loginAccount.Click += new System.EventHandler(this.LoginAccount_Click);
            logoutAccount.Click += new System.EventHandler(this.LogoutAccount_Click);
            about.Click += new System.EventHandler(this.About_Click);

            // load products
            Products_Load();

            this.BackColor = Color.DarkTurquoise;
        }
        LoginInterface loginInterface;
        private void LoginAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginInterface = new LoginInterface();
            loginInterface.Show();

        }
        private void LogoutAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginInterface = new LoginInterface();
            loginInterface.Show();
        }
        private void About_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(@$"Programmer Name: John Kevin R. De Chavez
Date: {dateTime.ToString("MMMM dd, yyyy")}
Time: {dateTime.ToString("hh:mm:ss tt")}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Admin adminInterface;
        private void AdminInterface_Click(object sender, EventArgs e)
        {
            if (adminInterface == null)
            {
                adminInterface = new Admin();
                adminInterface.MdiParent = this.MdiParent;
                adminInterface.FormClosed += new FormClosedEventHandler(AdminInterface_FormClosed);
                adminInterface.Show();
                this.Hide();
            }
            else
                adminInterface.Activate();
        }
        private void AdminInterface_FormClosed(object sender, EventArgs e)
        {
            adminInterface = null;
            this.Show();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (AvailableStocksTextBox.Text == "0")
            {
                MessageBox.Show("Product is out of stock!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                int temp_counter = 1;
                int productID = 0;
                double productPrice = 0;
                foreach (Product product in productList.findProducts())
                {
                    if (temp_counter == tracker + 1)
                        break;
                    productID = product.ProductID;
                    productPrice = product.Price;
                    temp_counter += 1;
                }
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Quantity FROM users_cart WHERE userID = @userID AND ProductID = @productID";
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@productID", productID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int currentQuantity = reader.GetInt32(0);
                        int newQuantity = currentQuantity + Convert.ToInt32(QuantiOfProdToCartTextBox.Text);
                        double newPrice = newQuantity * productPrice;
                        reader.Close();
                        cmd.CommandText = "UPDATE users_cart SET Quantity = @newQuantity, TotalPrice = @newPrice WHERE userID = @userID AND ProductID = @productID";
                        cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@newPrice", newPrice);
                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "INSERT INTO users_cart (userID, ProductID, Quantity, TotalPrice) VALUES (@userID, @productID, @quantity, @totalPrice)";
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(QuantiOfProdToCartTextBox.Text));
                        cmd.Parameters.AddWithValue("@totalPrice", Convert.ToDouble(QuantiOfProdToCartTextBox.Text) * productPrice);
                    }
                    cmd.ExecuteNonQuery();
                    QuantiOfProdToCartTextBox.Clear();
                    MessageBox.Show("Cart updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void Products_Load()
        {
            productList = new ProductList();
            string itemName = "";
            foreach (Product product in productList.findProducts())
                maxCounter++;
            foreach (Product product in productList.findProducts()) 
            {
                if (AllItemsComboBox.Items.Contains(product.ProductName))
                    continue;
                else    
                    AllItemsComboBox.Items.Add(product.ProductName);
            }
            foreach (Product product in productList.findProducts())
            {
                if (tracker == 2)
                {
                    tracker = 1;
                    break;
                }
                ProductNameTextBox.Text = $"{product.ProductName}";
                PriceTextBox.Text = $"{product.Price:0.00}";
                AvailableStocksTextBox.Text = $"{product.StocksNum}";
                DescriptionTextBox.Text = $"{product.Description}";
                ProductPictureBox.Image = new Bitmap(product.ImageURL);
                itemName = product.ProductName;
                tracker += 1;
            }
            AllItemsComboBox.SelectedItem = itemName;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
        ShoppingCart shoppingCart;
        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userType == "guest")
            {
                DialogResult result = MessageBox.Show("Please login first to access shopping cart. Do you want to login?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    loginInterface = new LoginInterface();
                    loginInterface.Show();
                }
            }
            else
            {
                this.Hide();
                shoppingCart = new ShoppingCart();
                shoppingCart.Show();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            loginInterface = new LoginInterface();
            loginInterface.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginInterface = new LoginInterface();
            loginInterface.Show();
        }

        private void PrevMostButton_Click(object sender, EventArgs e)
        {
            if (tracker == 1)
            {
                MessageBox.Show("End of List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int temp_counter = 1;
                tracker = 1;
                string itemName = "";
                foreach (Product product in productList.findProducts())
                {
                    if (temp_counter == 2)
                        break;
                    ProductNameTextBox.Text = $"{product.ProductName}";
                    PriceTextBox.Text = $"{product.Price:0.00}";
                    AvailableStocksTextBox.Text = $"{product.StocksNum}";
                    DescriptionTextBox.Text = $"{product.Description}";
                    ProductPictureBox.Image = new Bitmap(product.ImageURL);
                    itemName = product.ProductName;
                    temp_counter += 1;
                }
                AllItemsComboBox.SelectedItem = itemName;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (tracker == 1)
            {
                MessageBox.Show("End of List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int temp_counter = 1;
                tracker -= 1;
                string itemName = "";
                foreach (Product product in productList.findProducts())
                {
                    if (temp_counter == tracker + 1)
                        break;
                    ProductNameTextBox.Text = $"{product.ProductName}";
                    PriceTextBox.Text = $"{product.Price:0.00}";
                    AvailableStocksTextBox.Text = $"{product.StocksNum}";
                    DescriptionTextBox.Text = $"{product.Description}";
                    ProductPictureBox.Image = new Bitmap(product.ImageURL);
                    itemName = product.ProductName;
                    temp_counter += 1;
                }
                AllItemsComboBox.SelectedItem = itemName;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (tracker == maxCounter)
            {
                MessageBox.Show("End of List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int temp_counter = 1;
                tracker += 1;
                string itemName = "";
                foreach (Product product in productList.findProducts())
                {
                    if (temp_counter == tracker + 1)
                        break;
                    ProductNameTextBox.Text = $"{product.ProductName}";
                    PriceTextBox.Text = $"{product.Price:0.00}";
                    AvailableStocksTextBox.Text = $"{product.StocksNum}";
                    DescriptionTextBox.Text = $"{product.Description}";
                    ProductPictureBox.Image = new Bitmap(product.ImageURL);
                    itemName = product.ProductName;
                    temp_counter += 1;
                }
                AllItemsComboBox.SelectedItem = itemName;
            }
        }

        private void NextMostButton_Click(object sender, EventArgs e)
        {
            if (tracker == maxCounter)
            {
                MessageBox.Show("End of List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tracker = maxCounter;
                string itemName = "";
                foreach (Product product in productList.findProducts())
                {
                    ProductNameTextBox.Text = $"{product.ProductName}";
                    PriceTextBox.Text = $"{product.Price:0.00}";
                    AvailableStocksTextBox.Text = $"{product.StocksNum}";
                    DescriptionTextBox.Text = $"{product.Description}";
                    ProductPictureBox.Image = new Bitmap(product.ImageURL);
                    itemName = product.ProductName;
                }
                AllItemsComboBox.SelectedItem = itemName;
            }
        }

        private void ordersStatusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userType == "guest")
            {
                DialogResult result = MessageBox.Show("Please login first to access user's order statuses and history. Do you want to login?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    loginInterface = new LoginInterface();
                    loginInterface.Show();
                }
            }
            else
            {
                if (orderAndHistory == null)
                {
                    orderAndHistory = new OrdersAndHistory();
                    orderAndHistory.MdiParent = this.MdiParent;
                    orderAndHistory.FormClosed += new FormClosedEventHandler(orderAndHistory_FormClosed);
                    orderAndHistory.Show();
                    this.Hide();
                }
                else
                    orderAndHistory.Activate();
            }
        }
        private void orderAndHistory_FormClosed(object sender, EventArgs e)
        {
            orderAndHistory = null;
            this.Show();
        }

        private void AllItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = AllItemsComboBox.SelectedItem.ToString();
            int temp_counter = 0;
            foreach (Product product in productList.findProducts())
            {
                temp_counter++;
                if (selectedProductName == product.ProductName)
                { 
                    ProductNameTextBox.Text = $"{product.ProductName}";
                    PriceTextBox.Text = $"{product.Price:0.00}";
                    AvailableStocksTextBox.Text = $"{product.StocksNum}";
                    DescriptionTextBox.Text = $"{product.Description}";
                    ProductPictureBox.Image = new Bitmap(product.ImageURL);
                    tracker = temp_counter;
                    break;
                } 
            }
        }
    }
}
