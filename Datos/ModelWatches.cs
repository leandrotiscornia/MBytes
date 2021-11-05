using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
  public class ModelWatches : ModelDataBaseObject
    {
        public int watchId { get; set; }
        public int teacherId { get; set; }

        public DateTime watchDay { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }

        public void insertWatch()
        {
            string commandString;
            commandString =
                "INSERT INTO watches " +
                "(Teacher_ID, Day, Start_Time, EndTime) " +
                "VALUES(@teacherId, @day, @startTime, @endTime);";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId",teacherId);
            command.Parameters.AddWithValue("@day",watchDay);
            command.Parameters.AddWithValue("@startTime",startTime);
            command.Parameters.AddWithValue("@endTime",endTime);
            executeVoid();
        }
        public void deleteWatch()
        {
            string commandString;
            commandString =
                "DELETE " +
                "FROM watches " +
                "WHERE watchId = @watchId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@watchId",watchId);
            executeVoid();
        }
        
        public void modifyWatch()
        {
            string commandString;
            commandString =
                "UPDATE watches " +
                "SET Day = @day " +
                "SET Start_Time = @startTime " +
                "SET End_Time = @endTime " +
                "WHERE ID = @watchId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@watchId", watchId);
            command.Parameters.AddWithValue("@day", watchDay);
            command.Parameters.AddWithValue("@startTime", startTime);
            command.Parameters.AddWithValue("@endTime", endTime);
            executeVoid();
        }
        public DataTable listWatches()
        {
            string commandString;
            commandString =
                "SELECT ID, Day, Start_Time, End_Time " +
                "FROM watches" +
                "WHERE Teacher_ID = @teacherId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", teacherId);
            executeAndRead();
            return readTable();
        }
    }
}
