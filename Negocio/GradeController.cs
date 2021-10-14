using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Datos;

namespace Negocio
{
    public static class GradeController
    {
        public static void insertGrade(int courseId, List<int> subjects)
        {
            ModelGrade gradeToInsert = new ModelGrade();
            gradeToInsert.gradeSubjects = subjects;
            gradeToInsert.insertGrade(courseId);
        }
        public static void modifyGrade(int gradeId, List<int> subjects)
        {
            ModelGrade gradeToModify = new ModelGrade();
            gradeToModify.gradeId = gradeId;
            gradeToModify.gradeSubjects = subjects;
            gradeToModify.modifyGrade();
        }
        public static DataTable listGrades()
        {
            DataTable result = new DataTable("grades");
            ModelGrade gradeToList = new ModelGrade();

            result.Columns.Add("ID", Type.GetType("System.Int32"));
            result.Columns.Add("Name");
            for(int i = 1; i <= 15; i++)
                result.Columns.Add("Subject " + i);
            foreach(DataRow grade in gradeToList.listGrades().Rows)
            {
                gradeToList.gradeId = int.Parse(grade["ID"].ToString());
                List<string> subjects = gradeToList.getSubjects();
                DataRow resultRow = result.NewRow();
                resultRow[0] = gradeToList.gradeId;
                resultRow[1] = grade["Name"].ToString();
                for (int i = 0; i <= 12; i++)
                    if (subjects.ElementAtOrDefault(i) != null) resultRow[i+2] = subjects[i];
                result.Rows.Add(resultRow);
            }
            return result;
        }
        public static void deleteGrade(int gradeId)
        {
            ModelGrade gradeToDelete = new ModelGrade();
            gradeToDelete.gradeId = gradeId;
            gradeToDelete.deleteGrade();
        }
        public static DataTable listGradeNames()
        {
            ModelGrade grade = new ModelGrade();
            return grade.listGrades();
        }
    }
}
