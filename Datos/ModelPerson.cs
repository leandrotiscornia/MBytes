using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Datos
{
    public class ModelPerson : ModelDataBaseObject
    {
        private int _personId;
        private string _ci;
        private string _firstName;
        private string _secondName;
        private string _firstSurname;
        private string _secondSurname;
        private string _nickName;
        private string _avatarPicture;
        private List<int> _userPermissions;
        

        public int personId
        {
            get { return _personId; }
            set { _personId = value; }
        }
        public string ci
        {
            get { return _ci; }
            set { _ci = value; }
        }
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string secondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        public string firstSurname
        {
            get { return _firstSurname; }
            set { _firstSurname = value; }
        }
        public string secondSurname
        {
            get { return _secondSurname; }
            set { _secondSurname = value; }
        }
        public string nickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }
        public string avatarPicture
        {
            get { return _avatarPicture; }
            set { _avatarPicture = value; }
        }
        public List<int> userPermissions
        {
            get { return _userPermissions; }
            set { _userPermissions = value; }
        }
        

        public List<int> getPermissions(int userId)
        {
            List<int> permissions = new List<int>();
            string commandString;
            commandString = 
                "SELECT Feature_ID FROM Permissions" +
                "JOIN Role ON Permissions.Role_ID = Role.ID" +
                "JOIN PersonRoles ON Role.ID = PersonRoles.Role_ID" +
                "WHERE Person_ID = @userId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@userId", userId);
            command.Prepare();
            openConnection();
            reader = command.ExecuteReader();
            closeConnection();
            while (reader.Read())
                permissions.Add(reader.GetInt32(0));
            return permissions;
        }

       

    }
}
