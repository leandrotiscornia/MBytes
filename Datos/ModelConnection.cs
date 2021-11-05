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
        public void setConnectionData(string dbUser, string dbPort, string dbPassword)
        {
            DataBase.Default.dbUser = dbUser;
            DataBase.Default.dbPassword = dbPassword;
            DataBase.Default.dbPort = dbPort;
            DataBase.Default.Save();
            this.dbUser = DataBase.Default.dbUser;
            this.dbPort = DataBase.Default.dbPort;
            this.dbPassword = DataBase.Default.dbPassword;
        }
        public void setDefaultConnection()
        {
            DataBase.Default.Reset();
        }

        public void openConnection()
        {
            command.Connection = connection;
            connection.ConnectionString =
                "server=" + dbServer + ";" +
                "port=" + dbPort + ";" +
                "userid=" + dbUser + ";" +
                "password=" + dbPassword + ";" +
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
                if (reader != null) reader.Close();
                command.Prepare();
                command.ExecuteNonQuery();
                Console.WriteLine(command.CommandText);
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
                handleException(ex);
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
                handleException(ex);
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
                handleException(ex);
            }
            return result;
        }
        public int readInt(int index)
        {
            int result = -1;
            try
            {
                reader.Read();
                if (reader.HasRows && !reader.IsDBNull(index)) result = reader.GetInt32(index);
                else throw new Exception("Null Number");
            }
            catch (MySqlException ex)
            {
                handleException(ex);
            }
            return result;
        }

        public void handleException(MySqlException ex)
        {
            Console.WriteLine(ex.Message);
            int exceptionNumber;
            if (ex.InnerException != null && ex.InnerException is MySqlException)
                exceptionNumber = ((MySqlException)ex.InnerException).Number;
            else
                exceptionNumber = ex.Number;
            int indexFrom;
            int indexTo;
            switch (exceptionNumber)
            {
                case 0:
                    throw new Exception("Cannot Connect To Server", ex);
                case 1042:
                    throw new Exception("Access To Server Dennied", ex);
                case 1045:
                    throw new Exception("Incorrect Database Credentials", ex);
                case 1049:
                    throw new Exception("Unknown Database", ex);
                case 1054:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("Column " + ex.Message.Substring(indexFrom, indexTo) + " Does Not Exist", ex);
                case 1064:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("SQL Syntax Error At: " + ex.Message.Substring(indexFrom, indexTo), ex);
                case 1146:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("Table " + ex.Message.Substring(indexFrom, indexTo) + " Does Not Exist", ex);
                case 1406:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.LastIndexOf("'") - indexFrom;
                    throw new Exception("Field Value Too Long For Table " + ex.Message.Substring(indexFrom, indexTo), ex);
                case 1452:
                    throw new Exception("Foregin Key Constraint Error", ex);
                default:
                    throw new Exception("UNHADLED INTERNAL EXCEPTION: " + ex.Message, ex);
            }
        }
    }
}