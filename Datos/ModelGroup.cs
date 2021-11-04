using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
   public class ModelGroup : ModelDataBaseObject
    {
        public int groupId { get; set; }
        public string groupName { get; set; }
        public string shift { get; set; }

        public DataTable listGroups()
        {
            string commandString =
                "SELECT groups.ID, grades.Name AS 'Grade Name', groups.Name AS 'Group Name', Shift " +
                "FROM groups " +
                "JOIN grades ON grades.ID = groups.Grade_ID;";
            command.CommandText = commandString;
            executeAndRead();
            return readTable();
        }
        public List<string> getStudents()
        {
            List<string> students = new List<string>();
            string commandString =
                "SELECT First_Surname, First_Name " +
                "FROM persons " +
                "JOIN student_take_subjects ON persons.CI = student_take_subjects.Student_CI " +
                "WHERE student_take_subjects.Group_ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeAndRead();
            while (reader.Read())
                students.Add(readString(0));
            return students;
        }
        public void insertGroup(int gradeId)
        {
            string commandString;
            commandString =
                "INSERT INTO groups " +
                "(Name, Shift, Grade_ID) " +
                "VALUES(@groupName, @shift, @gradeId)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupName", groupName);
            command.Parameters.AddWithValue("@shift",shift);
            command.Parameters.AddWithValue("@gradeId",gradeId);
            executeVoid();
            groupId = getLastInsertId();
        }
        public void deleteGroup()
        {
            string commandString;
            commandString =
                "DELETE classes, student_take_subjects " +
                "FROM groups " +
                "JOIN classes ON classes.Group_ID = groups.ID " +
                "JOIN student_take_subjects ON student_take_subjects.Group_ID = groups.ID " +
                "WHERE groups.ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeVoid();
            commandString =
                "DELETE " +
                "FROM groups " +
                "WHERE ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeVoid();
        }
        public void modifyGroup()
        {
            string commandString;
            commandString =
                "UPDATE groups " +
                "SET Name = @Name, Shift = @shift " +
                "WHERE ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@Name", groupName);
            command.Parameters.AddWithValue("@shift", shift);
            command.Parameters.AddWithValue("@groupId", groupId);
            executeVoid();
        }
       
        public List<string> getGroup()
        {
            List<string> groupData = new List<string>();
            string commandString;
            commandString =
                "SELECT courses.Name AS course, groups.Name, groups.Shift " +
                "FROM groups " +
                "JOIN grades ON grades.ID = groups.Grade_ID " +
                "JOIN courses ON courses.ID = grades.Course_ID " +
                "WHERE groups.ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("groupId", groupId);
            executeAndRead();
            groupData.Add(readString(0));
            groupData.Add(readString(1));
            groupData.Add(readString(2));
            return groupData;
        }
        public void clearInscriptions()
        {
            string commandString;
            commandString =
                "DELETE student_take_subjects, classes " +
                "FROM groups " +
                "JOIN student_take_subjects ON groups.ID = student_take_subjects.Group_ID " +
                "JOIN classes ON groups.ID = classes.Group_ID " +
                "WHERE groups.ID = @groupId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeVoid();
        }
        public DataTable getPendingInscriptions(string studentCI)
        {
            string commandString;
            commandString =
                "SELECT groups.Name AS 'Group', subjects.Name AS 'subject', Status " +
                "FROM student_take_subjects " +
                "JOIN groups on student_take_subjects.Group_ID = groups.ID " +
                "JOIN subjects on student_take_subjects.Subject_ID = subjects.ID " +
                "WHERE Student_CI = @studentCI;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@studentCI", studentCI);
            executeAndRead();
            return readTable();
        }
        public DataTable getPendingClasses(string teacherCI)
        {
            string commandString;
            commandString =
                "SELECT groups.Name AS 'Group', subjects.Name AS 'subject', Status " +
                "FROM classes " +
                "JOIN groups on classes.Group_ID = groups.ID " +
                "JOIN subjects on classes.Subject_ID = subjects.ID " +
                "WHERE Teacher_CI = @teacherCI;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherCI", teacherCI);
            executeAndRead();
            return readTable();
        }


        public DataTable listStudentInscriptions()
        {
            string commandString;
            commandString =
                "SELECT groups.ID AS 'Group ID', persons.CI, subjects.ID AS 'Subject ID', persons.First_Name, " +
                "persons.First_Surname, groups.Name AS 'Group', subjects.Name AS 'Subject', student_take_subjects.Status " +
                "FROM persons " +
                "JOIN student_take_subjects ON student_take_subjects.Student_CI = persons.CI " +
                "JOIN groups ON student_take_subjects.Group_ID = groups.ID " +
                "JOIN subjects ON student_take_subjects.Subject_ID = subjects.ID;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeAndRead();
            return readTable();
        }
        public DataTable listTeacherInscriptions()
        {
            string commandString;
            commandString =
                "SELECT groups.ID AS 'Group ID', persons.CI, subjects.ID AS 'Subject ID', persons.First_Name, " +
                "persons.First_Surname, groups.Name, subjects.Name, classes.Status " +
                "FROM persons " +
                "JOIN classes ON classes.Teacher_CI = persons.CI " +
                "JOIN groups ON classes.Group_ID = groups.ID " +
                "JOIN subjects ON classes.Subject_ID = subjects.ID;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeAndRead();
            return readTable();
        }
        public DataTable listSubjectsByGroup()
        {
            string commandString;
            commandString =
                "SELECT subjects.ID, subjects.Name, subjects.Description " +
                "FROM subjects " +
                "JOIN grade_subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "JOIN grades ON grades.ID = grade_subjects.Grade_ID " +
                "JOIN groups ON groups.Grade_ID = grades.ID " +
                "WHERE groups.ID = @groupId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            executeAndRead();
            return readTable();
        }
        public void requestStudentInscription(string studentCI, List<int> subjects)
        {
            string commandString;
            commandString =
                "INSERT INTO student_take_subjects" +
                "(Student_CI, Group_ID, Subject_ID, Status) " +
                "VALUES(@studentCI, @groupId, @subjectId, 'Requested')";
            command.CommandText = commandString;
            foreach(int subjectId in subjects)
            {
                command.Parameters.AddWithValue("@studentCI",studentCI);
                command.Parameters.AddWithValue("@groupId", groupId);
                command.Parameters.AddWithValue("@subjectId", subjectId);
                executeVoid();
            }
        }
        public void requestTeacherInscription(string teacherCI, List<int> subjects)
        {
            string commandString;
            commandString =
                "INSERT INTO classes" +
                "(Teacher_CI, Group_ID, Subject_ID, Status) " +
                "VALUES(@teacherCI, @groupId, @subjectId, 'Requested')";
            command.CommandText = commandString;
            foreach (int subjectId in subjects)
            {
                command.Parameters.AddWithValue("@teacherCI", teacherCI);
                command.Parameters.AddWithValue("@groupId", groupId);
                command.Parameters.AddWithValue("@subjectId", subjectId);
                executeVoid();
            }
        }
        public void updateStudentRequestStatus(string CI, int subjectId, string status)
        {
            string commandString;
            commandString =
                "UPDATE student_take_subjects " +
                "SET Status = @status " +
                "WHERE Student_CI = @CI AND " +
                "Subject_ID = @subjectId AND " +
                "Group_ID = @groupId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@CI", CI);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            command.Parameters.AddWithValue("groupId", groupId);
            executeVoid();
        }
        public void updateTeacherRequestStatus(string CI, int subjectId, string status)
        {
            string commandString;
            commandString =
                "UPDATE classes " +
                "SET Status = @status " +
                "WHERE Teacher_CI = @CI AND " +
                "Subject_ID = @subjectId AND " +
                "Group_ID = @groupId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@CI", CI);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            command.Parameters.AddWithValue("groupId", groupId);
            executeVoid();
        }
        public DataTable listClassSubjects(string teacherCI)
        {
            string commandString;
            commandString =
                "SELECT subjects.ID, subjects.Name, subjects.Description " +
                "FROM subjects " +
                "JOIN grade_subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "JOIN grades ON grades.ID = grade_subjects.Grade_ID " +
                "JOIN groups ON groups.Grade_ID = grades.ID " +
                "WHERE groups.ID = @groupId AND NOT EXISTS " +
                "(SELECT * FROM classes " +
                "WHERE classes.Subject_ID = subjects.ID " +
                "AND classes.Teacher_CI = @teacherCI);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@teacherCI", teacherCI);
            executeAndRead();
            return readTable();
        }
        public DataTable listInscriptionSubjects(string studentCI)
        {
            string commandString;
            commandString =
                "SELECT subjects.ID, subjects.Name, subjects.Description " +
                "FROM subjects " +
                "JOIN grade_subjects ON grade_subjects.Subject_ID = subjects.ID " +
                "JOIN grades ON grades.ID = grade_subjects.Grade_ID " +
                "JOIN groups ON groups.Grade_ID = grades.ID " +
                "WHERE groups.ID = @groupId AND NOT EXISTS " +
                "(SELECT * FROM student_take_subjects " +
                "WHERE student_take_subjects.Subject_ID = subjects.ID " +
                "AND student_take_subjects.Student_CI = @studentCI);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@studentCI", studentCI);
            executeAndRead();
            return readTable();
        }
    }
}
