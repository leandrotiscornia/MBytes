using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class ControllerDeleteSubject
    {
        public void deleteSubject( string [] subjectData)
        {
            ModelSubject subjectToDelete = new ModelSubject();
            subjectToDelete.subjectId = Int32.Parse(subjectData[0]);
            subjectToDelete.deleteObject();
        }
    }
}
