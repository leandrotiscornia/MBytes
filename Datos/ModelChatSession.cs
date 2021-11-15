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

        public void openSession()
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
            sessionId = getLastInsertId();
            reader.Close();
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
        public DataTable listSessions(int userId)
        {
            string commandString =
                "SELECT chatsessions.ID, Host_ID, Name, Start_Time, persons.CI " +
                "FROM chatsessions " +
                "JOIN users ON users.ID = chatsessions.Host_ID " +
                "JOIN persons ON users.ID = persons.ID " +
                "WHERE End_Time IS NULL AND EXISTS" +
                "(SELECT * " +
                "FROM chatparticipants " +
                "WHERE User_ID = @userId)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", userId);
            executeAndRead();
            return readTable();
        }
        public DataTable listRegisters(int userId)
        {
            string commandString =
                "SELECT chatsessions.ID, Host_ID, Name, Start_Time, End_Time, persons.CI " +
                "FROM chatsessions " +
                "JOIN users ON users.ID = chatsessions.Host_ID " +
                "JOIN persons ON users.ID = persons.ID " +
                "WHERE End_Time IS NOT NULL AND EXISTS" +
                "(SELECT * " +
                "FROM chatparticipants " +
                "WHERE User_ID = @userId) " +
                "OR End_Time IS NOT NULL AND Host_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", userId);
            executeAndRead();
            return readTable();
        }
        public DataTable showHost()
        {
            string commandString =
                "SELECT persons.ID, persons.CI, persons.Nick_Name, persons.First_Name, " +
                "persons.First_Surname, roles.Name " +
                "FROM chatsessions " +
                "JOIN users ON users.ID = chatSessions.Host_ID " +
                "JOIN persons ON persons.ID = users.ID " +
                "JOIN personis ON persons.CI = personis.Person_CI " +
                "JOIN roles On roles.ID = personis.Role_ID " +
                "WHERE chatsessions.ID = @sessionId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            executeAndRead();
            return readTable();
        }
        public DataTable showTeacher()
        {
            string commandString =
                "SELECT persons.ID, persons.CI, persons.Nick_Name, persons.First_Name, " +
                "persons.First_Surname, roles.Name, chatparticipants.Status " +
                "FROM chatsessions " +
                "JOIN chatparticipants ON chatparticipants.Chat_ID = chatsessions.ID " +
                "JOIN users ON users.ID = chatparticipants.User_ID " +
                "JOIN persons ON persons.ID = users.ID " +
                "JOIN personis ON persons.CI = personis.Person_CI " +
                "JOIN roles On roles.ID = personis.Role_ID " +
                "WHERE chatsessions.ID = @sessionId AND roles.ID = 1";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            executeAndRead();
            return readTable();
        }
        public DataTable showStudents()
        {
            string commandString =
                "SELECT persons.ID, persons.CI, persons.Nick_Name, persons.First_Name, " +
                "persons.First_Surname, roles.Name, chatparticipants.Status " +
                "FROM chatsessions " +
                "JOIN chatparticipants ON chatparticipants.Chat_ID = chatsessions.ID " +
                "JOIN users ON users.ID = chatparticipants.User_ID " +
                "JOIN persons ON persons.ID = users.ID " +
                "JOIN personis ON persons.CI = personis.Person_CI " +
                "JOIN roles On roles.ID = personis.Role_ID " +
                "WHERE chatsessions.ID = @sessionId AND roles.ID = 2 AND users.ID != chatsessions.Host_ID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            executeAndRead();
            return readTable();
        }
        public void joinSession(int userId)
        {
            string commandString =
                "UPDATE chatparticipants " +
                "SET Status ='Online' " +
                "WHERE Chat_ID = @sessionId AND " +
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
                "WHERE Chat_ID = @sessionId AND " +
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
                "WHERE Chat_ID = @sessionId AND " +
                "User_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@userId", userId);
            executeVoid();
        }
        public string getEndTime()
        {
            string endTime;
            string commandString =
                "SELECT End_Time " +
                "FROM chatsessions " +
                "WHERE ID = @sessionId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            executeAndRead();
            endTime = readString(0);
            connection.Close();
            return endTime;
        }
        public void setActive(int userId)
        {
            string commandString =
                "UPDATE chatparticipants " +
                "SET Status = 'Online' " +
                "WHERE Chat_ID = @sessionId AND " +
                "User_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@sessionId", sessionId);
            command.Parameters.AddWithValue("@userId", userId);
            executeVoid();
        }
        public void getAllowedUsers(int groupId, int subjectId)
        {
            string commandString =
                "SELECT users.ID " +
                "FROM users " +
                "JOIN persons ON persons.ID = users.ID " +
                "WHERE EXISTS( " +
                "SELECT * FROM classes " +
                "WHERE classes.Teacher_CI = persons.CI AND " +
                "classes.Subject_ID = @subjectID AND " +
                "classes.Group_ID = @groupId) " +
                "OR EXISTS( " +
                "SELECT * FROM student_take_subjects " +
                "WHERE student_take_subjects.Student_CI = persons.CI AND " +
                "student_take_subjects.Subject_ID = @subjectId AND " +
                "student_take_subjects.Group_ID = @groupId);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@subjectId", subjectId);
            command.Parameters.AddWithValue("@groupId", groupId);
            executeAndRead();
            DataTable usersAllowed = readTable();
            allowedUsers = new List<int>();
            foreach(DataRow user in usersAllowed.Rows)
                allowedUsers.Add((int)user[0]);
            reader.Close();
        }
    }
}
        