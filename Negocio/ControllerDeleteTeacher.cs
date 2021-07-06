using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerDeleteTeacher
    {
        public void deleteTeacher(string[] teacherData)
        {
            ModelPerson teacherToDelete = new ModelPerson();
            teacherToDelete.personId = Int32.Parse(teacherData[0]);
            teacherToDelete.createObjectPerson();
            teacherToDelete.deleteObject();
        }
    }
}
