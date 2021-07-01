using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelStudent : ModelPerson
    {
        private List<string>[] _subjectsCoursing;
        public List<string>[] subjectsCoursing;

        public List<string>[] getSubjectsCoursing(int studentId)
        {
            List<string>[] subjectsCoursing = new List<string>[1];
            List<string> subjects = new List<string>();
            List<string> groups = new List<string>();
            string commandString;
            commandString =
                "SELECT Group_ID, Subject_ID " +
                "FROM Coursing " +
                "WHERE Student_ID = @studentId";
            command.CommandText = commandString;
            command.Prepare();
            openConnection();
            reader = command.ExecuteReader();
            closeConnection();

            while (reader.Read())
            {
                groups.Add(reader.GetString(0));
                subjects.Add(reader.GetString(1));
            }
            subjectsCoursing[0] = groups;
            subjectsCoursing[1] = subjects;

            return subjectsCoursing;
        }

        public void assignSubjectCoursing (int studentId, int groupId, int subjectId)
        {
            string commandString;
            commandString =
                "INSERT INTO Coursing " +
                "(Student_ID, Group_ID, Subject_ID) " +
                "VALUES (@studentId, @groupId, @subjectId)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", studentId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            command.Prepare();
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();


        }

        public void deleteSubjectCoursing (int studentId, int groupId, int subjectId)
        {
            string commandString;
            commandString = 
                "DELETE FROM Coursing" +
                " WHERE Student_ID=@studentId AND Group_ID = @groupId AND Subject_ID=@subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@studentId", studentId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);

            command.Prepare();
            command.ExecuteNonQuery();
        }


    }
}
