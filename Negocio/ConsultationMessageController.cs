using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ConsultationMessageController
    {
        public static DataTable getConsultationMessages(int consultationId)
        {
            ModelConsultationMessage messages = new ModelConsultationMessage();
            messages.consultationId = consultationId;
            DataTable messagesTable = messages.getConsultationMessages();
            return messagesTable;
        }
        public static void sendConsultationMessage(int consultationId, int senderId, string message)
        {
            ModelConsultationMessage consultationMessage = new ModelConsultationMessage();
            consultationMessage.consultationId = consultationId;
            consultationMessage.senderId = senderId;
            consultationMessage.message = message;
            consultationMessage.sendConsultationMessage();
        }
        
    }


}

