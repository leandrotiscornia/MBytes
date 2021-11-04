using System;
using System.Collections.Generic;
using System.Data;
using Datos;
using Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestInscription
    {
        [TestMethod]
        public void AsendStudentRequest()
        {
            GroupController.requestStudentInscription("student1", 26, new List<int> { 17, 18});
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BsendTeacherRequest()
        {
            GroupController.requestTeacherInscription("teacher1", 26, new List<int> { 17, 18});
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CacceptStudentRequest()
        {
            GroupController.updateStudentRequestStatus("student1", 26, 17, "Acepted");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void DacceptTeacherRequest()
        {
            GroupController.updateTeacherRequestStatus("teacher1", 26, 17, "Acepted");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void EdenyStudentRequest()
        {
            GroupController.updateStudentRequestStatus("student1", 26, 18, "Denied");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void FdenyTeacherRequest()
        {
            GroupController.updateTeacherRequestStatus("teacher1", 26, 18, "Denied");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void GgetRequests()
        {
            DataTable requests = GroupController.listInscriptions();
            int rows = requests.Rows.Count;
            Assert.IsTrue(
                requests.Rows[rows - 5][0].ToString() == "26" && //Group
                requests.Rows[rows - 5][1].ToString() == "student1" && //CI
                requests.Rows[rows - 5][2].ToString() == "17" && //Subject
                requests.Rows[rows - 5][7].ToString() == "Acepted" && //status
                requests.Rows[rows - 5][8].ToString() == "Student" && //type
                requests.Rows[rows - 4][0].ToString() == "26" &&
                requests.Rows[rows - 4][1].ToString() == "student1" &&
                requests.Rows[rows - 4][2].ToString() == "18" &&
                requests.Rows[rows - 4][7].ToString() == "Denied" &&
                requests.Rows[rows - 4][8].ToString() == "Student" &&
                requests.Rows[rows - 2][0].ToString() == "26" &&
                requests.Rows[rows - 2][1].ToString() == "teacher1" &&
                requests.Rows[rows - 2][2].ToString() == "17" &&
                requests.Rows[rows - 2][7].ToString() == "Acepted" &&
                requests.Rows[rows - 2][8].ToString() == "Teacher" &&
                requests.Rows[rows - 1][0].ToString() == "26" &&
                requests.Rows[rows - 1][1].ToString() == "teacher1" &&
                requests.Rows[rows - 1][2].ToString() == "18" &&
                requests.Rows[rows - 1][7].ToString() == "Denied" &&
                requests.Rows[rows - 1][8].ToString() == "Teacher"
                );
        }
       [TestMethod]
       public void clearInscriptions()
        {
            GroupController.clearInscriptions(26);
            Assert.IsTrue(true);
        }
        
    }
}
