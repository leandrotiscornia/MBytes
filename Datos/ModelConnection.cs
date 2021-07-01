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
        private MySqlCommand _command = new MySqlCommand();
        private MySqlDataReader _reader = new MySqlDataReader();
        private MySqlConnection _connection = new MySqlConnection();

        public string dbName 
        {
            get {return _dbName;}
            set {_dbName = value;}
        }
        public string dbUser
        {
            get {return _dbUser;}
            set {_dbUser = value;}
        }
        public string dbPassword 
        {
            get {return _dbPassword;}
            set {_dbPassword = value;}
        }
        public string dbPort 
        {
            get {return _dbPassword;}
            set {_dbPassword = value;}
        }
        public string dbServer
        {
            get {return _dbServer;}
            set {_dbSerber = value;}
        }
        public MySqlCommand command 
        {
            get {return _command;}
            set {_command = value;}
        }
        public MySqlDataReader reader 
        {
            get {return _reader;}
            set {_reader = value;}
        }
        public MySqlConnection connection 
        {
            get {return _connection;}
            set {_connection = value;}
        }

        public void openConnecion()
        {

        }

    }
}
