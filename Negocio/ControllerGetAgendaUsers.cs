using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ControllerGetAgendaUsers
    {
        public static DataTable GetAgendaUsers()
        {
            DataTable agendaUsers = new DataTable();
            ModelPerson agendaUser = new ModelPerson();
            agendaUsers = agendaUser.getUsersByPermission(2);
            return agendaUsers;
        }





    }
}
