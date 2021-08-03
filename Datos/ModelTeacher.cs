using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModelTeacher : ModelPerson
    {
        public List<string> availableSubjects { get; set; }
        public List<List<string>> impartingSubjects { get; set; }
        public List<string> getAvalilableSubjects(int teacherId)
        {
            List<string> availableSubjects = new List<string>();
            string commandString = 
                "SELECT Subject_ID " +
                "FROM AvailableSubjects " +
                "WHERE Teacher_ID = @teacherId";
            command.CommandText = commandString;
            executeWhitExecuteReaderWhitoutReturn();

            while (reader.Read())
                availableSubjects.Add(reader.GetString(0));
            return availableSubjects;
        }
        
        public List<List<string>> getImpartingSubjects(int teacherId)
        {
            List<List<string>> impartingSubjects = new List<List<string>>();
            List <string> groups = new List<string>();
            List <string> subjects = new List<string>();
            string commandString;
            commandString = 
                "SELECT Group_ID, Subject_ID " +
                "FROM SubjectGroup " +
                "WHERE Teacher_ID = @teacherId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            executeWhitExecuteReaderWhitoutReturn();

            while (reader.Read())
            { 
                groups.Add(reader.GetString(0));
                subjects.Add(reader.GetString(1));
            }
            impartingSubjects[0] = groups;
            impartingSubjects[1] = subjects;
            return impartingSubjects;
        }

        public void assignAvailableSubject(int teacherId, int subjectId)
        {
            string commandString;
            commandString = "INSERT INTO AvailableSubjects " +
                "(Teacher_ID, Subject_ID) " +
                "VALUES (@teacherId, subjectId);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            executeWithoutReutrn();

        }
        public void deleteAvailableSubject(int teacherId, int subjectId)
        {
            string commandString;
            commandString =
                "DELETE FROM SubjectGroup" +
                " WHERE Teacher_ID=@teacherId AND Subject_ID=@subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            prepareWhitNonQueryNonReturn();
        }
        public void assignImpartingSubject(int teacherId, int groupId, int subjectId)
        {
            string commandString;
            commandString = 
                "INSERT INTO SubjectGroup " +
                "(Teacher_ID, Group_ID, Subject_ID) " +
                "VALUES (@teacherId, @groupId, @subjectId)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            executeWithoutReutrn();

        }
        public void deleteImpartingSubject(int teacherId, int groupId, int subjectId)
        {
            string commandString;
            commandString =
                "DELETE FROM SubjectGroup" +
                " WHERE Teacher_ID=@teacherId AND Group_ID = @groupId AND Subject_ID=@subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            prepareWhitNonQueryNonReturn();
        }
    }


    
    
}
