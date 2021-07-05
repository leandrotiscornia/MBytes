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
        public string[] columnNames { get; set; }
        public string[] objectValues { get; set; }
        public string objectKey { get; set; }

        public void insertObject()
        {
            string commandString;
            commandString = "INSERT INTO " + tableName + "("; // INSERT INTO tableName (
            foreach (string column in columnNames) // INSERT INTO tablename (column1, column2, ...columnN,
                commandString += column + ",";
            commandString = commandString.Remove(commandString.Length - 1, 1); // INSERT INTO tablename (column1, column2, ...columnN
            commandString += ") VALUES ("; //INSERT INTO tablename (column1, column2, ...columnN) VALUES (
            foreach (string column in objectValues) //INSERT INTO tablename (column1, column2, ...columnN) VALUES (@column1, column2, ...columnN,
                commandString += "@" + column + ",";
            commandString = commandString.Remove(commandString.Length - 1, 1); //INSERT INTO tablename (column1, column2, ...columnN) VALUES (@column1, column2, ...columnN
            commandString += ");"; //INSERT INTO tablename (column1, column2, ...columnN) VALUES (@column1, column2, ...columnN);

            command.CommandText = commandString;
            var columnsAndValues = columnNames.Zip(objectValues, (c, v) => new {Column = c, Value = v} );
            
            foreach (var index in columnsAndValues)
                command.Parameters.AddWithValue("@" + index.Column, index.Value);
            command.Prepare();
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }
        public void deleteObject()
        {
            string commandString;
            commandString = "DELETE FROM " + tableName + " WHERE id=@objectId;";
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


        
    }
}
