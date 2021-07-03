using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    
    class ModelConsultMessage : ModelDataBaseObject
    {
        private int _consultId;
        private int _senderId;
        private string _message;
        private DateTime _date;
       
        public int consultId
        {
            get { return _consultId; }
            set { _consultId = value; }
        }
        public int senderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        public void sendConsultMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO ConsultMessage " +
                "(Sender_ID, Consult_ID, Message, Date) " +
                "VALUES(@senderId, @consultId, @message, @date);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@senderId", _senderId);
            command.Parameters.AddWithValue("@consultId", _consultId);
            commandString.Parameters.AddWithValue("@message", _message);
            commandString.AsParallel.AddWithValue("@date", _date);
            command.Prepare();
            openConnection();
            commandString.ExecuteNonQuery();
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
            reader = command.ExecuteNonQuery();
            closeConnection();
            messages.Load(reader);

            return messages;
        }

    }
}
