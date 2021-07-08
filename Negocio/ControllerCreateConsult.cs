using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerCreateConsult
    {
        public void createConsult ( string [] consultData)
        {
            
            ModelConsult consultToCreate = new ModelConsult();
            consultToCreate.senderId = Int32.Parse(consultData[0]);
            consultToCreate.receiverId = Int32.Parse(consultData[1]);
            consultToCreate.consultTheme = consultData[2];
            consultToCreate.insertObject();
        }
    }
}
