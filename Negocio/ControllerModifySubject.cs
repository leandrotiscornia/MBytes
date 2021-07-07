using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class ControllerModifySubject
    {
        public void modifySubject (string [] subjectData)
        {
            ModelSubject subjectToModify = new ModelSubject();
            subjectToModify.subjectId = Int32.Parse(subjectData[0]);
            subjectToModify.subjectName = subjectData[1];
            subjectToModify.modifyObject();
        }
    }
}
