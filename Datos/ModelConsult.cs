using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    
    
   public class ModelConsult : ModelDataBaseObject
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

        public DataTable getConsults(string who)
        {
            DataTable consults = new DataTable();
            string commandString;
            
            commandString =
                "SELECT ID,Sender_ID,Receiver_ID,Topic,State " +
                "WHERE @ID = @userID AND State = @state";
                command.CommandText = commandString;
                command.Parameters.AddWithValue("@state", consultState);
            if (who == "sender")
            {
                command.Parameters.AddWithValue("@ID", "Sender_ID");
                command.Parameters.AddWithValue("@userID", senderId);
            }else if (who == "receiver")
            {
                command.Parameters.AddWithValue("@ID", "Receiver_ID");
                command.Parameters.AddWithValue("@userID", receiverId);
            }
            openConnection();
            command.Prepare();
            reader = command.ExecuteReader();
            command.Parameters.Clear();
            consults.Load(reader);
            closeConnection();

            return consults;
        }


    }
}
