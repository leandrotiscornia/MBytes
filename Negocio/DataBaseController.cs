using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class DataBaseController
    {
        public static void setConnection(string dbUser, string dbPassword, string dbPort)
        {
            ModelConnection connection = new ModelConnection();
            connection.setConnectionData(dbUser, dbPort, dbPassword);
        }
        public static void setDefaultConnection()
        {
            ModelConnection connection = new ModelConnection();
            connection.setDefaultConnection();
        }
        public static string checkExistence(string tableName, string objectKey, string objectKeyValue)
        {
            string result;
            ModelDataBaseObject objectToCheck = new ModelDataBaseObject();
            objectToCheck.objectKey = objectKey;
            objectToCheck.tableName = tableName;
            objectToCheck.objectKeyValue = objectKeyValue;
            result = objectToCheck.checkObjectExistence();
            return result;
        }
        public static string encryptPassword(string password)
        {
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(password);
            password = Convert.ToBase64String(encrypted);
            return password;
        }
        public static string decryptPassword(string password)
        {
            byte[] decrypted = Convert.FromBase64String(password);
            password = Encoding.Unicode.GetString(decrypted);
            return password;
        }
    }

    



}
