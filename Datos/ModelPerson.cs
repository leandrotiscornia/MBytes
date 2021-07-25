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
        public string ci { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string nickName { get; set; }
        public string avatarPicture { get; set; }

        public void registerUser(string userName, string userPassword)
        {
            string commandString =
                "INSERT INTO users " +
                "(User_Login, User_Password) " +
                "VALUES (@userName, @userPassword);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@userPassword", userPassword);
            openConnection();
            command.Prepare();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            closeConnection();
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

            public int getUserId(string userName)
        {
            string commandString;
            commandString =
                "SELECT ID " +
                "FROM users " +
                "WHERE User_Login = @userName";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userName", userName);
            this.openConnection();
            this.command.Prepare();
            this.reader = this.command.ExecuteReader();

            reader.Read();
            this.personId = this.reader.GetInt32(0);
            command.Parameters.Clear();
            this.closeConnection();
            return this.personId;
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
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userId", this.personId);
            this.command.Prepare();
            this.openConnection();
            this.reader = this.command.ExecuteReader();
            this.closeConnection();
            while (this.reader.Read())
                permissions.Add(reader.GetInt32(0));
            return permissions;
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
            openConnection();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            closeConnection();

        }
        public string getUserName(string userName)
        {
            string commandString = 
                "SELECT User_Login " +
                "FROM users " +
                "WHERE User_Login = @userLogin;";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userLogin", userName);
            

            
            this.openConnection();
            this.command.Prepare();
            try
            {
                this.reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
            reader.Read();
            if (!(reader.HasRows && reader.GetValue(0).ToString() == userName))
                userName = null;
            this.command.Parameters.Clear();
            this.closeConnection();
            return userName;
        }
        public string getUserPassword(string userPassword)
        {
            string commandString =
                "SELECT User_Password " +
                "FROM users " +
                "WHERE User_Password = @userPassword;";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userPassword", userPassword);



            this.openConnection();
            this.command.Prepare();
            try
            {
                this.reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
            reader.Read();
            if (!(reader.HasRows && reader.GetValue(0).ToString() == userPassword))
                userPassword = null;
            this.command.Parameters.Clear();
            this.closeConnection();
            return userPassword;

        }

        public void updateUserName(string updateUserName, int userID)
        {
            string commandString = "UPDATE users" +
            " SET User_Login = @userLogin " +
            "WHERE ID = @userID;";


              this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userID", userID);
            this.command.Parameters.AddWithValue("@userLogin", updateUserName);
            this.openConnection();
            this.command.Prepare();
            this.command.ExecuteNonQuery();
            this.command.Parameters.Clear();
            this.closeConnection();


        }
        public void updateNickName()
        {
            string commandString = 
                "UPDATE persons " +
                "SET Nick_Name = @nickName " +
                "WHERE ID = @personId;";

            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@personId", personId);
            this.command.Parameters.AddWithValue("@nickName", nickName);
            this.openConnection();
            this.command.Prepare();
            this.command.ExecuteNonQuery();
            this.command.Parameters.Clear();
            this.closeConnection();
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
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@featureId", featureId);
            this.openConnection();
            this.command.Prepare();
            this.reader = command.ExecuteReader();
            if (reader.HasRows)
                users.Load(reader);
            this.command.Parameters.Clear();
            this.closeConnection();
            return users;
        }

        public string getPersonName()
        {
            string personName;
            string commandString;
            commandString =
                "SELECT First_Name, First_Surname " +
                "FROM persons " +
                "WHERE ID = @userId";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userId", personId);
            this.openConnection();
            this.command.Prepare();
            this.reader = command.ExecuteReader();
            this.reader.Read();
            if (!reader.IsDBNull(0))
                personName = reader.GetString(0) + " " + reader.GetString(1);
            else
                personName = null;
            this.command.Parameters.Clear();
            this.closeConnection();
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
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@userId", personId);
            this.openConnection();
            this.command.Prepare();
            this.reader = command.ExecuteReader();
            this.reader.Read();
            if (!reader.IsDBNull(0))
                personNickName = reader.GetString(0);
            else
                personNickName = null;
            this.command.Parameters.Clear();
            this.closeConnection();
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
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@myId", personId);
            this.openConnection();
            this.command.Prepare();
            this.reader = command.ExecuteReader();
            while (this.reader.Read())
                features.Add(reader.GetString(0));
            this.command.Parameters.Clear();
            this.closeConnection();
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
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@myId", personId);
            this.openConnection();
            this.command.Prepare();
            this.reader = command.ExecuteReader();
            while (this.reader.Read())
            {
                this.userName = reader.GetString(0);
                this.ci = reader.GetString(1);
                this.firstName = reader.GetString(2);
                this.secondName = reader.GetString(3);
                this.firstSurname = reader.GetString(4);
                this.secondSurname = reader.GetString(5);
                this.nickName = reader.GetString(6);
            }
            this.command.Parameters.Clear();
            this.closeConnection();
        }
    }
}
