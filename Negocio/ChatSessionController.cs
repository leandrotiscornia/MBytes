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
            return session.listSessions();
        }
        public static DataTable listRegister()
        {
            ModelChatSession session = new ModelChatSession();
            return session.listRegisters();
        }
        public static int openSession(int hostId, string sessionName)
        {
            ModelChatSession session = new ModelChatSession();
            session.hostId = hostId;
            session.sessionName = sessionName;
            session.startTime = DateTime.Now;
            return session.openSession();
        }
        public static void closeSession(int sessionId)
        {
            ModelChatSession session = new ModelChatSession();
            session.sessionId = sessionId;
            session.endTime = DateTime.Now;
            session.closeSession();
        }
    }
}
