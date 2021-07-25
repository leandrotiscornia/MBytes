using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerInsertTeacher 
    {
        

        public static void insertTeacher(string[] teacherData, string username, string password)
        {
            
            ModelTeacher teacherToInsert = new ModelTeacher();

            teacherToInsert.ci = teacherData[0];
            teacherToInsert.firstName = teacherData[1];
            teacherToInsert.secondName = teacherData[2];
            teacherToInsert.firstSurname = teacherData[3];
            teacherToInsert.secondSurname = teacherData[4];

            teacherToInsert.registerUser(username, password);
            teacherToInsert.personId = teacherToInsert.getUserId(username);
            teacherToInsert.createObjectPerson();
            teacherToInsert.insertObject();
            teacherToInsert.assignUserRole(1); //roles.ID {1=Teacher, 2=Student}
            
        }
        
        
    }
}
