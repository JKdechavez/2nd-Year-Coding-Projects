using Lab18;
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
    public partial class Admin : Form
    {
        private DataTable AllItemsTable;
        private DataTable AllIOrdersTable;
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        string selectedProdName = "";
        string[] statuses = { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" };
        int selectedProductID = 0;
        int selectedUserID = 0;
        public Admin()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            InitializeProductsDataTable();
            InitializeOrdersDataTable();
            this.BackColor = Color.DarkTurquoise;
        }
        private void ClearAllTextBoxes() 
        {
            AdminProductNameTextBox.Clear();
            AdminPriceTextBox.Clear();
            AdminAvailableStocksTextBox.Clear();
            AdminDescriptionTextBox.Clear();
            ImageURLTextBox.Clear();
        }
        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (statuses.Contains(ChangeOrderStatTextBox.Text))
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT StatusID FROM order_statuses WHERE StatusName = @statusName";
                    cmd.Parameters.AddWithValue("@statusName", ChangeOrderStatTextBox.Text);
                    int statusID = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"{statusID}");
                    cmd.Parameters.Clear();
                    conn.Close();

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE orders SET StatusID = @statusID WHERE OrderID = @orderID AND UserID = @userID";
                    cmd.Parameters.AddWithValue("@statusID", statusID);
                    cmd.Parameters.AddWithValue("@orderID", selectedProductID);
                    MessageBox.Show($"{selectedProductID}");
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    MessageBox.Show($"{Form1.userID}");
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // Refresh the table
                    AllIOrdersTable = null;
                    InitializeOrdersDataTable();
                    AdminChangeStatusOrderDataGridView.DataSource = AllItemsTable;
                    ChangeOrderStatTextBox.Clear();
                    MessageBox.Show("Order status successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid order status!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show($"Error during update status: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        Reports reportInterface;
        private void GenerateReportsButton_Click(object sender, EventArgs e)
        {
            if (reportInterface == null)
            {
                reportInterface = new Reports();
                reportInterface.MdiParent = this.MdiParent;
                reportInterface.FormClosed += new FormClosedEventHandler(ReportInterface_FormClosed);
                reportInterface.Show();
                this.Hide();
            }
            else
                reportInterface.Activate();
        }
        private void ReportInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportInterface = null;
            this.Show();
        }

        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeProductsDataTable()
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
                        Name, Description, Price, Quantity, ImageURL
                    FROM 
                        products";
            MySqlDataReader reader = cmd.ExecuteReader();
            AllItemsTable = new DataTable();
            AllItemsTable.Load(reader);
            AdminModifyDataGridView.Refresh();
            // sample adding
            // dataTable.Rows.Add(4413, "John Kevin", "De Chavez", "09309445804", "jkdechavez31@gmail.com");
            conn.Close();
        }

        private void InitializeOrdersDataTable()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                    SELECT 
                        o.OrderID,
                        o.UserID,
                        p.Name, 
                        o.TotalAmount, 
                        od.Address,
                        os.StatusName
                    FROM 
                        orders o
                    INNER JOIN 
                        order_details od ON o.OrderID = od.OrderID
                    INNER JOIN 
                        products p ON od.ProductID = p.ProductID
                    INNER JOIN
                        order_statuses os ON o.StatusID = os.StatusID";
            MySqlDataReader reader = cmd.ExecuteReader();
            AllIOrdersTable = new DataTable();
            AllIOrdersTable.Load(reader);
            AdminChangeStatusOrderDataGridView.Refresh();
            // sample adding
            // dataTable.Rows.Add(4413, "John Kevin", "De Chavez", "09309445804", "jkdechavez31@gmail.com");
            cmd.Parameters.Clear();
            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminModifyDataGridView.DataSource = AllItemsTable;
            AdminChangeStatusOrderDataGridView.DataSource = AllIOrdersTable;
        }

        private void AdminModifyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminModifyDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AdminModifyDataGridView.SelectedRows[0];
                AdminProductNameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                AdminDescriptionTextBox.Text = selectedRow.Cells["Description"].Value.ToString();
                AdminPriceTextBox.Text = $"{Convert.ToDouble(selectedRow.Cells["Price"].Value):0.00}";
                AdminAvailableStocksTextBox.Text = selectedRow.Cells["Quantity"].Value.ToString();
                ImageURLTextBox.Text = selectedRow.Cells["ImageURL"].Value.ToString();
                AdminProductPictureBox.Image = new Bitmap(selectedRow.Cells["ImageURL"].Value.ToString());
                selectedProdName = selectedRow.Cells["Name"].Value.ToString();
            }
        }

        private void ClearAllDetailsButton_Click(object sender, EventArgs e)
        {
            AdminProductNameTextBox.Clear();
            AdminDescriptionTextBox.Clear();
            AdminPriceTextBox.Clear();
            AdminAvailableStocksTextBox.Clear();
            ImageURLTextBox.Clear();
        }

        private void AdminAddNewProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select an image file";
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                string imageURL = "";
                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the selected image path
                    imageURL = openFileDialog.FileName;

                    // Load the image into the PictureBox
                    AdminProductPictureBox.Image = new Bitmap(imageURL);
                }
                ImageURLTextBox.Text = imageURL;
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO products(Name, Description, Price, Quantity, ImageURL) VALUES (@name, @description, @price, @quantity, @imageURL)";
                cmd.Parameters.AddWithValue("@name", AdminProductNameTextBox.Text);
                cmd.Parameters.AddWithValue("@description", AdminDescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(AdminPriceTextBox.Text));
                cmd.Parameters.AddWithValue("@quantity", AdminAvailableStocksTextBox.Text);
                cmd.Parameters.AddWithValue("@imageURL", ImageURLTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Refresh the table
                AllItemsTable = null;
                InitializeProductsDataTable();
                AdminModifyDataGridView.DataSource = AllItemsTable;
                ClearAllTextBoxes();
                MessageBox.Show("Product successfully added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during adding product: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void AdminDelProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM products WHERE Name = @name";
                cmd.Parameters.AddWithValue("@name", AdminProductNameTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Refresh the table
                AllItemsTable = null;
                InitializeProductsDataTable();
                AdminModifyDataGridView.DataSource = AllItemsTable;
                ClearAllTextBoxes();
                MessageBox.Show("Product successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deleting product: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }


        }

        private void AdminUpdateProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE products SET Name = @name, Description = @description, Price = @price, Quantity = @quantity, ImageURL = @imageURL WHERE Name = @selectedName";
                cmd.Parameters.AddWithValue("@name", AdminProductNameTextBox.Text);
                cmd.Parameters.AddWithValue("@description", AdminDescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(AdminPriceTextBox.Text));
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(AdminAvailableStocksTextBox.Text));
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select an image file";
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                string imageURL = "";
                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the selected image path
                    imageURL = openFileDialog.FileName;

                    // Load the image into the PictureBox
                    AdminProductPictureBox.Image = new Bitmap(imageURL);
                }
                ImageURLTextBox.Text = imageURL;
                cmd.Parameters.AddWithValue("@imageURL", ImageURLTextBox.Text);
                cmd.Parameters.AddWithValue("@selectedName", selectedProdName);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Refresh the table
                AllItemsTable = null;
                InitializeProductsDataTable();
                AdminModifyDataGridView.DataSource = AllItemsTable;
                ClearAllTextBoxes();
                MessageBox.Show("Product details successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during updating product: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void AdminChangeStatusOrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminChangeStatusOrderDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AdminChangeStatusOrderDataGridView.SelectedRows[0];
                ChangeOrderStatTextBox.Text = selectedRow.Cells["StatusName"].Value.ToString();
                selectedProductID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);
                selectedUserID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
            }
        }

        private void MarkDeliveredButton_Click(object sender, EventArgs e)
        {
            try 
            {
                DataGridViewRow selectedRow = AdminChangeStatusOrderDataGridView.SelectedRows[0];
                if (AdminChangeStatusOrderDataGridView.CurrentRow != null)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE orders SET StatusID = 4 WHERE OrderID = @orderID AND UserID = @userID";
                    cmd.Parameters.AddWithValue("@orderID", selectedProductID);
                    cmd.Parameters.AddWithValue("@userID", selectedUserID);
                    cmd.ExecuteNonQuery();
                    
                    // Refresh the table
                    AllIOrdersTable = null;
                    InitializeOrdersDataTable();
                    AdminChangeStatusOrderDataGridView.DataSource = AllItemsTable;
                    ChangeOrderStatTextBox.Clear();
                    MessageBox.Show("Order status successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No selected order!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
            catch (Exception ex )
            {
                MessageBox.Show($"Error during updating order: {ex.Message}");
            } 
            finally 
            {
                conn.Close();
            }


        }
    }
}

