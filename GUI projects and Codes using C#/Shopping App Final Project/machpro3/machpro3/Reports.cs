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
    public partial class Reports : Form
    {
        private DataTable InventoryReportTable;
        private DataTable SalesReportTable;
        private DataTable UserActivityReportTable;
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        public Reports()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            InitializeInventoryReport();
            InitializeSalesReport();
            InitializeUserActivityReport();
            this.BackColor = Color.DarkTurquoise;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeInventoryReport()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name, Quantity FROM products";
            MySqlDataReader reader = cmd.ExecuteReader();
            InventoryReportTable = new DataTable();
            InventoryReportTable.Load(reader);
            InventoryReportDataGridView.Refresh();
            conn.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            InventoryReportDataGridView.DataSource = InventoryReportTable;
            SalesReportDataGridView.DataSource = SalesReportTable;
            UserActReportDataGridView.DataSource = UserActivityReportTable;
        }

        private void InitializeSalesReport()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                    SELECT 
                        p.Name, 
                        od.Quantity,
                        o.TotalAmount
                    FROM 
                        orders o
                    INNER JOIN 
                        order_details od ON o.OrderID = od.OrderID
                    INNER JOIN 
                        products p ON od.ProductID = p.ProductID";
            MySqlDataReader reader = cmd.ExecuteReader();
            SalesReportTable = new DataTable();
            SalesReportTable.Load(reader);
            SalesReportDataGridView.Refresh();
            conn.Close();
            
            // Get Total revenue
            double totalSum = 0;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalAmount FROM orders";
            MySqlDataReader amountReader = cmd.ExecuteReader();
            while (amountReader.Read())
            {
                double amount;
                if (double.TryParse(amountReader["TotalAmount"].ToString(), out amount))
                {
                    totalSum += amount;
                }
            }
            conn.Close();
            TotalRevenueTextBox.Text = $"{totalSum:0.00}";

            // Get Total number of Items sold
            int totalQuantity = 0;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Quantity FROM order_details";
            MySqlDataReader NumItemsReader = cmd.ExecuteReader();
            while (NumItemsReader.Read())
            {
                int quantity;
                if (int.TryParse(NumItemsReader["Quantity"].ToString(), out quantity))
                {
                    totalQuantity += quantity;
                }
            }
            conn.Close();
            TotalNumItemsSoldTextBox.Text = $"{totalQuantity}";


        }
        
        private void InitializeUserActivityReport() 
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT UserID, Username, Role, Logins, Checkouts FROM users";
            MySqlDataReader reader = cmd.ExecuteReader();
            UserActivityReportTable = new DataTable();
            UserActivityReportTable.Load(reader);
            UserActReportDataGridView.Refresh();
            conn.Close();
        }
    }
}
