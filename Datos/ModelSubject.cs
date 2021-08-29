using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Datos
{
   public class ModelSubject : ModelDataBaseObject
    {
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public string subjectDescription { get; set; }

        public DataTable listSubjects()
        {
            string commandString;
            commandString =
                "SELECT ID, Name, Description " +
                "FROM subjects";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public DataTable listGradeSubjects(int gradeId)
        {
            string commandString;
            commandString =
                "SELECT ID, Name, Description " +
                "FROM subjects " +
                "JOIN grade_subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "WHERE grade_subjects.Grade_ID = @gradeId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@gradeId", gradeId);
            executeAndRead();
            return readTable();
        }
        public DataTable listRestSubjects(int gradeId)
        {
            string commandString;
            commandString =
                "SELECT ID, Name, Description " +
                "FROM subjects " +
                "WHERE ID NOT IN" +
                "(SELECT ID " +
                "FROM grade_subjects " +
                "JOIN subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "WHERE grade_subjects.Grade_ID = @gradeId);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@gradeId", gradeId);
            executeAndRead();
            return readTable();
        }
        public void insertSubject()
        {
            string commandString;
            commandString =
                "INSERT INTO subjects " +
                "(Name, Description) " +
                "VALUES(@subjectName, @subjectDescription)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@subjectName", subjectName);
            command.Parameters.AddWithValue("@subjectDescription", subjectDescription);
            executeVoid();
        }
        public void modifySubject()
        {
            string commandString;
            commandString =
                "UPDATE subjects " +
                "SET Name = @subjectName, " +
                "Description = @subjectDescription " +
                "WHERE ID = @subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@subjectName", subjectName);
            command.Parameters.AddWithValue("@subjectDescription", subjectDescription);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            executeVoid();
        }
        public void deleteSubject()
        {
            string commandString;
            commandString =
                "DELETE available_subjects, classes, student_take_subjects, grade_subjects " +
                "FROM subjects " +
                "JOIN available_subjects ON available_subjects.Subject_ID = subjects.ID " +
                "JOIN classes ON classes.Subject_ID = subjects.ID " +
                "JOIN student_take_subjects ON student_take_subjects.Subject_ID = subjects.ID " +
                "JOIN grade_subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "WHERE subjects.ID = @subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@subjectId", subjectId);
            executeVoid();
            commandString =
                "DELETE " +
                "FROM subjects " +
                "WHERE ID = @subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("subjectId", subjectId);
            executeVoid();
        }
        public void getSubjectData()
        {
            string commandString;
            commandString =
                "SELECT Name, Description " +
                "FROM subjects " +
                "WHERE ID = @subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@subjectId", subjectId);
            executeAndRead();
            subjectName = readString(0);
            subjectDescription = readString(1);
        }
       
    }




}

