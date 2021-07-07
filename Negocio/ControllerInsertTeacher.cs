using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerInsertTeacher 
    {
        public void insertTeacher(string [] teacherData)
        {
            ModelPerson teacherToInsert = new ModelPerson();
            teacherToInsert.ci = teacherData[0];
            teacherToInsert.firstName = teacherData[1];
            teacherToInsert.secondName = teacherData[2];
            teacherToInsert.firstSurname = teacherData[3];
            teacherToInsert.secondSurname = teacherData[4];
            teacherToInsert.createObjectPerson();
            teacherToInsert.insertObject();
        }

        
    }
}
