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

        public void sendConsultMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO ConsultMessage " +
                "(Sender_ID, Consult_ID, Message, Date) " +
                "VALUES(@senderId, @consultId, @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@consultId", consultId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@date", date);
            command.Prepare();
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }

        public DataTable getConsultMessages(int consultId)
        {
            DataTable messages = new DataTable();
            string commandString;
            commandString =
                "SELECT Sender_ID, Content, Date " +
                "FROM ConsultMessage " +
                "WHERE Consult_ID = @consultId" +
                "ORDER BY Date";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@consultId", consultId);
            command.Prepare();
            openConnection();
            reader = command.ExecuteReader();
            closeConnection();
            messages.Load(reader);

            return messages;
        }

    }
}
