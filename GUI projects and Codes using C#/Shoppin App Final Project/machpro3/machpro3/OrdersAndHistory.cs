using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab18;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MachPro3
{
    public partial class OrdersAndHistory : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=online_shopping_data;Uid=root;Pwd=PASSWORDpassword;";
        MySqlConnection conn;
        MySqlCommand cmd;
        private DataTable OrderHistory;
        private DataTable OrderStatuses;
        public OrdersAndHistory()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString);
            OrderHistory_Load();
            OrderStatuses_Load();
        }

        private void OrdersAndHistory_Load(object sender, EventArgs e)
        {
            OrderStatusesDataGridView.DataSource = OrderStatuses;
            OrderHistoryDataGridView.DataSource = OrderHistory;
        }
        private void OrderStatuses_Load()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                    SELECT
                        p.Name,
                        o.TotalAmount,
                        os.StatusName
                    FROM
                        orders o
                    JOIN
                        order_details od ON o.OrderID = od.OrderID
                    JOIN
                        products p ON od.ProductID = p.ProductID
                    JOIN
                        order_statuses os ON o.StatusID = os.StatusID
                    WHERE
                        o.userID = @userID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader reader = cmd.ExecuteReader();
            OrderStatuses = new DataTable();
            OrderStatuses.Load(reader);
            cmd.Parameters.Clear();
            conn.Close();
        }
        private void OrderHistory_Load() 
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                    SELECT
                        p.Name,
                        od.Quantity,
                        o.TotalAmount,
                        DATE_FORMAT(o.OrderDate, '%m-%d-%y') AS Date,
                        DATE_FORMAT(o.OrderDate, '%H:%i') AS Time
                    FROM
                        orders o
                    JOIN
                        order_details od ON o.OrderID = od.OrderID
                    JOIN
                        products p ON od.ProductID = p.ProductID
                    WHERE
                        o.userID = @userID";
            cmd.Parameters.AddWithValue("@userID", Form1.userID);
            MySqlDataReader reader = cmd.ExecuteReader();
            OrderHistory = new DataTable();
            OrderHistory.Load(reader);
            cmd.Parameters.Clear();
            conn.Close();
            
        }
    }
}
