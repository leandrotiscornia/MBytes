using System;
using Datos;
using Negocio;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void registerStudent()
        {
            ModelPerson person = new ModelPerson();
            person.userName = "sTest";
            person.userPassword = DataBaseController.encryptPassword("sTest");
            person.firstName = "studentT";
            person.secondName = "testStudent";
            person.firstSurname = "unitTestStudent";
            person.secondSurname = "testUnitStudent";
            person.ci = "88888888";
            person.registerUser();
            person.getUserId();
            person.createPersonObject();
            person.insertObject();
            person.assignUserRole(2);

            Assert.IsTrue(true);
        }
        [TestMethod]
        public void login()
        {
            string result = PersonController.login("", "", 2);
            Assert.IsTrue(result == "You need to set an user name");
            result = PersonController.login("asd", "", 2);
            Assert.IsTrue(result == "You need to set your password");
            result = PersonController.login("asd", "asd", 2);
            Assert.IsTrue(result == "That user does not exist");
            result = PersonController.login("sTest", "asd", 2);
            Assert.IsTrue(result == "Incorrect password");
            result = PersonController.login("sTest", "sTest", 0);
            Assert.IsTrue(result == "Access Denied For This User");
            result = PersonController.login("sTest", "sTest", 1);
            Assert.IsTrue(result == "Access Denied For This User");
            result = PersonController.login("sTest", "sTest", 2);
            Assert.IsTrue(result == "" && Session.userId > 0);
        }
        [TestMethod]
        public void getStudentData()
        {
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            person.getProfileData();
            person.getUserPassword();
            person.getUserRole();

            Assert.IsTrue
                (
                person.userName == "sTest" &&
                person.userPassword == DataBaseController.encryptPassword("sTest") &&
                person.firstName == "studentT" &&
                person.secondName == "testStudent" &&
                person.firstSurname == "unitTestStudent" &&
                person.secondSurname == "testUnitStudent" &&
                person.ci == "88888888" &&
                person.userRole == 2
                );
        }
        [TestMethod]
        public void deleteStudent()
        {
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            person.deleteStudent();
        }
    }
}
