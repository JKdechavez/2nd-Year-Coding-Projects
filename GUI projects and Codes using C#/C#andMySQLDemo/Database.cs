using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C_andMySQLDemo
{
    internal class Database
    {
        private MySqlConnection _connection;
        private MySqlCommand _command;
        private MySqlDataReader _reader;

        public Database()
        {
            _connection = new MySqlConnection("server=localhost;user id=root;password=PASSWORDpassword;database=northwind;port=3306");
            _command = new MySqlCommand();
            _command.Connection = _connection;
            _command.CommandType = System.Data.CommandType.Text;

        }

        public MySqlConnection Connection { get { return _connection; } }
        public MySqlCommand Command { get { return _command; } }
        public MySqlDataReader Reader { 
            get { return _reader; } 
            set { _reader = value; }
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}
