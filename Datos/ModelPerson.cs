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
        public string ci { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string nickName { get; set; }
        public string avatarPicture { get; set; }
        public List<int> userPermissions { get; set; }

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
        public string getUserRole()
        {
            string userRole ="";
            string commandString;
            commandString = 
                "SELECT Name " +
                "FROM roles " +
                "LEFT JOIN personis " +
                "ON roles.ID = personis.Role_ID " +
                "LEFT JOIN persons " +
                "ON personis.Person_CI = persons.CI " +
                "WHERE persons.ID = @personId";
            this.command.CommandText = commandString;
            this.openConnection();
            this.command.Parameters.AddWithValue("@personId", this.personId);
            this.command.Prepare();
            this.reader = this.command.ExecuteReader();
            while (reader.Read())
                userRole = reader.GetString(0);
            closeConnection();
            
            return userRole;
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
        public void updateNickName(string updateNickName, string ci)
        {
            string commandString = "UPDATE persons" +
            "SET Nick_Name = @nickName" +
            "WHERE CI = @person_CI;";


              this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@person_CI", ci);
            this.command.Parameters.AddWithValue("@nickName", updateNickName);
            this.openConnection();
            this.command.Prepare();
            this.command.ExecuteNonQuery();
            this.command.Parameters.Clear();
            this.closeConnection();



        }
    }
}
