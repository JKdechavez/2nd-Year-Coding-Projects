using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachPro3
{
    public partial class CheckOut : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        double allTotalAmount = 0;
        double selectTotalAmount = 0;
        public CheckOut()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            OrderSummary_Load();
            this.BackColor = Color.DarkTurquoise;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void OrderSummary_Load() 
        {
            if (ShoppingCart.typeOfCheckout == "all") 
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
                    SELECT 
                        p.Name, 
                        uc.Quantity,
                        uc.TotalPrice
                    FROM 
                        users_cart uc
                    INNER JOIN 
                        products p ON uc.ProductID = p.ProductID
                    WHERE 
                        uc.userID = @userID";
                cmd.Parameters.AddWithValue("@userID", Form1.userID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader["Name"].ToString();
                    string quantity = reader["Quantity"].ToString();
                    double totalPrice = Convert.ToDouble(reader["TotalPrice"]);
                    string lineDetail = $"{productName} x{quantity}";
                    OrderSummaryListBox.Items.Add(lineDetail);
                    allTotalAmount += totalPrice;
                }
                conn.Close();
                TotalAmountTextBox.Text = $"{allTotalAmount: 0.00}";
            }
            else 
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
                        SELECT 
                            p.Name, 
                            p.ProductID,
                            uc.Quantity,
                            uc.TotalPrice
                        FROM 
                            users_cart uc
                        INNER JOIN 
                            products p ON uc.ProductID = p.ProductID
                        WHERE 
                            uc.userID = @userID";
                cmd.Parameters.AddWithValue("@userID", Form1.userID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foreach (int productID in ShoppingCart.selectiveCheckoutProductIDs)
                    {
                        if (Convert.ToInt32(reader["ProductID"]) == productID)
                        {
                            string productName = reader["Name"].ToString();
                            string quantity = reader["Quantity"].ToString();
                            double totalPrice = Convert.ToDouble(reader["TotalPrice"]);
                            string lineDetail = $"{productName} x{quantity}";
                            OrderSummaryListBox.Items.Add(lineDetail);
                            selectTotalAmount += totalPrice;
                        }
                    }
                        
                }
                conn.Close();
                TotalAmountTextBox.Text = $"{selectTotalAmount: 0.00}";
                
            }
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            if (ShoppingCart.typeOfCheckout == "selective")
            {
                if (AddressTextBox.Text == "")
                {
                    MessageBox.Show("Please enter your address!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    try
                    {
                        conn.Open();
                        foreach (int productID in ShoppingCart.selectiveCheckoutProductIDs)
                        {
                            // Update number of stocks of product
                            MySqlCommand retrieveCmd = new MySqlCommand();
                            retrieveCmd.Connection = conn;
                            retrieveCmd.CommandType = CommandType.Text;
                            retrieveCmd.CommandText = "SELECT Quantity FROM users_cart WHERE userID = @userID AND ProductID = @productID";
                            retrieveCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            retrieveCmd.Parameters.AddWithValue("@productID", productID);
                            int quantityOfOrder = Convert.ToInt32(retrieveCmd.ExecuteScalar());
                            retrieveCmd.Parameters.Clear();

                            retrieveCmd.CommandType = CommandType.Text;
                            retrieveCmd.CommandText = "SELECT Quantity FROM products WHERE ProductID = @productID";
                            retrieveCmd.Parameters.AddWithValue("@productID", productID);
                            int availableStocks = Convert.ToInt32(retrieveCmd.ExecuteScalar());

                            MySqlCommand updateCmd = new MySqlCommand();
                            updateCmd.Connection = conn;
                            updateCmd.CommandType = CommandType.Text;
                            updateCmd.CommandText = "UPDATE products SET Quantity = @newQuantity WHERE ProductID = @productID";
                            updateCmd.Parameters.AddWithValue("@productID", productID);
                            updateCmd.Parameters.AddWithValue("@newQuantity", availableStocks - quantityOfOrder);
                            updateCmd.ExecuteNonQuery();

                            // Insert selected items into orders table
                            MySqlCommand insertCmd = new MySqlCommand();
                            insertCmd.Connection = conn;
                            insertCmd.CommandType = CommandType.Text;
                            insertCmd.CommandText = @"INSERT INTO orders(UserID, OrderDate, TotalAmount, StatusID) 
                                SELECT @userID, NOW(), TotalPrice, @statusID
                                FROM users_cart 
                                WHERE userID = @userID AND ProductID = @productID";
                            insertCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            insertCmd.Parameters.AddWithValue("@productID", Convert.ToInt32(productID));
                            insertCmd.Parameters.AddWithValue("@statusID", 1);
                            insertCmd.ExecuteNonQuery();

                            insertCmd.CommandText = "SELECT LAST_INSERT_ID()";
                            int orderID = Convert.ToInt32(insertCmd.ExecuteScalar());
                            insertCmd.Parameters.Clear();

                            insertCmd.CommandText = @"INSERT INTO order_details(OrderID, ProductID, Quantity, Price, Address, ModeOfPayment)
                                SELECT 
                                    @orderID, 
                                    @productID, 
                                    uc.Quantity, 
                                    p.Price,
                                    @address,
                                    @modeOfPay
                                FROM 
                                    users_cart uc
                                JOIN 
                                    products p ON uc.ProductID = p.ProductID
                                WHERE 
                                    uc.UserID = @userID AND uc.ProductID = @productID";
                            insertCmd.Parameters.AddWithValue("@orderID", orderID);
                            insertCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            insertCmd.Parameters.AddWithValue("@productID", Convert.ToInt32(productID));
                            insertCmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                            string modeOfPay;
                            if (CodRadioButton.Checked == true)
                            {
                                modeOfPay = "COD";
                            }
                            else
                                modeOfPay = "OP";
                            insertCmd.Parameters.AddWithValue("@modeOfPay", modeOfPay);
                            insertCmd.ExecuteNonQuery();
                        }

                        // Remove selected items from users_cart table
                        foreach (int productID in ShoppingCart.selectiveCheckoutProductIDs)
                        {
                            MySqlCommand deleteCmd = new MySqlCommand();
                            deleteCmd.Connection = conn;
                            deleteCmd.CommandType = CommandType.Text;
                            deleteCmd.CommandText = "DELETE FROM users_cart WHERE userID = @userID AND ProductID = @productID";
                            deleteCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            deleteCmd.Parameters.AddWithValue("@productID", productID);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during checkout: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                    ShoppingCart.selectTotalAmount -= selectTotalAmount;
                    ShoppingCart.allTotalAmount -= selectTotalAmount;
                    MessageBox.Show("Order successfully placed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShoppingCart.isCheckoutConfirmed = true;
                    this.Close();
                }
                
            }
            else 
            {
                if (AddressTextBox.Text == "")
                {
                    MessageBox.Show("Please enter your address!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    try
                    {
                        conn.Open();
                        foreach (int productID in ShoppingCart.AllItemsCheckoutProductIDs)
                        {
                            // Update number of stocks of product
                            MySqlCommand retrieveCmd = new MySqlCommand();
                            retrieveCmd.Connection = conn;
                            retrieveCmd.CommandType = CommandType.Text;
                            retrieveCmd.CommandText = "SELECT Quantity FROM users_cart WHERE userID = @userID AND ProductID = @productID";
                            retrieveCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            retrieveCmd.Parameters.AddWithValue("@productID", productID);
                            int quantityOfOrder = Convert.ToInt32(retrieveCmd.ExecuteScalar());
                            retrieveCmd.Parameters.Clear();

                            retrieveCmd.CommandType = CommandType.Text;
                            retrieveCmd.CommandText = "SELECT Quantity FROM products WHERE ProductID = @productID";
                            retrieveCmd.Parameters.AddWithValue("@productID", productID);
                            int availableStocks = Convert.ToInt32(retrieveCmd.ExecuteScalar());

                            MySqlCommand updateCmd = new MySqlCommand();
                            updateCmd.Connection = conn;
                            updateCmd.CommandType = CommandType.Text;
                            updateCmd.CommandText = "UPDATE products SET Quantity = @newQuantity WHERE ProductID = @productID";
                            updateCmd.Parameters.AddWithValue("@productID", productID);
                            updateCmd.Parameters.AddWithValue("@newQuantity", availableStocks - quantityOfOrder);
                            updateCmd.ExecuteNonQuery();

                            // Insert selected items into orders table
                            MySqlCommand insertCmd = new MySqlCommand();
                            insertCmd.Connection = conn;
                            insertCmd.CommandType = CommandType.Text;
                            insertCmd.CommandText = @"INSERT INTO orders(UserID, OrderDate, TotalAmount, StatusID) 
                                SELECT @userID, NOW(), TotalPrice, @statusID
                                FROM users_cart 
                                WHERE userID = @userID AND ProductID = @productID";
                            insertCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            insertCmd.Parameters.AddWithValue("@productID", productID);
                            insertCmd.Parameters.AddWithValue("@statusID", 1);
                            insertCmd.ExecuteNonQuery();

                            insertCmd.CommandText = "SELECT LAST_INSERT_ID()";
                            int orderID = Convert.ToInt32(insertCmd.ExecuteScalar());
                            insertCmd.Parameters.Clear();

                            insertCmd.CommandText = @"INSERT INTO order_details(OrderID, ProductID, Quantity, Price, Address, ModeOfPayment)
                                SELECT 
                                    @orderID, 
                                    @productID, 
                                    uc.Quantity, 
                                    p.Price,
                                    @address,
                                    @modeOfPay
                                FROM 
                                    users_cart uc
                                JOIN 
                                    products p ON uc.ProductID = p.ProductID
                                WHERE 
                                    uc.UserID = @userID AND uc.ProductID = @productID";
                            insertCmd.Parameters.AddWithValue("@orderID", orderID);
                            insertCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            insertCmd.Parameters.AddWithValue("@productID", Convert.ToInt32(productID));
                            insertCmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
                            string modeOfPay;
                            if (CodRadioButton.Checked == true)
                            {
                                modeOfPay = "COD";
                            }
                            else
                                modeOfPay = "OP";
                            insertCmd.Parameters.AddWithValue("@modeOfPay", modeOfPay);
                            insertCmd.ExecuteNonQuery();
                        }

                        // Remove selected items from users_cart table
                        foreach (int productID in ShoppingCart.AllItemsCheckoutProductIDs)
                        {
                            MySqlCommand deleteCmd = new MySqlCommand();
                            deleteCmd.Connection = conn;
                            deleteCmd.CommandType = CommandType.Text;
                            deleteCmd.CommandText = "DELETE FROM users_cart WHERE userID = @userID AND ProductID = @productID";
                            deleteCmd.Parameters.AddWithValue("@userID", Form1.userID);
                            deleteCmd.Parameters.AddWithValue("@productID", productID);
                            deleteCmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during checkout: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                    ShoppingCart.allTotalAmount -= allTotalAmount;
                    MessageBox.Show("Order successfully placed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShoppingCart.isCheckoutConfirmed = true;
                    this.Close();
                }  
            }
        cmd = new MySqlCommand();
        cmd.Connection = conn;
        conn.Open();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT Checkouts FROM users WHERE UserID = @userID";
        cmd.Parameters.AddWithValue("@userID", Form1.userID);
        int checkouts = Convert.ToInt32(cmd.ExecuteScalar());
        cmd.Parameters.Clear();
        conn.Close();

        cmd = new MySqlCommand();
        cmd.Connection = conn;
        conn.Open();
        cmd.CommandText = "UPDATE users SET Checkouts = @checkouts WHERE UserID = @userID";
        cmd.Parameters.AddWithValue("@userID", Form1.userID);
        cmd.Parameters.AddWithValue("@checkouts", checkouts + 1);
        cmd.ExecuteNonQuery();
        cmd.Parameters.Clear();
        conn.Close();
        }
    }
}
