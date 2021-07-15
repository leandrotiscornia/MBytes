﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ControllerGetConsults
    {
        public static DataTable getConsultsDone(int myId)
        {
            DataTable consultsDone = new DataTable();
            ModelConsult consult = new ModelConsult();
            consult.senderId = myId;
            consultsDone = consult.getConsultsDone();
            return consultsDone;
        }
        public static DataTable getConsultsReceived(int myId)
        {
            DataTable consultsDone = new DataTable();
            ModelConsult consult = new ModelConsult();
            consult.receiverId = myId;
            consultsDone = consult.getConsultsReceived();
            return consultsDone;
        }



    }
}
