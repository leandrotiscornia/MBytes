using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerSendConsult
    {
        public void sendConsult (string [] consultSendData)
        {
            ModelConsultMessage consultToSend = new ModelConsultMessage();
            consultToSend.consultId = Int32.Parse(consultSendData[0]);
            consultToSend.senderId = Int32.Parse(consultSendData[1]);
            consultToSend.message = consultSendData[2];
            consultToSend.date = DateTime.Parse(consultSendData[3]);
            consultToSend.sendConsultMessage();
        }
    }
}
