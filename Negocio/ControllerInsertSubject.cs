using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerInsertSubject
    {
        public void insertSubject (string [] subjectData)
        {
            ModelSubject subjectToInsert = new ModelSubject();
            subjectToInsert.subjectName = subjectData[0];
            subjectToInsert.insertObject();
        }
    }
}
