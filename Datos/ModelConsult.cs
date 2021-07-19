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
        public string consultTopic { get; set; }
        public string consultState { get; set; }
        public void changeConsultState()
        {
            string commandString;
            commandString =
                "UPDATE consults " +
                "SET State = @consultState " +
                "WHERE ID = @consultId";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@consultState", consultState);
            this.command.Parameters.AddWithValue("@consultId", consultId);
            this.openConnection();
            this.command.Prepare();
            this.command.ExecuteNonQuery();
            this.command.Parameters.Clear();
            this.closeConnection();
        }

        public void createObjectConsult()
        {
            tableName = "consults";
            columnNames = new string[]
            {
                "Sender_ID",
                "Receiver_ID",
                "Topic",
                "State"
            };

            objectValues = new string[]
            {
                senderId.ToString(),
                receiverId.ToString(),
                consultTopic,
                consultState
            };
        }

        public DataTable getConsultsDone()
        {
            DataTable consultsReceived = new DataTable();
            string commandString;
            commandString =
                "SELECT consults.ID, persons.First_Name, persons.First_Surname,Topic, State " +
                "FROM consults " +
                "JOIN users AS sender ON consults.Sender_ID = sender.ID " +
                "JOIN users AS receiver ON consults.Receiver_ID = receiver.ID " +
                "JOIN persons ON receiver.ID = persons.ID " +
                "WHERE sender_ID = @myId;";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@myId", senderId);
            this.openConnection();
            this.reader = this.command.ExecuteReader();
            consultsReceived.Load(reader);
            this.command.Parameters.Clear();
            this.closeConnection();
            return consultsReceived;
        }
        public DataTable getConsultsReceived()
        {
            DataTable consultsReceived = new DataTable();
            string commandString;
            commandString =
                "SELECT consults.ID, persons.First_Name, persons.First_Surname,Topic, State " +
                "FROM consults " +
                "JOIN users as sender ON consults.Sender_ID = sender.ID " +
                "JOIN users as receiver ON consults.Receiver_ID = receiver.ID " +
                "JOIN persons ON sender.ID = persons.ID " +
                "WHERE receiver_ID = @myId;";
            this.command.CommandText = commandString;
            this.command.Parameters.AddWithValue("@myId", receiverId);
            this.openConnection();
            this.reader = this.command.ExecuteReader();
            consultsReceived.Load(reader);
            this.command.Parameters.Clear();
            this.closeConnection();
            return consultsReceived;
        }

    }
}
