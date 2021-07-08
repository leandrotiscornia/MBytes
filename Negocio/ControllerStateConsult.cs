using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerStateConsult 
    {
        public void changeStateConsult(string[] consultStateData)
        {
           
            ModelConsult consultStateToChange = new ModelConsult();
            consultStateToChange.consultState = consultStateData[0];
            consultStateToChange.changeConsultState(Int32.Parse(consultStateData[0]));
                
            
        }    
    }
}
