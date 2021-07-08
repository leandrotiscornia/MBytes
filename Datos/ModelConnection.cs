using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

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

        private DataBase connectionConfigFile = new DataBase();
        
        public ModelConnection()
        {
            
            command = new MySqlCommand();
            connection = new MySqlConnection();
            dbServer = DataBase.Default.dbServer;
            dbPort = DataBase.Default.dbPort;
            dbName = DataBase.Default.dbName;
            dbUser = DataBase.Default.dbUser;
            dbPassword = DataBase.Default.dbPassword;
            
        }
        public void setConnectionUser()
        {
            DataBase.Default.dbUser = dbName;
            DataBase.Default.dbPassword = dbPassword;
        }
        public void setConnectionData()
        {
            DataBase.Default.dbName = dbName;
            DataBase.Default.dbServer = dbServer;
            DataBase.Default.dbPort = dbPort;
        }
        public void openConnection()
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
                Console.WriteLine("Conexión abierta");
            }
            catch (MySqlException exception)
            {
                Console.WriteLine("" + exception);
                
            }

        }
        public void closeConnection()
        {
            connection.Close();
            Console.WriteLine("Conexión cerrada");
        }
    }
}