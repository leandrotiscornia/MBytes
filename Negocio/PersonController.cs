using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class PersonController
    {
        public static string login(string userName, string userPassword, int userRole)
        { 
            string result;
            ModelPerson user = new ModelPerson();
            user.userName = userName;
            user.userPassword = DataBaseController.encryptPassword(userPassword);
            if (userName == "")
                result = "You need to set an user name";
            else if (user.userPassword == "")
                result = "You need to set your password";
            else if (user.userName != user.getUserName())
                result = "That user does not exist";
            else if (user.userPassword != user.checkUserPassword())
                result = "Incorrect password";
            else if(userRole == 0)
            {
                if (user.isAdmin())
                {
                    user.getUserId();
                    Session.userId = user.personId;
                    result = "";
                }
                else result = "Access Denied For This User";
            }
            else if (!(userRole == user.checkUserRole()) && userRole != 0)
                result = "Access Denied For This User";
            else
            {
                user.getUserId();
                user.getUserCI();
                Session.userId = user.personId;
                Session.ci = user.ci;
                result = "";
            }
            return result;
        }
        public static void deleteStudent(int id)
        {
            ModelPerson studentToDelete = new ModelPerson();
            studentToDelete.personId = id;
            studentToDelete.deleteStudent();
        }
        public static void deleteTeacher(int id)
        {
            ModelPerson teacherToDelete = new ModelPerson();
            teacherToDelete.personId = id;
            teacherToDelete.deleteTeacher();
        }
        public static List<string> getFeatures()
        {
            List<string> features;
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            features = person.getFeatures();
            return features;
        }
        public static List<string> getProfileData(int userId)
        {
            List<string> profileData = new List<string>();
            ModelPerson person = new ModelPerson();
            person.personId = userId;
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
            return scheduleUsers;
        }

        public static int getUserId(string userName)
        {
            ModelPerson user = new ModelPerson();
            user.userName = userName;
            user.getUserId();
            return user.personId;
        }
        public static void insertStudent(string[] studentData, string userName, string password)
        {
            ModelStudent studentToInsert = new ModelStudent();

            studentToInsert.ci = studentData[0];
            studentToInsert.firstName = studentData[1];
            studentToInsert.secondName = studentData[2];
            studentToInsert.firstSurname = studentData[3];
            studentToInsert.secondSurname = studentData[4];
            studentToInsert.userName = userName;
            studentToInsert.userPassword = DataBaseController.encryptPassword(password);
            studentToInsert.registerUser();
            studentToInsert.getUserId();
            studentToInsert.createPersonObject();
            studentToInsert.insertObject();
            studentToInsert.assignUserRole(2); //roles.ID {1=Teacher, 2=Student}
        }
        public static void insertTeacher(string[] teacherData, string userName, string password)
        {
            ModelTeacher teacherToInsert = new ModelTeacher();

            teacherToInsert.ci = teacherData[0];
            teacherToInsert.firstName = teacherData[1];
            teacherToInsert.secondName = teacherData[2];
            teacherToInsert.firstSurname = teacherData[3];
            teacherToInsert.secondSurname = teacherData[4];
            teacherToInsert.userName = userName;
            teacherToInsert.userPassword = DataBaseController.encryptPassword(password);
            teacherToInsert.registerUser();
            
            teacherToInsert.getUserId();
            teacherToInsert.createPersonObject();
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
            personToModify.createPersonObjectToModify();
            personToModify.modifyObject();
        }
        public static void modifyUserName(string userNameData, int userIDData)
        {
            ModelPerson userNameToModify = new ModelPerson();
            userNameToModify.updateUserName(userNameData, userIDData);

        }
        public static DataTable listTeacher()
        {
            ModelTeacher teacherToList = new ModelTeacher();
            return teacherToList.getUsersByRole(1);
        }
        public static DataTable listStudent()
        {
            ModelStudent studentToList = new ModelStudent();
            return studentToList.getUsersByRole(2);
        }
        public static void changePassword(string newPassword, string oldPassword)
        {
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            person.userPassword = DataBaseController.encryptPassword(oldPassword);
            person.getUserPassword();
            if ((person.userPassword == null))
                throw new Exception("Incorrect Password");
            else
            {
                person.userPassword = DataBaseController.encryptPassword(newPassword);
                person.updatePassword();
            }
        }
    }
}
