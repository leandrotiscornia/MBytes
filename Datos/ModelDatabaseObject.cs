using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class ModelDataBaseObject : ModelConnection
    {
        public string tableName { get; set; }
        public string objectKey { get; set; }
        public string objectKeyValue { get; set; }
        public string[] columnNames { get; set; }
        public string[] objectValues { get; set; }
        




        


        public void insertObject()
        {
            string commandString;
            commandString = "INSERT INTO " + tableName + "("; 
            foreach (string column in columnNames) 
                commandString += column + ",";
            commandString = commandString.Remove(commandString.Length - 1, 1); 
            commandString += ") VALUES ("; 
            foreach (string column in columnNames) 
                commandString += "@" + column + ",";
            commandString = commandString.Remove(commandString.Length - 1, 1); 
            commandString += ");"; 

            command.CommandText = commandString;
            var columnsAndValues = columnNames.Zip(objectValues, (c, v) => new {Column = c, Value = v} );
            
            foreach (var index in columnsAndValues)
                command.Parameters.AddWithValue("@" + index.Column, index.Value);
            Console.WriteLine(""+commandString);
            foreach (string value in objectValues)
                Console.WriteLine("" + value);
            
            openConnection();
            command.Prepare();
            
            //.ExecuteNonQuery();
            command.Parameters.Clear();
            closeConnection();
        }
        public void deleteObject()
        {
            string commandString;
            commandString = "DELETE FROM " + tableName + " WHERE ID=@objectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@objectId", objectKey);
            command.Prepare();
            command.ExecuteNonQuery();
        }
        public void modifyObject()
        {
            string commandString;
            var columnsAndValues = columnNames.Zip(objectValues, (c, v) => new { Column = c, Value = v });
            commandString = "UPDATE " + tableName + " SET ";
            foreach (var index in columnsAndValues)
                commandString += index.Column + "=" + index.Value + "," ;
            commandString = commandString.Remove(commandString.Length - 1, 1);
            commandString = "WHERE id= @objectId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("objectId", objectKey);
            command.Prepare();
            openConnection();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            closeConnection();
            

        }
        public DataTable listObjects ()
        {
            DataTable objectsData = new DataTable();
            //builds SQL SELECT command
            string commandString;
            commandString = "SELECT ";
            foreach (string column in columnNames)
                commandString += column + ",";
            commandString = commandString.Remove(commandString.Length - 1, 1); //deletes last comma
            commandString += " FROM " + tableName +";";
            //saves SQL command result in DataTable
            command.CommandText = commandString;
            openConnection();
            reader = command.ExecuteReader();
            objectsData.Load(reader);
            closeConnection();
            return objectsData;
        }

        public string checkObjectExistence()
        {
            string result;
            string commandString;
            commandString = 
                "SELECT "+ this.objectKey+ " "+ 
                "FROM " + this.tableName + " " +
                "WHERE " +this.objectKey +"=@objectKeyValue";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("objectKeyValue", objectKeyValue);
            openConnection();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                result = reader.GetString(0);
            else
                result = null;
            command.Parameters.Clear();
            closeConnection();
            return result;
        }

        
    }
}
