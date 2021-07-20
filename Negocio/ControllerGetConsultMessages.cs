using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Negocio
{
    public static class ControllerGetConsultMessages
    {
        public static DataTable getConsultMessages(int consultId)
        {
            ModelConsultMessage messages = new ModelConsultMessage();
            messages.consultId = consultId;
            DataTable messagesTable = messages.getConsultMessages();
            return messagesTable;
        } 






    }
}
