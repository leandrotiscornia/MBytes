using System;
using System.Collections.Generic;
using System.Data;
using Datos;
using Negocio;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestGrade
    {
        [TestMethod]
        public void AinsertGrade()
        {
            ModelGrade grade = new ModelGrade();
            List<int> subjects = new List<int>{ 88, 89 };
            grade.gradeName = "gradeTest";
            grade.gradeSubjects = subjects;
            grade.insertGrade(31);
            Globals.gradeId = grade.gradeId;
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BmodifyGrade()
        {
            ModelGrade grade = new ModelGrade();
            List<int> subjects = new List<int>{ 88, 90, 91 };
            grade.gradeId = Globals.gradeId;
            grade.gradeName = "testGrade";
            grade.gradeSubjects = subjects;
            grade.modifyGrade();
        }

        [TestMethod]
        public void CgetGrades()
        {
            DataTable grades = GradeController.listGrades();
            DataRow grade = grades.Rows[grades.Rows.Count - 1];
            Assert.IsTrue(
                grade[2].ToString() == "test1" &&
                grade[3].ToString() == "test3" &&
                grade[4].ToString() == "test4");
        }
        [TestMethod]
        public void DdeleteGrade()
        {
            ModelGrade grade = new ModelGrade();
            grade.gradeId = Globals.gradeId;
            grade.deleteGrade();
            Assert.IsTrue(true);
        }
    }
}
