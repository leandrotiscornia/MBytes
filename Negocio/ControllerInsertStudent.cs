using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
  public class ControllerInsertStudent
    {
        public void insertStudent (string [] studentData)
        {
            ModelPerson studentToInsert = new ModelPerson();
            studentToInsert.ci = studentData[0];
            studentToInsert.firstName = studentData[1];
            studentToInsert.secondName = studentData[2];
            studentToInsert.firstSurname = studentData[3];
            studentToInsert.secondSurname = studentData[4];
            studentToInsert.createObjectPerson();
            studentToInsert.insertObject();
        }
    }
}
