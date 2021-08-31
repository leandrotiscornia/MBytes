using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace Datos
{
    public class ModelPerson : ModelDataBaseObject
    {
        public int personId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string ci { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string nickName { get; set; }
        public string avatarPicture { get; set; }
        public int userRole { get; set; }

        public void registerUser()
        {
            string commandString =
                "INSERT INTO users " +
                "(User_Login, User_Password) " +
                "VALUES (@userName, @userPassword);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@userPassword", userPassword);
            executeVoid();
            Console.WriteLine(commandString);
        }
        public void createObjectPerson()
        {
            objectKey = personId.ToString();
            tableName = "persons";
            columnNames = new string[]
            {
                "CI",
                "ID",
                "First_Name",
                "Second_Name",
                "First_Surname",
                "Second_Surname",
                "Nick_Name",
                "Avatar_Picture"
            };
            objectValues = new string[]
            {
                ci,
                personId.ToString(),
                firstName,
                secondName,
                firstSurname,
                secondSurname,
                nickName,
                avatarPicture
            };
        }
        public void createObjectPersonToModify()
        {
            objectKey = personId.ToString();
            tableName = "persons";
            columnNames = new string[]
            {
                "First_Name",
                "Second_Name",
                "First_Surname",
                "Second_Surname"
            };
            objectValues = new string[]
            {
                firstName,
                secondName,
                firstSurname,
                secondSurname,
            };
        }
        public void getUserCI()
        {
            string commandString;
            commandString =
                "SELECT CI " +
                "FROM persons " +
                "WHERE ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("userId", personId);
            executeAndRead();
            ci = readString(0);
        }
        public void getUserId()
        {
            string commandString;
            commandString =
                "SELECT ID " +
                "FROM users " +
                "WHERE User_Login = @userName";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userName", userName);
            executeAndRead();
            personId = readInt(0);
            reader.Close();
        }
        public List<int> getPermissions() 
        {
            List<int> permissions = new List<int>();
            string commandString;
            commandString = 
                "SELECT Feature_ID FROM Permissions" +
                "JOIN Role ON Permissions.Role_ID = Role.ID" +
                "JOIN PersonRoles ON Role.ID = PersonRoles.Role_ID" +
                "WHERE Person_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", personId);
            command.Prepare();
            reader = command.ExecuteReader();
            while (reader.Read())
                permissions.Add(reader.GetInt32(0));
            return permissions;
        }
        public int checkUserRole()
        {
            int role;
            string commandString;
            commandString =
                "SELECT Role_ID " +
                "FROM PersonIs " +
                "JOIN Persons ON Person_CI = Persons.CI " +
                "JOIN Users ON Persons.ID = Users.ID " +
                "WHERE Users.User_Login = @myUserName";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myUserName", userName);
            executeAndRead();
            role = readInt(0);
            reader.Close();
            return role;
        }
        public void assignUserRole(int roleId)
        {
            string commandString;
            commandString =
                "INSERT INTO personIs " +
                "(Role_ID, Person_CI) " +
                "VALUES(@roleId, @ci);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@ci", ci);
            command.Parameters.AddWithValue("@roleId", roleId);
            executeVoid();

        }
        public string getUserName()
        {
            string commandString = 
                "SELECT User_Login " +
                "FROM users " +
                "WHERE User_Login = @userLogin;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userLogin", userName);
            executeAndRead();
            if (!(readString(0) == userName))
                userName = null;
            reader.Close();
            return userName;
        }
        public string checkUserPassword()
        {
            string commandString =
                "SELECT User_Password " +
                "FROM users " +
                "WHERE User_Password = @userPassword;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userPassword", userPassword);
            executeAndRead();
            Console.WriteLine("CONTRASEÑA: " + readString(0));
            if (!(readString(0) == userPassword))
                userPassword = null;
            reader.Close();
            return userPassword;
        }

        public void updateUserName(string updateUserName, int userID)
        {
            string commandString = "UPDATE users" +
            " SET User_Login = @userLogin " +
            "WHERE ID = @userID;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@userLogin", updateUserName);
            executeVoid();
        }
        public void updateNickName()
        {
            string commandString = 
                "UPDATE persons " +
                "SET Nick_Name = @nickName " +
                "WHERE ID = @personId;";

            command.CommandText = commandString;
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@nickName", nickName);
            executeVoid();
        }
        public void updatePassword()
        {
            string commandString =
                "UPDATE users " +
                "SET User_Password = @userPassword" +
                "WHERE ID = @personId;";

            command.CommandText = commandString;
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@userPassword", userPassword);
            executeVoid();
        }
        public DataTable getUsersByPermission(int featureId)
        {
            DataTable users = new DataTable();
            string commandString;
            commandString =
                "SELECT persons.ID, CI, First_Name, Second_Name, First_Surname, Second_Surname, Nick_Name, Avatar_Picture " +
                "FROM persons " +
                "JOIN personis ON persons.CI = personis.Person_CI " +
                "JOIN roles ON roles.ID = personis.Role_ID " +
                "JOIN permissions ON roles.ID = permissions.Role_ID " +
                "WHERE permissions.Feature_ID = @featureId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@featureId", featureId);
            executeAndRead();
            return readTable(); 
        }

        public string getPersonName()
        {
            string personName;
            string commandString;
            commandString =
                "SELECT First_Name, First_Surname " +
                "FROM persons " +
                "WHERE ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", personId);
            executeAndRead();
            personName = readString(0) + " " + readString(1);
            Console.WriteLine("EL NOMBRE ES: " + personName);
            connection.Close();
            return personName;
        }
        public string getPersonNick()
        {
            string personNickName;
            string commandString;
            commandString =
                "SELECT Nick_Name " +
                "FROM persons " +
                "WHERE ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", personId);
            executeAndRead();
            personNickName = readString(0);
            reader.Close();
            return personNickName;
        }
        public List<string> getFeatures()
        {
            List<string> features = new List<string>();
            string commandString;
            commandString =
                "SELECT features.Name " +
                "FROM features " +
                "JOIN permissions ON features.ID = permissions.Feature_ID " +
                "JOIN roles ON roles.ID = permissions.Role_ID " +
                "JOIN personis ON roles.ID = personis.Role_ID " +
                "JOIN persons ON persons.CI = personis.Person_CI " +
                "WHERE persons.ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            command.Prepare();
            reader = command.ExecuteReader();
            while (reader.Read())
                features.Add(reader.GetString(0));
            command.Parameters.Clear();
            reader.Close();
            return features;
        }
        public void getProfileData()
        {
            string commandString;
            commandString =
                "SELECT User_Login, CI, First_Name, Second_Name, First_Surname, Second_Surname, Nick_Name " +
                "FROM persons " +
                "JOIN users ON persons.ID = users.ID " +
                "WHERE users.ID = @myId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeAndRead();
            userName = readString(0);
            ci = readString(1);
            firstName = readString(2);
            secondName = readString(3);
            firstSurname = readString(4);
            secondSurname = readString(5);
            nickName = readString(6);
            command.Parameters.Clear();
            reader.Close();
        }
        public DataTable getUsersByRole(int roleId)
        {
            string commandString;
            commandString =
                "SELECT ID, CI, First_Name, Second_Name, First_Surname, Second_Surname, Nick_Name, Avatar_Picture " +
                "FROM persons " +
                "JOIN personis ON persons.CI = personis.Person_CI " +
                "WHERE personis.Role_ID = @roleId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@roleId", roleId);
            executeAndRead();
            return readTable();
        }
        public void deleteStudent()
        {
            string commandString;
            commandString =
                "DELETE personis, consultmessages, " +
                "chatmessages, student_take_subjects " +
                "FROM users " +
                "LEFT JOIN persons ON users.ID = persons.ID " +
                "LEFT JOIN personis ON personis.Person_CI = persons.CI " +
                "LEFT JOIN chatmessages ON chatmessages.Sender_ID = users.ID " +
                "LEFT JOIN consultmessages ON consultmessages.Sender_ID = users.ID " +
                "LEFT JOIN student_take_subjects ON student_take_subjects.Student_CI = persons.CI " +
                "WHERE users.ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeVoid();
            commandString =
                "DELETE FROM persons " +
                "WHERE ID = @myId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeVoid();
        }
        public void deleteTeacher()
        {
            string commandString;
            commandString =
                "Delete personis, consultmessages, chatmessages, watches, " +
                "classes, available_subjects " +
                "FROM users " +
                "LEFT JOIN persons ON users.ID = persons.ID " +
                "LEFT JOIN personis ON personis.Person_CI = persons.CI " +
                "LEFT JOIN chatmessages ON chatmessages.Sender_ID = users.ID " +
                "LEFT JOIN consultmessages ON consultmessages.Sender_ID = users.ID " +
                "LEFT JOIN watches ON watches.User_ID = users.ID " +
                "LEFT JOIN classes ON classes.Teacher_CI = persons.CI " +
                "LEFT JOIN available_subjects ON available_subjects.Person_CI = persons.CI " +
                "WHERE users.ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeVoid();
            commandString =
                 "DELETE FROM persons " +
                 "WHERE ID = @myId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeVoid();
        }
        public bool isAdmin()
        {
            string commandString;
            commandString =
                "SELECT ID " +
                "FROM users " +
                "WHERE User_Login = @userName AND EXISTS ( SELECT Admin_ID " +
                                              "FROM administrator " +
                                              "WHERE administrator.Admin_ID = users.ID);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userName", userName);
            executeAndRead();
            command.Parameters.Clear();
            if (readString(0) != null) { reader.Close(); return true; }
            else { reader.Close(); return false; }
        }
        public string getUserPassword()
        {
            string commandString;
            commandString =
                "Select User_Password " +
                "FROM users " +
                "WHERE ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", personId);
            executeAndRead();
            return readString(0);
        }
    }
}
