using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModelChatSession : ModelDataBaseObject
    {
        public int sessionId { get; set; }
        public int hostId { get; set; }
        public string sessionName { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<int> allowedUsers { get; set; }
        public List<int> chatParticipants { get; set; }

        public int openSession()
        {
            string commandString;
            commandString =
                "INSERT INTO chatsessions " +
                "(Host_ID, Name, Start_Time) " +
                "VALUES(@hostId, @name, @startTime)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@name", sessionName);
            command.Parameters.AddWithValue("@hostId", hostId);
            command.Parameters.AddWithValue("startTime", startTime);
            executeVoid();
            return getLastInsertId();
        }
        public void setInvitations()
        {
            string commandString;
            commandString =
                "INSERT INTO chatparticipants " +
                "(User_ID, Chat_ID, Status) " +
                "VALUES(@userId, @sessionId, 'Invited');";
            command.CommandText = commandString;
            foreach(int userId in allowedUsers)
            {
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("sessionId", sessionId);
                executeVoid();
            }
        }
        public void closeSession()
        {
            string commandString;
            commandString =
                "UPDATE chatsessions " +
                "SET End_Time = @endTime " +
                "WHERE ID = @sessionId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@endTime",endTime);
            command.Parameters.AddWithValue("@sessionId", sessionId);
            executeVoid();
        }
        public DataTable listSessions()
        {
            string commandString =
                "SELECT ID, Name, Host_ID, Start_Time " +
                "FROM chatsessions " +
                "WHERE End_Time IS NULL";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public DataTable listRegisters()
        {
            string commandString =
                "SELECT ID, Name, Host_ID, Start_Time, End_Time " +
                "FROM chatsessions " +
                "WHERE End_Time IS NOT NULL";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public DataTable showHost()
        {
            string commandString =
                "SELECT persons.Nick_Name, persons.First_Name, persons.Second_Name, roles.Name " +
                "FROM chatsessions " +
                "JOIN users ON users.ID = chatSessions.Host_ID " +
                "JOIN persons ON persons.ID = users.ID " +
                "JOIN personsis ON persons.CI = personis.Person_CI " +
                "JOIN roles On roles.ID = personis.Role_ID " +
                "WHERE chatsessions.ID = @sessionId";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public DataTable showUsers()
        {
            string commandString =
                "SELECT persons.Nick_Name, persons.First_Name, persons.Second_Name, roles.Name, chatparticipants.Status " +
                "FROM chatsessions " +
                "JOIN chatparticipants ON chatparticipants.Chat_ID = chatsessions.ID" +
                "JOIN users ON users.ID = chatparticipants.User_ID " +
                "JOIN persons ON persons.ID = users.ID " +
                "JOIN personsis ON persons.CI = personis.Person_CI " +
                "JOIN roles On roles.ID = personis.Role_ID " +
                "WHERE chatsessions.ID = @sessionId";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public void joinSession(int userId)
        {
            string commandString =
                "UPDATE chatparticipants " +
                "SET Status = 'Online' " +
                "WHERE Chat_ID = @sessionsId AND " +
                "User_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@userId", userId);
            executeVoid();
        }
        public void setInactive(int userId)
        {
            string commandString =
                "UPDATE chatparticipants " +
                "SET Status = 'Inactive' " +
                "WHERE Chat_ID = @sessionsId AND " +
                "User_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@userId", userId);
            executeVoid();
        }
        public void abandonSession(int userId)
        {
            string commandString =
                "UPDATE chatparticipants " +
                "SET Status = 'Offline' " +
                "WHERE Chat_ID = @sessionsId AND " +
                "User_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@userId", userId);
            executeVoid();
        }
    }
}
        