using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerListTeacher
    {
        public void listTeacher (string [] teacherData)
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

    }
}
