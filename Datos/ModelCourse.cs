using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
   public class ModelCourse : ModelDataBaseObject 
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public int numberOfGrades { get; set; }

        public void insertCourse()
        {
            string commandString;
            commandString =
                "INSERT INTO courses " +
                "(name) " +
                "VALUE(@courseName);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseName", courseName);
            executeVoid();
            courseId = getLastInsertId();
            commandString =
                    "INSERT INTO grades " +
                    "(course_ID, name) " +
                    "VALUES(@courseId, @gradeName)";
            command.CommandText = commandString;
            for (int i = 1; i <= numberOfGrades; i++)
            { 
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@gradeName",i + "º" + courseName);
                executeVoid();
            }
        }
        public void modifyCourse(string oldCourseName)
        {
            string commandString;
            commandString =
                "DELETE grade_subjects, groups " +
                "FROM grades " +
                "LEFT JOIN grade_subjects ON grade_subjects.Grade_ID = grades.ID " +
                "LEFT JOIN groups ON groups.Grade_ID = grades.ID " +
                "WHERE CONVERT(SUBSTRING_INDEX(grades.Name,'º',1), UNSIGNED INTEGER) > @gradeNumber " +
                "AND grades.Course_ID = @courseId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            command.Parameters.AddWithValue("@gradeNumber", numberOfGrades);
            executeVoid();
            commandString =
                "DELETE FROM grades " +
                "WHERE CONVERT(SUBSTRING_INDEX(grades.Name,'º',1), UNSIGNED INTEGER) > @gradeNumber " +
                "AND Course_ID = @courseId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            command.Parameters.AddWithValue("@gradeNumber", numberOfGrades);
            executeVoid();
            commandString =
                   "INSERT INTO grades " +
                   "(Course_ID, Name) " +
                   "SELECT @courseId, @gradeName WHERE NOT EXISTS " +
                   "(SELECT * FROM grades WHERE Name = @gradeName);";
            command.CommandText = commandString;
            for (int i = 1; i <= numberOfGrades; i++)
            {
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@gradeName", i + "º" + oldCourseName);
                executeVoid();
            }
            commandString =
                "UPDATE courses " +
                "SET name = @courseName " +
                "WHERE ID = @courseId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseName", courseName);
            command.Parameters.AddWithValue("@courseId", courseId);
            executeVoid();
            commandString =
                "UPDATE grades " +
                "SET Name = @newGradeName " +
                "WHERE Name = @oldGradeName ";
            command.CommandText = commandString;
            for(int i = 1; i <= numberOfGrades; i++)
            {
                command.Parameters.AddWithValue("@newGradeName", i + "º" + courseName);
                command.Parameters.AddWithValue("@oldGradeName", i + "º" + oldCourseName);
                executeVoid();
            }
        }
        public DataTable listCourses()
        {
            string commandString;
            commandString =
                "SELECT courses.ID, courses.Name, COUNT(grades.ID) AS `Number Of Grades`" +
                "FROM courses " +
                "JOIN grades ON grades.Course_ID = courses.ID " +
                "GROUP BY(courses.Name);";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public void deleteCourse()
        {
            string commandString;
            commandString =
                "DELETE classes, student_take_subjects, grade_subjects " +
                "FROM courses " +
                "LEFT JOIN grades ON grades.Course_ID = courses.ID " +
                "LEFT JOIN grade_subjects ON grade_subjects.Grade_ID = grades.ID " +
                "LEFT JOIN groups ON groups.Grade_ID = grades.ID " +
                "LEFT JOIN classes ON classes.Group_ID = groups.ID " +
                "LEFT JOIN student_take_subjects ON student_take_subjects.Group_ID = groups.ID " +
                "WHERE courses.ID = @courseId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            executeVoid();
            commandString =
                "DELETE groups " +
                "FROM courses " +
                "LEFT JOIN grades ON grades.Course_ID = courses.ID " +
                "LEFT JOIN groups ON groups.Grade_ID = grades.ID " +
                "WHERE courses.ID = @courseId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            executeVoid();
            commandString =
                "DELETE grades " +
                "FROM courses " +
                "LEFT JOIN grades ON grades.Course_ID = courses.ID " +
                "WHERE courses.ID = @courseId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            executeVoid();
            commandString =
                "DELETE " +
                "FROM courses " +
                "WHERE courses.ID = @courseId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@courseId", courseId);
            executeVoid();
        }
        public string[] getCourse()
        {
            string commandString;
            commandString =
                "SELECT courses.name, COUNT(grades.ID) " +
                "FROM courses " +
                "JOIN grades ON grades.Course_ID = courses.ID " +
                "WHERE courses.ID = @courseId " +
                "GROUP BY(courses.name);";
            command.Parameters.AddWithValue("@courseId", courseId);
            command.CommandText = commandString;
            executeAndRead();
            return new string[] { readString(0), readString(1) };
        }
    }
}
