using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerOpenConsult
    {
        public void openConsult ( string [] consultOpenData)
        {
            ModelConsultMessage consultToOpen = new ModelConsultMessage();
            consultToOpen.consultId = Int32.Parse(consultOpenData[0]);
            consultToOpen.getConsultMessages(consultToOpen.consultId);
        }
    }
}
