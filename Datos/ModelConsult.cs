using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    
    
    class ModelConsult : ModelDataBaseObject
    {
        public int consultId { get; set; }
        public int senderId { get; set; }
        public int receiverId { get; set; }
        public string consultTheme { get; set; }
        public string consultState { get; set; }
        public void changeConsultState( int state)
        {
            string[] states = new string[3];
            states[0] = "Done";
            states[1] = "Answered";
            states[2] = "Received";
            states[3] = "Filed";

            consultState = states[state];

        }


    }
}
