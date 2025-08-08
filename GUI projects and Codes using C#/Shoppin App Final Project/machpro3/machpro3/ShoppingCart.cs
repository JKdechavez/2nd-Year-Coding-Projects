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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MachPro3
{
    public partial class ShoppingCart : Form
    {
        private DataTable AllItemsTable;
        string selectedItemName = "";
        double selectedItemPrice = 0;
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        public static List<int> AllItemsCheckoutProductIDs = new List<int>();
        public static List<int> selectiveCheckoutProductIDs = new List<int>();
        public static string typeOfCheckout = "";
        public static bool isCheckoutConfirmed = false;
        public static double allTotalAmount = 0;
        public static double selectTotalAmount = 0;
        public ShoppingCart()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            InitializeDataTable();
            this.BackColor = Color.DarkTurquoise;
        }
        private int GetProductIDByName(string productName)
        {
            int productID = -1;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ProductID FROM products WHERE Name = @name";
            cmd.Parameters.AddWithValue("@name", productName);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                productID = reader.GetInt32(0);
            }
            conn.Close();
            return productID;
        }
        private string GetProductNameByID(int productID)
        {
            string name = "";
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM products WHERE ProductID = @productID";
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString(0);
            }
            conn.Close();
            return name;
        }
        private double GetTotalByID(int productID)
        {
            double totalAmount = 0;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalPrice FROM users_cart WHERE userID = @userID AND ProductID = @productID";
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                totalAmount = reader.GetDouble(0);
            }
            conn.Close();
            return totalAmount;
        }
        private void UpdateQuantiButton_Click(object sender, EventArgs e)
        {
            //get product id using name of product
            /*cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ProductID FROM products WHERE Name = @name";
            cmd.Parameters.AddWithValue("@name", selectedItemName);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int productID = reader.GetInt32(0);
            conn.Close();*/
            int productID = GetProductIDByName(selectedItemName);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users_cart SET Quantity = @quantity, TotalPrice = @totalprice WHERE userID = @userID AND ProductID = @productID";
            cmd.Parameters.AddWithValue("@quantity", CartQuantiOfSelectItemTextBox.Text);
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            double newPrice = Convert.ToDouble(CartQuantiOfSelectItemTextBox.Text) * selectedItemPrice;
            cmd.Parameters.AddWithValue("@totalprice", newPrice);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.ExecuteNonQuery();
            if (AllItemsInCartDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = AllItemsInCartDataGridView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = AllItemsInCartDataGridView.SelectedRows[0];
                selectedRow.Cells["Quantity"].Value = CartQuantiOfSelectItemTextBox.Text;
                selectedRow.Cells["TotalPrice"].Value = $"{newPrice: 0.00}";
                AllItemsInCartDataGridView.Refresh();
                CartQuantiOfSelectItemTextBox.Text = selectedRow.Cells["Quantity"].Value.ToString();
            }
            conn.Close();

            // update total price in textbox
            AllItemsInCartDataGridView.DataSource = AllItemsTable;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalPrice FROM users_cart WHERE userID = @userID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader priceReader = cmd.ExecuteReader();
            allTotalAmount = 0;
            while (priceReader.Read())
            {
                double totalAmount = Convert.ToDouble(priceReader["TotalPrice"]);
                allTotalAmount += totalAmount;
            }
            TotalCartItemPriceTextBox.Text = $"{allTotalAmount: 0.00}";
            conn.Close();
            selectTotalAmount = 0;
            foreach (int itemID in selectiveCheckoutProductIDs) 
            {
                selectTotalAmount += Convert.ToDouble(GetTotalByID(itemID));
            }
            TotalSelectPriceTextBox.Text = $"{selectTotalAmount: 0.00}";
            CartQuantiOfSelectItemTextBox.Clear();
        }
        Form1 mainInterface;
        private void ShoppingCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            allTotalAmount = 0;
            selectTotalAmount = 0;
            selectiveCheckoutProductIDs.Clear();
            AllItemsCheckoutProductIDs.Clear();
            mainInterface = new Form1();
            mainInterface.Show();

        }
        public static CheckOut checkOut;
        private void CheckOutAllButton_Click(object sender, EventArgs e)
        {
            if (checkOut == null)
            {
                foreach (DataGridViewRow row in AllItemsInCartDataGridView.Rows)
                {
                    string productName = row.Cells["Name"].Value?.ToString();
                    if (!string.IsNullOrEmpty(productName))
                    {
                        int productID = GetProductIDByName(productName);
                        AllItemsCheckoutProductIDs.Add(productID);
                    }
                }
                if (AllItemsCheckoutProductIDs.Count == 0)
                {
                    MessageBox.Show("No product items in your cart!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    typeOfCheckout = "all";
                    checkOut = new CheckOut();
                    checkOut.MdiParent = this.MdiParent;
                    checkOut.FormClosed += new FormClosedEventHandler(checkOutWindow_FormClosed);
                    checkOut.Show();
                    this.Hide();
                }
            }
            else
                checkOut.Activate();
        }
        private void checkOutWindow_FormClosed(object sender, EventArgs e)
        {
            checkOut = null;
            if (isCheckoutConfirmed == true) 
            {
                if (typeOfCheckout == "all") 
                {
                    foreach (int productID in AllItemsCheckoutProductIDs)
                    {
                        string itemName = GetProductNameByID(productID);
                        DataRow[] rowsToDelete = AllItemsTable.Select($"Name = '{itemName}'");
                        foreach (DataRow row in rowsToDelete)
                        {
                            AllItemsTable.Rows.Remove(row);
                        }
                    }
                    AllItemsInCartDataGridView.DataSource = null; // Temporarily set to null to force update
                    AllItemsInCartDataGridView.DataSource = AllItemsTable;
                    AllItemsCheckoutProductIDs.Clear();
                    TotalSelectPriceTextBox.Clear();
                    TotalCartItemPriceTextBox.Text = $"{allTotalAmount: 0.00}";
                }
                else 
                {
                    foreach (int productID in selectiveCheckoutProductIDs)
                    {
                        string itemName = GetProductNameByID(productID);
                        DataRow[] rowsToDelete = AllItemsTable.Select($"Name = '{itemName}'");
                        foreach (DataRow row in rowsToDelete)
                        {
                            AllItemsTable.Rows.Remove(row);
                        }
                    }
                    AllItemsInCartDataGridView.DataSource = null; // Temporarily set to null to force update
                    AllItemsInCartDataGridView.DataSource = AllItemsTable;
                    SelectiveCheckoutListBox.Items.Clear();
                    selectiveCheckoutProductIDs.Clear();
                    TotalSelectPriceTextBox.Clear();
                    TotalCartItemPriceTextBox.Text = $"{allTotalAmount: 0.00}";
                }
            }
            typeOfCheckout = "";
            isCheckoutConfirmed = false;
            this.Show();
        }

        private void CheckOutSelectItemsButton_Click(object sender, EventArgs e)
        {
            if (checkOut == null)
            {
                if (selectiveCheckoutProductIDs.Count == 0)
                {
                    MessageBox.Show("No selected items!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    typeOfCheckout = "selective";
                    checkOut = new CheckOut();
                    checkOut.MdiParent = this.MdiParent;
                    checkOut.FormClosed += new FormClosedEventHandler(checkOutWindow_FormClosed);
                    checkOut.Show();
                    this.Hide();
                }
            }
            else
                checkOut.Activate();
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            AllItemsInCartDataGridView.DataSource = AllItemsTable;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalPrice FROM users_cart WHERE userID = @userID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader priceReader = cmd.ExecuteReader();
            while (priceReader.Read())
            {
                double totalAmount = Convert.ToDouble(priceReader["TotalPrice"]);
                allTotalAmount += totalAmount;
            }
            TotalCartItemPriceTextBox.Text = $"{allTotalAmount: 0.00}";
            conn.Close();
        }
        private void InitializeDataTable()
        {
            /*AllItemsTable = new DataTable();
            AllItemsTable.Columns.Add("Product Name", typeof(string));
            AllItemsTable.Columns.Add("Price", typeof(double));
            AllItemsTable.Columns.Add("Quantity", typeof(int));
            AllItemsTable.Columns.Add("Total Amount", typeof(double));*/

            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                    SELECT 
                        p.Name, 
                        p.Price, 
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
            AllItemsTable = new DataTable();
            AllItemsTable.Load(reader);
            AllItemsInCartDataGridView.Refresh();
            // sample adding
            // dataTable.Rows.Add(4413, "John Kevin", "De Chavez", "09309445804", "jkdechavez31@gmail.com");
            cmd.Parameters.Clear();
            conn.Close();

        }
        private void AllItemsInCartDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (AllItemsInCartDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AllItemsInCartDataGridView.SelectedRows[0];
                CartQuantiOfSelectItemTextBox.Text = selectedRow.Cells["Quantity"].Value.ToString();
                selectedItemName = selectedRow.Cells["Name"].Value.ToString();
                selectedItemPrice = Convert.ToDouble(selectedRow.Cells["Price"].Value);
            }
        }

        private void CartQuantiOfSelectItemTextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.SelectAll();
            }
        }

        private void RemoveInCartButton_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ProductID FROM products WHERE Name = @name";
            cmd.Parameters.AddWithValue("@name", selectedItemName);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int productID = reader.GetInt32(0);
            conn.Close();

            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM users_cart WHERE userID = @userID AND ProductID = @productID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.ExecuteNonQuery();
            conn.Close();
            selectiveCheckoutProductIDs.Remove(productID);
            SelectiveCheckoutListBox.Items.Remove(GetProductNameByID(productID));
            DataRow[] rowsToDelete = AllItemsTable.Select($"Name = '{selectedItemName}'");
            foreach (DataRow row in rowsToDelete)
            {
                AllItemsTable.Rows.Remove(row);
            }
            // Refresh the DataGridView
            AllItemsInCartDataGridView.Refresh();
            CartQuantiOfSelectItemTextBox.Clear();

            // update total price in textbox
            AllItemsInCartDataGridView.DataSource = AllItemsTable;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalPrice FROM users_cart WHERE userID = @userID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader priceReader = cmd.ExecuteReader();
            allTotalAmount = 0;
            while (priceReader.Read())
            {
                double totalAmount = Convert.ToDouble(priceReader["TotalPrice"]);
                allTotalAmount += totalAmount;
            }
            TotalCartItemPriceTextBox.Text = $"{allTotalAmount: 0.00}";
            conn.Close();
            selectTotalAmount = 0;
            foreach (int itemID in selectiveCheckoutProductIDs)
            {
                selectTotalAmount += Convert.ToDouble(GetTotalByID(itemID));
            }
            TotalSelectPriceTextBox.Text = $"{selectTotalAmount: 0.00}";
        }

        private void AddToSelectButton_Click(object sender, EventArgs e)
        {
            if (AllItemsInCartDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AllItemsInCartDataGridView.SelectedRows[0];
                int productID = GetProductIDByName(selectedItemName);
                selectTotalAmount += GetTotalByID(productID);
                // Add the product ID to the list
                selectiveCheckoutProductIDs.Add(productID);

                // Add the product name to the ListBox for display
                SelectiveCheckoutListBox.Items.Add(selectedItemName);
            }
            TotalSelectPriceTextBox.Text = $"{selectTotalAmount: 0.00}";

        }
    }
}
