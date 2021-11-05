using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class SubjectController
    {
        public static void insertSubject(string subjectName, string subjectDescription)
        {
            ModelSubject subjectToInsert = new ModelSubject();
            subjectToInsert.subjectName = subjectName;
            subjectToInsert.subjectDescription = subjectDescription;
            subjectToInsert.insertSubject();
        }
        public static void modifySubject(int subjectId, string subjectName, string subjectDescription)
        {
            ModelSubject subjectToInsert = new ModelSubject();
            subjectToInsert.subjectId = subjectId;
            subjectToInsert.subjectName = subjectName;
            subjectToInsert.subjectDescription = subjectDescription;
            subjectToInsert.modifySubject();
        }
        public static DataTable listSubjects()
        {
            ModelSubject subjectToList = new ModelSubject();
            return subjectToList.listSubjects();
        }
        public static void deleteSubject(int subjectId)
        {
            ModelSubject subjectToList = new ModelSubject();
            subjectToList.subjectId = subjectId;
            subjectToList.deleteSubject();
        }
        public static DataTable listGradeSubjects(int gradeId)
        {
            ModelSubject subjectToList = new ModelSubject();
            return subjectToList.listGradeSubjects(gradeId);
        }
        public static DataTable listRestSubjects(int gradeId)
        {
            ModelSubject subjectToList = new ModelSubject();
            return subjectToList.listRestSubjects(gradeId);
        }
        public static List<string> getSubjectData(int subjectId)
        {
            List<string> subjectData = new List<string>();
            ModelSubject subject = new ModelSubject();
            subject.subjectId = subjectId;
            subject.getSubjectData();
            subjectData.Add(subject.subjectName);
            subjectData.Add(subject.subjectDescription);
            return subjectData;
        }
        public static DataTable listSubjectsByGroup(int groupId)
        {
            ModelSubject subject = new ModelSubject();
            return subject.listSubjectsByGroup(groupId);
        }
    }
}
