using System.Data;

namespace Datos
{


    public class ModelConsultation : ModelDataBaseObject
    {
        public int consultationId { get; set; }
        public int senderId { get; set; }
        public int receiverId { get; set; }
        public string consultationTopic { get; set; }
        public string consultationState { get; set; }
        public void changeConsultationState()
        {
            string commandString;
            commandString =
                "UPDATE consults " +
                "SET State = @consultationState " +
                "WHERE ID = @consultationId";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@consultationState", consultationState);
            command.Parameters.AddWithValue("@consultationId", consultationId);
            executeVoid();
        }
        public void createObjectConsultation()
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
                consultationTopic,
                consultationState
            };
        }

        public DataTable getConsultationssDone()
        {
            DataTable consultationsReceived = new DataTable();
            string commandString;
            commandString =
                "SELECT consults.ID, persons.First_Name, persons.First_Surname,Topic, State " +
                "FROM consults " +
                "JOIN users AS sender ON consults.Sender_ID = sender.ID " +
                "JOIN users AS receiver ON consults.Receiver_ID = receiver.ID " +
                "JOIN persons ON receiver.ID = persons.ID " +
                "WHERE sender_ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", senderId);
            executeAndRead();
            return readTable();
        }
        public DataTable getConsultsReceived()
        {
            DataTable consultationsReceived = new DataTable();
            string commandString;
            commandString =
                "SELECT consults.ID, persons.First_Name, persons.First_Surname,Topic, State " +
                "FROM consults " +
                "JOIN users as sender ON consults.Sender_ID = sender.ID " +
                "JOIN users as receiver ON consults.Receiver_ID = receiver.ID " +
                "JOIN persons ON sender.ID = persons.ID " +
                "WHERE receiver_ID = @myId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@myId", receiverId);
            executeAndRead();
            return readTable();
        }
        public string getConsultationState()
        {
            string commandString =
                "SELECT State " +
                "FROM consults " +
                "WHERE ID = @consultationId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@consultationId", consultationId);
            executeAndRead();
            return readString(0);
        }
        public int getLastInsertId()
        {
            int lastInsertId;
            string commandString;
            commandString = 
                "SELECT LAST_INSERT_ID();";
            command.CommandText = commandString;
            executeAndRead();
            lastInsertId = readInt(0);
            return lastInsertId;
        }
    }
}
