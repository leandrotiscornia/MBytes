using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public static class ControllerSendConsultMessage
    {
        public static void sendConsultMessage(int consultId, int senderId, string message)
        {
            ModelConsultMessage consultMessage = new ModelConsultMessage();
            consultMessage.consultId = consultId;
            consultMessage.senderId = senderId;
            consultMessage.message = message;
            consultMessage.sendConsultMessage();
        }
        public static void sendConsultMessage(int senderId, string message)
        {
            ModelConsultMessage consultMessage = new ModelConsultMessage();
            consultMessage.senderId = senderId;
            consultMessage.message = message;
            consultMessage.sendFirstMessage();
        }
    }
}
