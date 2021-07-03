using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelGrade
    {
        private int _gradeId;
        private string _gradeName;
        private string _courseName;
        private string [] _gradeSubject;

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
        public string [] gradeSubject
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
                "(GradeID,SubjectID) " +
                "VALUES(@GradeID,@SubjectID";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@GradeID", gradeId);
            command.Parameters.AddWithValue("@SubjectID", subjectId);
            command.Prapare();
            command.ExecuteNonQuery();
        }

        public string [] getSubjects (int gradeId)
        {
            string commandString =
                "SELECT SubjectName" +
                "FROM SubjectInGrade" +
                "RIGHTJOIN Subjects.SubjectsName" +
                "WHERE Grades.GradeID=Subjects.SubjectID ";

            command.CommandText = commandString;
            
        }
       
        
    }
}
