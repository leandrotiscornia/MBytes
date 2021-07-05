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
        public int personId { get; set; }
        public string ci { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string nickName { get; set; }
        public string avatarPicture { get; set; }
        public List<int> userPermissions { get; set; }


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
