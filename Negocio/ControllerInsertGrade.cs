using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerInsertGrade
    {
        public void insertGrade ( string [] gradeData)
        {
            ModelGrade gradeToInsert = new ModelGrade();
            gradeToInsert.gradeName = gradeData[0];
            gradeToInsert.insertObject();
        }
    }
}
