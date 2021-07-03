using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelGrade : ModelDataBaseObject
    {
        private int _gradeId;
        private string _gradeName;
        private string _courseName;
        private List<string> _gradeSubject;

        public int gradeId
        {
            get
            {
                return _gradeId;
            }
            set
            {
                _gradeId = value;
            }
        }

        public string gradeName
        {
            get
            {
                return _gradeName;
            }
            set
            {
                _gradeName = value;
            }
        }

        public string courseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                _courseName = value;
            }
        }
        public List<string> gradeSubject
        {
            get
            {
                return _gradeSubject;
            }
            set
            {
                _gradeSubject = value;
            }
        }

        public void addSubject(int subjectId,int gradeId )
        {
            string commandString = 
                "INSERT INTO SubjectInGrade" +
                "(Grade_ID,Subject_ID) " +
                "VALUES(@GradeID,@SubjectID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@GradeID", gradeId);
            command.Parameters.AddWithValue("@SubjectID", subjectId);
            command.Prapare();
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
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
            command.Prepare();
            openConnection();
            reader = command.ExecuteReader();
            closeConnection();
            while (reader.Read())
                subjects.Add(reader.GetString(0));
            return subjects;
                
        }
       
        
    }
}
