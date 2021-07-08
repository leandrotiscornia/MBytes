using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerModifyTeacher
    {
        public void modifyTeacher (string [] teacherData)
        {
            ModelTeacher teacherToModify = new ModelTeacher();
            teacherToModify.personId = Int32.Parse(teacherData[0]);
            teacherToModify.firstName = teacherData[1];
            teacherToModify.secondName = teacherData[2];
            teacherToModify.firstSurname = teacherData[3];
            teacherToModify.secondSurname = teacherData[4];
            teacherToModify.createObjectPerson();
            teacherToModify.modifyObject();
            
        }
    }
}
