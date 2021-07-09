using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    class ControllerShowConsult
    {
        public DataTable showConsult (int userId , string consultState , string who)
        {
            DataTable consults = new DataTable();
            ModelConsult senderConsultToShow = new ModelConsult();
            senderConsultToShow.senderId = userId;
            senderConsultToShow.receiverId = userId;
            senderConsultToShow.consultState = consultState;
            consults=senderConsultToShow.getConsults(who);

            return consults;
            
        }
      
    }
}
