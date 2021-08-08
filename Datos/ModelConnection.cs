using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            openConnection();
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
            catch (MySqlException ex)
            {
               handleException(ex);
            }
        }
        public void executeVoid()
        {
            try
            {
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                handleException(ex);
            }
            finally
            {
                command.Parameters.Clear();
                Console.WriteLine(command.CommandText);
            }
        }
        
        public void executeAndRead()
        {
            try
            {
                command.Prepare();
                if (reader != null) reader.Close();
                reader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                throw ex;//handleException(ex);
            }
            finally
            {
                command.Parameters.Clear();
            }
        }
        public DataTable readTable()
        {
            DataTable result = new DataTable();
            try
            {
                if (reader.HasRows) result.Load(reader);
            }
            catch (MySqlException ex)
            {
                throw ex;//handleException(ex);
            }
            finally
            {
                command.Parameters.Clear();
            }
            return result;
        }
        public string readString(int index)
        {
            string result = "";
            try
            {
                reader.Read();
                if (reader.HasRows && !reader.IsDBNull(index)) result = reader.GetString(index);
                else return null;
            }
            catch (MySqlException ex)
            {
                throw ex;// handleException(ex);
            }
            return result;
        }
        public int readInt(int index)
        {
            int result = -1;
            try
            {
                while (reader.Read())
                if (reader.HasRows && !reader.IsDBNull(index)) result = reader.GetInt32(index);
                else throw new Exception("Null Number");
            }
            catch (MySqlException ex)
            {
                throw ex;// handleException(ex);
            }
            return result;
        }

        public void handleException(MySqlException ex)
        {
            Console.WriteLine(ex.ToString());
            throw ex;
        }
    }
}