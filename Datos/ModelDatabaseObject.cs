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
            executeVoid();
        }
        public void deleteObject()
        {
            string commandString;
            commandString = "DELETE FROM " + tableName + " WHERE ID=@objectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@objectId", objectKey);
            executeVoid();
        }
        public void modifyObject()
        {
            string commandString;
            commandString = "UPDATE " + tableName + " SET ";
            foreach (string column in columnNames)
                commandString += column + " = @" + column + "," ;
            commandString = commandString.Remove(commandString.Length - 1, 1);
            commandString += " WHERE id= @objectId";
            command.CommandText = commandString;
            var columnsAndValues = columnNames.Zip(objectValues, (c, v) => new { Column = c, Value = v });
            foreach (var index in columnsAndValues)
                command.Parameters.AddWithValue("@"+index.Column ,index.Value);
            command.Parameters.AddWithValue("objectId", objectKey);
            executeVoid();
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
            executeAndRead();
            return readTable();
        }

        public string checkObjectExistence()
        {
            string commandString;
            commandString = 
                "SELECT "+ this.objectKey+ " "+ 
                "FROM " + this.tableName + " " +
                "WHERE " +this.objectKey +"=@objectKeyValue";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("objectKeyValue", objectKeyValue);
            executeAndRead();
            return readString(0);
        }
        
        
    }
}
