using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerNewConsult
    {
        public static void newConsult(int senderId, int receiverId, string topic)
        {
            ModelConsult consult = new ModelConsult();
            consult.senderId = senderId;
            consult.receiverId = receiverId;
            consult.consultTopic = topic;
            consult.consultState = "Done";
            consult.createObjectConsult();
            consult.insertObject();

        }

    }
}
