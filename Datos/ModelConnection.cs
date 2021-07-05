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
        public string dbName { get; set; }
        public string dbUser { get; set; }
        public string dbPassword { get; set; }
        public string dbPort { get; set; }
        public string dbServer { get; set; }
        public MySqlCommand command { get; set; }
        public MySqlDataReader reader { get; set; }
        public MySqlConnection connection { get; set; }

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