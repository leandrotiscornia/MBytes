using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerDeleteGrade
    {
        public void deleteGrade (string [] gradeData)
        {
            ModelGrade gradeToDelete = new ModelGrade();
            gradeToDelete.gradeId = Int32.Parse(gradeData[0]);
            gradeToDelete.deleteObject();
        }
    }
}
