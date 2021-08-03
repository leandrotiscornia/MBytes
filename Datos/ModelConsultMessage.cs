    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    
  public class ModelConsultMessage : ModelDataBaseObject
    {
        public int consultId { get; set; }
        public int senderId { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }

        public void sendFirstMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO consultmessages " +
                "(Sender_ID, Consult_ID, ConsultText, Time) " +
                "VALUES(@senderId, Last_Insert_ID(), @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            openConnection();
            command.Prepare();
            command.ExecuteNonQuery();
            Console.WriteLine("" + commandString);
            closeConnection();
        }

        public void sendConsultMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO consultmessages " +
                "(Sender_ID, Consult_ID, ConsultText, Time) " +
                "VALUES(@senderId, @consultId, @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@consultId", consultId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            executeWithoutReutrn();
        }

        public DataTable getConsultMessages()
        {
            DataTable messages = new DataTable();
            string commandString;
            commandString =
                "SELECT Sender_ID, ConsultText, Time " +
                "FROM consultmessages " +
                "WHERE Consult_ID = @consultId " +
                "ORDER BY Time";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@consultId", consultId);
            openConnection();
            command.Prepare();
            reader = command.ExecuteReader();
            messages.Load(reader);
            closeConnection();
            return messages;
        }

    }
}
