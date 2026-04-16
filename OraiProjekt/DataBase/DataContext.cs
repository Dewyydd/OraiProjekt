using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace OraiProjekt.Database
{
    internal class DataContext
    {
        private string _server;
        private string _port;
        private string _database;
        private string _username;
        private string _password;

        public MySqlConnection Connection { get; }

        private List<Data> cars = new List<Data>();

        public DataContext()
        {
            _server = "localhost";
            _port = "3307";
            _database = "oraiprojekt";
            _username = "root";
            _password = "";

            var connectionString =
                $"server={_server};" +
                $"port={_port};" +
                $"database={_database};" +
                $"username={_username};" +
                $"password={_password}";

            Connection = new MySqlConnection(connectionString);
            cars = ExecuteQuery("SELECT * FROM cars");

        }

        public List<Data> ExecuteQuery(string query)
        {
            var res = new List<Data>();

            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    res.Add(new Data(dataReader));
                }

                dataReader.Close();
                Connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return res;
        }

        public List<Data> ReturnDB()
        {
            return cars;
        }
    }
}
