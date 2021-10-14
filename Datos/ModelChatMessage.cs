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
            DataTable messages = new DataTable();
            string commandString;
            commandString =
                "SELECT chatmessages.ID, Sender_ID, Time, Text , persons.CI " +
                "FROM chatmessages " +
                "JOIN users ON users.ID = chatmessages.Sender_ID " +
                "JOIN persons ON users.ID = persons.ID " +
                "WHERE Chat_ID = @chatId " +
                "ORDER BY(Time);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@chatId", chatId);
            executeAndRead();
            messages = readTable();
            connection.Close();
            return messages;
        }
    }
}
