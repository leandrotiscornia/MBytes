using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ControllerGetScheduleUsers
    {
        public static DataTable GetScheduleUsers()
        {
            DataTable scheduleUsers = new DataTable();
            ModelPerson scheduleUser = new ModelPerson();
            scheduleUsers = scheduleUser.getUsersByPermission(2);
            Console.WriteLine("" + scheduleUsers.Rows[0][2]);
            return scheduleUsers;
        }





    }
}
