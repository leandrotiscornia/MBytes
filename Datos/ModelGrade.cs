using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class ModelGrade : ModelDataBaseObject
    {
        public int gradeId { get; set; }

        public string gradeName { get; set; }

        public string courseName { get; set; }
        public List<string> gradeSubject { get; set; }

        public void addSubject(int subjectId,int gradeId )
        {
            string commandString = 
                "INSERT INTO SubjectInGrade" +
                "(Grade_ID,Subject_ID) " +
                "VALUES(@GradeID,@SubjectID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@GradeID", gradeId);
            command.Parameters.AddWithValue("@SubjectID", subjectId);
            executeWithoutReutrn();
        }

        public List <string> getSubjects (int gradeId)
        {
            List <string> subjects = new List<string> ();
            string commandString =
                "SELECT SubjectName" +
                " FROM Subjects" +
                " JOIN SubjectsInGrades ON Subject" +
                " WHERE SubjectInGrades.Subject_ID = Subjects.ID" +
                " AND SubjectInGrades.Grade_ID = @GradeID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@GradeID", gradeId);
            executeWhitExecuteReaderWhitoutReturn();
            while (reader.Read())
                subjects.Add(reader.GetString(0));
            return subjects;
                
        }
       
        
    }
}
