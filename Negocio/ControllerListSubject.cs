using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class ControllerListSubject
    {
        public void listSubject (string [] dataSubject)
        {
            ModelSubject subjectToList = new ModelSubject();
            subjectToList.subjectId = Int32.Parse(dataSubject[0]);
            subjectToList.subjectName = dataSubject[1];
            subjectToList.listObjects();
        }
    }
}
