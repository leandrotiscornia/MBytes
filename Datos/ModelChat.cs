using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModelChat : ModelDataBaseObject
    {
        public int chatId { get; set; }
        public int senderId { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }

        public void sendChatMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO chatmessages " +
                "(Chat_ID, Sender_ID, Date, Text) " +
                "VALUES(@chatId, @senderId, @date, @text);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@chatId", chatId);
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@text", text);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            executeVoid();
        }

        public DataTable getChatMessages()
        {
            DataTable message = new DataTable();
            string commandString;
            commandString =
                "SELECT Sender_ID, Date, Text " +
                "FROM chatmessages " +
                "WHERE Chat_ID = @chatId " +
                "ORDER BY Date";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@chatId", chatId);
            executeAndRead();
            return readTable();
        }
    }
}
        