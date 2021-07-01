using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ModelConnection
    {
        private string _dbName;
        private string _dbUser;
        private string _dbPassword;
        private string _dbPort;
        private string _dbServer;
        private MySqlCommand _command;
        private MySqlDataReader _reader;
        private MySqlConnection _connection;

        public string dbName
        {
            get { return _dbName; }
            set { _dbName = value; }
        }
        public string dbUser
        {
            get { return _dbUser; }
            set { _dbUser = value; }
        }
        public string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }
        public string dbPort
        {
            get { return _dbPort; }
            set { _dbPort = value; }
        }
        public string dbServer
        {
            get { return _dbServer; }
            set { _dbServer = value; }
        }
        public MySqlCommand command
        {
            get { return _command; }
            set { _command = value; }
        }
        public MySqlDataReader reader
        {
            get { return _reader; }
            set { _reader = value; }
        }
        public MySqlConnection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public MySqlConnection openConnection()
        {
            command.Connection = connection;
            connection.ConnectionString =
                "server=" + dbServer + "; " +
                "port=" + dbPort + "; " +
                "userid=" + dbUser + "; " +
                "password=" + dbPassword + "; " +
                "database=" + dbName + ";";
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException exception)
            {
                Console.WriteLine("" + exception);
                return null;
            }

        }
        public void closeConnection()
        {
            connection.Close();
        }
    }
}