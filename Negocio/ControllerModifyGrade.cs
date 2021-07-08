using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerModifyGrade
    {
        public void modifyGrade (string [] gradeData)
        {
            ModelGrade gradeToModify = new ModelGrade();
            gradeToModify.gradeId = Int32.Parse(gradeData[0]);
            gradeToModify.gradeName = gradeData[1];
            gradeToModify.courseName = gradeData[2];
            gradeToModify.modifyObject();

        }
    }
}
