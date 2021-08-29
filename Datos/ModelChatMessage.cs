using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Datos
{
    public class ModelChatMessage : ModelDataBaseObject
    {
        public int messageId { get; set; }
        public int senderId { get; set; }
        public int chatId { get; set; }
        public DateTime time { get; set; }
        public string text { get; set; }
        public List<int> readed { get; set; }

        public void sendMessage()
        {
            string commandString;
            commandString =
                "INSERT INTO chatmessages " +
                "(Chat_ID, Sender_ID, Time, Text) " +
                "VALUES(@chatId, @senderId, @time, @text);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@chatId",chatId);
            command.Parameters.AddWithValue("@senderId",senderId);
            command.Parameters.AddWithValue("@time",time.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@text", text);
            executeVoid();
        }
        public void editMessage()
        {
            string commandString;
            commandString =
                "UPDATE chatmessages " +
                "SET Chat_ID = @chatId, Sender_ID = @senderId, Time = @time, Text = @text " +
                "WHERE ID = @ID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@ID", messageId);
            command.Parameters.AddWithValue("@chatId", chatId);
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@text", text);
            executeVoid();
        }
        public DataTable listMessages()
        {
            string commandString;
            commandString =
                "SELECT ID, Sender_ID, Time, Text " +
                "FROM chatmessages " +
                "ORDER BY(Time) " +
                "WHERE Chat_ID = @chatId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@chatId", chatId);
            executeAndRead();
            return readTable();
        }
    }
}
