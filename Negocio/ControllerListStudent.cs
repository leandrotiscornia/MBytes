using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerListStudent
    {
        public void listStudent ( string [] studentData)
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
