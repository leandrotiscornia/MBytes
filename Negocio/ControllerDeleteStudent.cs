using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerDeleteStudent
    {
        public void deleteStudent (string [] studentData)
        {
            ModelPerson studentToDelete = new ModelPerson();
            studentToDelete.personId = Int32.Parse(studentData[0]);
            studentToDelete.createObjectPerson();
            studentToDelete.deleteObject();

        }
    }
}
