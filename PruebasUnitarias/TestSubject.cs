using System;
using System.Data;
using Datos;
using Negocio;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestSubject
    {
        [TestMethod]
        public void AinsertSubject()
        {
            ModelSubject subject = new ModelSubject();
            subject.subjectName = "testSubject1";
            subject.subjectDescription = "thisIsATest1";
            subject.insertSubject();
            Globals.subjectId1 = subject.getLastInsertId();
            subject.subjectName = "testSubject2";
            subject.subjectDescription = "thisIsATest2";
            subject.insertSubject();
            Globals.subjectId2 = subject.getLastInsertId();
            subject.subjectName = "testSubject3";
            subject.subjectDescription = "thisIsATest3";
            subject.insertSubject();
            Globals.subjectId3 = subject.getLastInsertId();
            subject.subjectName = "testSubject4";
            subject.subjectDescription = "thisIsATest4";
            subject.insertSubject();
            Globals.subjectId4 = subject.getLastInsertId();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BmodifySubject()
        {
            ModelSubject subject = new ModelSubject();
            subject.subjectId = Globals.subjectId2;
            subject.subjectName = "subjectTest2";
            subject.subjectDescription = "alsoATest";
            subject.modifySubject();
        }
        
        [TestMethod]
        public void CgetSubjects()
        {
            ModelSubject subject = new ModelSubject();
            DataTable subjects = subject.listSubjects();
            int rows = subjects.Rows.Count;
            Assert.IsTrue(
                subjects.Rows[rows-4][1].ToString() == "testSubject1" &
                subjects.Rows[rows-4][2].ToString() == "thisIsATest1" &
                subjects.Rows[rows-3][1].ToString() == "subjectTest2" &
                subjects.Rows[rows-3][2].ToString() == "alsoATest" &
                subjects.Rows[rows-2][1].ToString() == "testSubject3" &
                subjects.Rows[rows-2][2].ToString() == "thisIsATest3" &
                subjects.Rows[rows-1][1].ToString() == "testSubject4" &
                subjects.Rows[rows-1][2].ToString() == "thisIsATest4"
                );
        }

        [TestMethod]
        public void DdeleteSubject()
        {
            ModelSubject subject = new ModelSubject();
            subject.subjectId = Globals.subjectId1;
            subject.deleteSubject();
            subject.subjectId = Globals.subjectId2;
            subject.deleteSubject();
            subject.subjectId = Globals.subjectId3;
            subject.deleteSubject();
            subject.subjectId = Globals.subjectId4;
            subject.deleteSubject();
        }
    }
}
