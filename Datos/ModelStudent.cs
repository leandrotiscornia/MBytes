﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class ModelStudent : ModelPerson
    {
        public List<List<string>> subjectsCoursing { get; set; }

        public List<List<string>> getSubjectsCoursing(int studentId)
        {
            List<List<string>> subjectsCoursing = new List<List<string>>();
            List<string> subjects = new List<string>();
            List<string> groups = new List<string>();
            string commandString;
            commandString =
                "SELECT Group_ID, Subject_ID " +
                "FROM Coursing " +
                "WHERE Student_ID = @studentId";
            command.CommandText = commandString;
            command.Prepare();
            openConnection();
            reader = command.ExecuteReader();
            closeConnection();

            while (reader.Read())
            {
                groups.Add(reader.GetString(0));
                subjects.Add(reader.GetString(1));
            }
            subjectsCoursing.Add(groups);
            subjectsCoursing.Add(subjects);

            return subjectsCoursing;
        }

        public void assignSubjectCoursing (int studentId, int groupId, int subjectId)
        {
            string commandString;
            commandString =
                "INSERT INTO Coursing " +
                "(Student_ID, Group_ID, Subject_ID) " +
                "VALUES (@studentId, @groupId, @subjectId)";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@teacherId", studentId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);
            command.Prepare();
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();


        }

        public void deleteSubjectCoursing (int studentId, int groupId, int subjectId)
        {
            string commandString;
            commandString = 
                "DELETE FROM Coursing" +
                " WHERE Student_ID=@studentId AND Group_ID = @groupId AND Subject_ID=@subjectId;";
            command.CommandText = commandString;
            command.Parameters.AddWithValue("@studentId", studentId);
            command.Parameters.AddWithValue("@groupId", groupId);
            command.Parameters.AddWithValue("@subjectId", subjectId);

            command.Prepare();
            command.ExecuteNonQuery();
        }


    }
}