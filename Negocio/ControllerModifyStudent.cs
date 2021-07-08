using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerModifyStudent
    {
        public void modifyStudent (string [] studentData)
        {
            ModelStudent studentToModify = new ModelStudent();
            studentToModify.personId = Int32.Parse(studentData[0]);
            studentToModify.ci = studentData[1];
            studentToModify.firstName = studentData[2];
            studentToModify.secondName = studentData[3];
            studentToModify.firstSurname = studentData[4];
            studentToModify.secondSurname = studentData[5];
            studentToModify.createObjectPerson();
            studentToModify.modifyObject();
        }
    }
}
