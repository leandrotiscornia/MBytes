using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class GroupController
    {
        public static void insertGroup(string groupName,string shift, int gradeId)
        {
            ModelGroup group = new ModelGroup();
            group.groupName = groupName;
            group.shift = shift;
            group.insertGroup(gradeId);
        }
        public static void modifyGroup(string groupName, string shift, int groupId)
        {
            ModelGroup group = new ModelGroup();
            group.groupName = groupName;
            group.shift = shift;
            group.groupId = groupId;
            group.modifyGroup();
        }
       
        public static void deleteGroup(int groupId)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.deleteGroup();
        }
        public static DataTable listGroupsWithStudents()
        {
            DataTable result = new DataTable("students");
            ModelGroup groupToList = new ModelGroup();
            result.Columns.Add("ID", System.Type.GetType("System.Int32"));
            result.Columns.Add("Group Name");
            for (int i = 1; i < 31; i++)
                result.Columns.Add("Student " + i);
            foreach (DataRow group in groupToList.listGroups().Rows)
            {
                groupToList.groupId = int.Parse(group["ID"].ToString());
                List<string> students = groupToList.getStudents();
                DataRow resultRow = result.NewRow();
                resultRow[0] = groupToList.groupId;
                resultRow[1] = group["Grade Name"].ToString().Substring(0, 2) + group["Group Name"].ToString();
                for (int i = 0; i < 12; i++)
                    if (students.ElementAtOrDefault(i) != null) resultRow[i + 2] = students[i];
                result.Rows.Add(resultRow);
            }
            return result;
        }
        public static DataTable listInscriptedGroups(string userCI)
        {
            DataTable result = new DataTable("students");
            ModelGroup groupToList = new ModelGroup();
            result.Columns.Add("ID", System.Type.GetType("System.Int32"));
            result.Columns.Add("Group Name");
            result.Columns.Add("Shift");
            foreach (DataRow group in groupToList.listInscriptedGroups(userCI).Rows)
            {
                groupToList.groupId = int.Parse(group["ID"].ToString());
                DataRow resultRow = result.NewRow();
                resultRow[0] = groupToList.groupId;
                resultRow[1] = group["Grade Name"].ToString().Substring(0, 2) + group["Group Name"].ToString();
                resultRow[2] = group["Shift"].ToString();
                result.Rows.Add(resultRow);
            }
            return result;
        }

        public static DataTable listGroups()
        {
            DataTable result = new DataTable("students");
            ModelGroup groupToList = new ModelGroup();
            result.Columns.Add("ID", System.Type.GetType("System.Int32"));
            result.Columns.Add("Group Name");
            result.Columns.Add("Shift");
            foreach (DataRow group in groupToList.listGroups().Rows)
            {
                groupToList.groupId = int.Parse(group["ID"].ToString());
                DataRow resultRow = result.NewRow();
                resultRow[0] = groupToList.groupId;
                resultRow[1] = group["Grade Name"].ToString().Substring(0, 2) + group["Group Name"].ToString();
                resultRow[2] = group["Shift"].ToString();
                result.Rows.Add(resultRow);
            }
            return result;
        }
        public static DataTable listSubjectsByGroup(int groupId)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            return group.listSubjectsByGroup();
        }
        public static DataTable listInscriptionSubjects(int groupId, string studentCI)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            return group.listInscriptionSubjects(studentCI);
        }
        public static DataTable listClassSubjects(int groupId, string teacherCI)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            return group.listClassSubjects(teacherCI);
        }
        public static List<string> getGroupData(int groupId)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            return group.getGroup();
        } 
        public static void clearInscriptions(int groupId)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.clearInscriptions();
        }
        public static DataTable listInscriptions()
        {
            DataTable inscriptions = new DataTable();
            inscriptions.Columns.Add("Group ID");
            inscriptions.Columns.Add("CI");
            inscriptions.Columns.Add("Subject ID");
            inscriptions.Columns.Add("First_Name");
            inscriptions.Columns.Add("First_Surname");
            inscriptions.Columns.Add("Group");
            inscriptions.Columns.Add("Subject");
            inscriptions.Columns.Add("Status");
            inscriptions.Columns.Add("Type");
            
            ModelGroup group = new ModelGroup();
            foreach(DataRow student in group.listStudentInscriptions().Rows)
            {
                DataRow inscription = inscriptions.NewRow();
                for (int i = 0; i <= 7; i++)
                    inscription[i] = student[i].ToString();
                inscription["Type"] = "Student";
                inscriptions.Rows.Add(inscription);
            }
            foreach (DataRow teacher in group.listTeacherInscriptions().Rows)
            {
                DataRow inscription = inscriptions.NewRow();
                for (int i = 0; i <= 7; i++)
                    inscription[i] = teacher[i].ToString();
                inscription["Type"] = "Teacher";
                inscriptions.Rows.Add(inscription);
            }
            return inscriptions;
        }
        public static void requestStudentInscription(string studentCI, int groupId, List<int> subjects)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.requestStudentInscription(studentCI, subjects);
        }
        public static void requestTeacherInscription(string teacherCI, int groupId, List<int> subjects)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.requestTeacherInscription(teacherCI, subjects);
        }
        public static void updateStudentRequestStatus(string CI, int groupId, int subjectId, string status)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.updateStudentRequestStatus(CI, subjectId, status);
        }

        public static void updateTeacherRequestStatus(string CI, int groupId, int subjectId, string status)
        {
            ModelGroup group = new ModelGroup();
            group.groupId = groupId;
            group.updateTeacherRequestStatus(CI, subjectId, status);
        }
        public static DataTable loadStudentInscriptions(string CI)
        {
            ModelGroup group = new ModelGroup();
            return group.getPendingInscriptions(CI);
        }
        public static DataTable loadTeacherInscriptions(string CI)
        {
            ModelGroup group = new ModelGroup();
            return group.getPendingClasses(CI);
        }
    }
}
