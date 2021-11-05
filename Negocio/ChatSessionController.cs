using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ChatSessionController
    {
        public static DataTable listSessions()
        {
            ModelChatSession session = new ModelChatSession();
            return session.listSessions(Session.userId);
        }
        public static DataTable listRegister()
        {
            ModelChatSession session = new ModelChatSession();
            return session.listRegisters(Session.userId);
        }
        public static int openSession(int hostId, string sessionName, int groupId, int subjectId)
        {
            ModelChatSession session = new ModelChatSession();
            session.hostId = hostId;
            session.sessionName = sessionName;
            session.startTime = DateTime.Now;
            session.openSession();
            session.getAllowedUsers(groupId, subjectId);
            session.setInvitations();
            return session.sessionId;
        }
        public static void closeSession(int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.endTime = DateTime.Now;
            session.closeSession();
        }
        public static DataTable getHost (int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            return session.showHost();
        }
        public static DataTable getStudents(int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            return session.showStudents();
        }
        public static DataTable getTeacher(int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            return session.showTeacher();
        }
        public static string checkSessionEndTime(int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            return session.getEndTime();
        }
        public static void setInactive(int userId, int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.setInactive(userId);
        }
        public static void joinSession(int userId, int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.joinSession(userId);
        }
        public static void abandonSession(int userId, int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.abandonSession(userId);
        }
        public static void setActive(int userId, int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.setActive(userId);
        }
    }
}
