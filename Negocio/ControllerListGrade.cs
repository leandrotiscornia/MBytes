using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerListGrade
    {
        public void listGrade(string[] gradeData)
        {
            ModelGrade gradeToList = new ModelGrade();
            gradeToList.gradeId = Int32.Parse(gradeData[0]);
            gradeToList.gradeName = gradeData[1];
            gradeToList.listObjects();
        }
        
    }
}
