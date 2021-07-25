using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
  public static class ControllerInsertStudent
    {
        public static void insertStudent(string[] studentData, string username, string password)
        {
            ModelStudent studentToInsert = new ModelStudent();
            
            studentToInsert.ci = studentData[0];
            studentToInsert.firstName = studentData[1];
            studentToInsert.secondName = studentData[2];
            studentToInsert.firstSurname = studentData[3];
            studentToInsert.secondSurname = studentData[4];

            studentToInsert.registerUser(username, password);
            studentToInsert.personId = studentToInsert.getUserId(username);
            studentToInsert.createObjectPerson();
            studentToInsert.insertObject();
            studentToInsert.assignUserRole(2); //roles.ID {1=Teacher, 2=Student}
            
        }
    }
}
