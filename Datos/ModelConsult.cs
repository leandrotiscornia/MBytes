using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelConsult : ModelDataBaseObject
    {
        private int _consultId;
        private int _senderId;
        private int _receiverId;
        private string _consultTheme;
        private string _consultState;

        public int consultId
        {
            get { return _consultId; }
            set { _consultId = value; }
        }
        public int senderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public int receiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }
        public string consultTheme
        {
            get { return _consultTheme; }
            set { _consultTheme = value; }
        }
        public string consultState
        {
            get { return _consultState; }
            set { _consultState = value; }
        }
        public void changeConsultState( int state)
        {
            string[] states = new string[3];
            states[0] = "Done";
            states[1] = "Answered";
            states[2] = "Received";
            states[3] = "Filed";

            _consultState = states[state];

        }


    }
}
