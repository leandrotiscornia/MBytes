    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    
  public class ModelConsultationMessage : ModelDataBaseObject
    {
        public int consultationId { get; set; }
        public int senderId { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }

        public void sendFirstMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO consultmessages " +
                "(Sender_ID, Consult_ID, ConsultText, Time) " +
                "VALUES(@senderId, @consulationId, @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@consultationId", consultationId);
            executeVoid();
        }
        public void sendConsultationMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO consultmessages " +
                "(Sender_ID, Consult_ID, ConsultText, Time) " +
                "VALUES(@senderId, @consultId, @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@consultId", consultationId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            executeVoid();
        }
        public DataTable getConsultationMessages()
        {
            DataTable messages = new DataTable();
            string commandString;
            commandString =
                "SELECT Sender_ID, ConsultText, Time " +
                "FROM consultmessages " +
                "WHERE Consult_ID = @consultId " +
                "ORDER BY Time";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@consultId", consultationId);
            executeAndRead();
            return readTable();
        }
    }
}
