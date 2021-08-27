using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
   public class ModelGrade : ModelDataBaseObject
    {
        public int gradeId { get; set; }
        public string gradeName { get; set; }
        public string courseName { get; set; }
        public List<int> gradeSubjects { get; set; }

        
        public List <string> getSubjects()
        {
            List <string> subjects = new List<string> ();
            string commandString =
                "SELECT Name " +
                "FROM Subjects " +
                "JOIN grade_subjects ON Subjects.ID = grade_subjects.Subject_ID " +
                "AND grade_subjects.Grade_ID = @GradeID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@GradeID", gradeId);
            executeAndRead();
            while (reader.Read())
                subjects.Add(reader.GetString(0));
            return subjects;
        }
       public DataTable listGrades()
       {
            string commandString;
            commandString =
                "SELECT ID, name " +
                "FROM grades";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
       }
       public void deleteGrade()
       {
            string commandString;
            commandString =
                "DELETE FROM grade_subjects " +
                "WHERE Grade_ID = @gradeId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@gradeID", gradeId);
            executeVoid();
            commandString =
                "UPDATE groups " +
                "SET Grade_ID = NULL " +
                "WHERE Grade_ID = @gradeId;";
            command.Parameters.AddWithValue("@gradeID", gradeId);
            executeVoid();
            commandString =
                "DELETE FROM grades " +
                "WHERE ID = @gradeId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@gradeID", gradeId);
            executeVoid();
        }
        public void insertGrade(int courseId)
        {
            string commandString;
            commandString =
                "SELECT courses.Name, Count(grades.ID) " +
                "FROM courses " +
                "JOIN grades ON grades.Course_ID = courses.ID " +
                "WHERE courses.ID = @courseId " +
                "GROUP BY(courses.Name);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            executeAndRead();
            string courseName = readString(0);
            int gradeNumber = readInt(1) + 1;
            commandString =
                "INSERT INTO grades " +
                "(Name, Course_ID) " +
                "VALUES(@gradeName, @courseId)";
            command.Parameters.AddWithValue("@gradeName",  gradeNumber + "º" + courseName);
            command.Parameters.AddWithValue("@courseId", courseId);
            command.CommandText = commandString;
            executeVoid();

            gradeId = getLastInsertId();

            commandString =
                "INSERT INTO grade_subjects " +
                "(Grade_ID, Subject_ID) " +
                "VALUES(@gradeId, @subjectId);";
            command.CommandText = commandString;
            foreach (int subject in gradeSubjects)
            {
                command.Parameters.AddWithValue("@gradeId", gradeId);
                command.Parameters.AddWithValue("@subjectId", subject);
                executeVoid();
            }
        }
        public void modifyGrade()
        {
            string commandString;
            commandString =
                "DELETE FROM grade_subjects " +
                "WHERE Subject_ID != @subjectId AND " +
                "Grade_ID = @gradeId;";
            command.CommandText = commandString;
            foreach (int subject in gradeSubjects)
            {
                command.Parameters.AddWithValue("@subjectId", subject);
                command.Parameters.AddWithValue("@gradeId", gradeId);
                executeVoid();
            }
            commandString =
                "INSERT INTO grade_subjects " +
                "(Grade_ID, Subject_ID) " +
                "VALUES(@gradeId, @subjectId);";
            command.CommandText = commandString;
            foreach (int subject in gradeSubjects)
            {
                command.Parameters.AddWithValue("@gradeId", gradeId);
                command.Parameters.AddWithValue("@subjectId", subject);
                executeVoid();
            }
            
        }
    }
}
