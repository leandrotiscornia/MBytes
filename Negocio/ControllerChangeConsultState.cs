using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerChangeConsultState
    {
        public static void changeConsultState(int consultId, string state)
        {
            ModelConsult consult = new ModelConsult();
            consult.consultId = consultId;
            consult.consultState = state;
            consult.changeConsultState();
        }
    }
}
