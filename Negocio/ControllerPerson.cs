using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ControllerPerson
    {
        public static string login(string userName, string userPassword)
        {
            string result;
            ModelPerson user = new ModelPerson();
            user.userName = userName;
            user.userPassword = userPassword;
            if (userName == "")
                result = "You need to set an user name";
            else if (userPassword == "")
                result = "You need to set your password";
            else if (userName != user.getUserName())
                result = "That user does not exist";
            else if (userPassword != user.getUserPassword())
                result = "Incorrect password";
            else
            {
                user.getUserId(userName);
                Session.userLogIn = userName;
                Session.userId = user.personId;
                // Session.userRole = user.getUserRole();
                Session.userPassword = userPassword;
                result = "";
            }
            return result;
        }
            public static void deleteStudent(string[] studentData)
        {
            ModelPerson studentToDelete = new ModelPerson();
            studentToDelete.personId = Int32.Parse(studentData[0]);
            studentToDelete.createObjectPerson();
            studentToDelete.deleteObject();

        }
        public static void deleteTeacher(string[] teacherData)
        {
            ModelPerson teacherToDelete = new ModelPerson();
            teacherToDelete.personId = Int32.Parse(teacherData[0]);
            teacherToDelete.createObjectPerson();
            teacherToDelete.deleteObject();
        }
        public static List<string> getFeatures()
        {
            List<string> features;
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            features = person.getFeatures();
            return features;
        }
        public static List<string> getProfileData()
        {
            List<string> profileData = new List<string>();
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            person.getProfileData();
            profileData.Add(person.userName);
            profileData.Add(person.ci);
            profileData.Add(person.firstName);
            profileData.Add(person.secondName);
            profileData.Add(person.firstSurname);
            profileData.Add(person.secondSurname);
            profileData.Add(person.nickName);
            return profileData;
        }
        public static string getPersonNick(int personId)
        {
            string nickName;
            ModelPerson person = new ModelPerson();
            person.personId = personId;
            nickName = person.getPersonNick();
            if (nickName != null)
                return nickName;
            else
                nickName = person.getPersonName();
            return nickName;
        }
        public static DataTable GetScheduleUsers()
        {
            DataTable scheduleUsers = new DataTable();
            ModelPerson scheduleUser = new ModelPerson();
            scheduleUsers = scheduleUser.getUsersByPermission(2);
            Console.WriteLine("" + scheduleUsers.Rows[0][2]);
            return scheduleUsers;
        }

        public static int getUserId(string userName)
        {
            ModelPerson user = new ModelPerson();
            user.getUserId(userName);
            return user.personId;
        }
        public static void insertStudent(string[] studentData, string username, string password)
        {
            ModelStudent studentToInsert = new ModelStudent();

            studentToInsert.ci = studentData[0];
            studentToInsert.firstName = studentData[1];
            studentToInsert.secondName = studentData[2];
            studentToInsert.firstSurname = studentData[3];
            studentToInsert.secondSurname = studentData[4];

            studentToInsert.registerUser(username, password);
            studentToInsert.getUserId(username);
            studentToInsert.createObjectPerson();
            studentToInsert.insertObject();
            studentToInsert.assignUserRole(2); //roles.ID {1=Teacher, 2=Student}
        }
        public static void insertTeacher(string[] teacherData, string username, string password)
        {
            ModelTeacher teacherToInsert = new ModelTeacher();

            teacherToInsert.ci = teacherData[0];
            teacherToInsert.firstName = teacherData[1];
            teacherToInsert.secondName = teacherData[2];
            teacherToInsert.firstSurname = teacherData[3];
            teacherToInsert.secondSurname = teacherData[4];

            teacherToInsert.registerUser(username, password);
            teacherToInsert.getUserId(username);
            teacherToInsert.createObjectPerson();
            teacherToInsert.insertObject();
            teacherToInsert.assignUserRole(1); //roles.ID {1=Teacher, 2=Student}
        }
        public static void modifyNickName(string nickNameData)
        {
            ModelPerson nickNameToModify = new ModelPerson();
            nickNameToModify.personId = Session.userId;
            nickNameToModify.nickName = nickNameData;
            nickNameToModify.updateNickName();
        }
        public static void modifyPerson(string[] personData)
        {
            ModelPerson personToModify = new ModelPerson();
            personToModify.personId = Int32.Parse(personData[0]);
            personToModify.ci = personData[1];
            personToModify.firstName = personData[2];
            personToModify.secondName = personData[3];
            personToModify.firstSurname = personData[4];
            personToModify.secondSurname = personData[5];
            personToModify.createObjectPersonToModify();
            personToModify.modifyObject();
        }
        public static void modifyUserName(string userNameData, int userIDData)
        {
            ModelPerson userNameToModify = new ModelPerson();
            userNameToModify.updateUserName(userNameData, userIDData);

        }
        public static void listTeacher(string[] teacherData)
        {
            ModelTeacher teacherToList = new ModelTeacher();
            teacherToList.personId = Int32.Parse(teacherData[0]);
            teacherToList.ci = teacherData[1];
            teacherToList.firstName = teacherData[2];
            teacherToList.secondName = teacherData[3];
            teacherToList.firstSurname = teacherData[4];
            teacherToList.secondSurname = teacherData[5];
            teacherToList.createObjectPerson();
            teacherToList.listObjects();
        }
        public static void listStudent(string[] studentData)
        {
            ModelStudent studentToList = new ModelStudent();
            studentToList.personId = Int32.Parse(studentData[0]);
            studentToList.ci = studentData[1];
            studentToList.firstName = studentData[2];
            studentToList.secondName = studentData[3];
            studentToList.firstSurname = studentData[4];
            studentToList.secondSurname = studentData[5];
            studentToList.createObjectPerson();
            studentToList.listObjects();
        }

    }
}
