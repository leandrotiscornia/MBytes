using System;
using System.Data;
using Datos;
using System.Linq;
using System.Xml;
using Negocio;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void AinsertCourse()
        {
            ModelCourse course = new ModelCourse();
            course.courseName = "testCourse";
            course.numberOfGrades = 2;
            course.insertCourse();
            Globals.courseId = course.courseId;
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BmodifyCourse()
        {
            ModelCourse course = new ModelCourse();
            course.courseId = Globals.courseId;
            course.courseName = "courseTest";
            course.numberOfGrades = 4;
            course.modifyCourse("testCourse");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CgetCourses()
        {
            DataTable courses = CourseController.listCourses();
            DataRow course = courses.Rows[courses.Rows.Count - 1];
            Assert.IsTrue(course["Name"].ToString() == "courseTest");
            Assert.IsTrue(course["Number Of Grades"].ToString() == "4");
        }
        [TestMethod]
        public void DdeleteCourse()
        {
            ModelCourse course = new ModelCourse();
            course.courseId = Globals.courseId;
            course.deleteCourse();
            Assert.IsTrue(true);
        }
    }
    
}
