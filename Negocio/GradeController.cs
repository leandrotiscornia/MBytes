using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class GradeController
    {
        public static void insertGrade(string[] gradeData)
        {
            ModelGrade gradeToInsert = new ModelGrade();
            gradeToInsert.gradeName = gradeData[0];
            gradeToInsert.insertObject();
        }
        public static void modifyGrade(string[] gradeData)
        {
            ModelGrade gradeToModify = new ModelGrade();
            gradeToModify.gradeId = Int32.Parse(gradeData[0]);
            gradeToModify.gradeName = gradeData[1];
            gradeToModify.courseName = gradeData[2];
            gradeToModify.modifyObject();
        }
        public static void listGrade(string[] gradeData)
        {
            ModelGrade gradeToList = new ModelGrade();
            gradeToList.gradeId = Int32.Parse(gradeData[0]);
            gradeToList.gradeName = gradeData[1];
            gradeToList.listObjects();
        }
        public static void deleteGrade(string[] gradeData)
        {
            ModelGrade gradeToDelete = new ModelGrade();
            gradeToDelete.gradeId = Int32.Parse(gradeData[0]);
            gradeToDelete.deleteObject();
        }
    }
}
