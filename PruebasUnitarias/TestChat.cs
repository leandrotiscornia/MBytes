using System;
using Datos;
using Negocio;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestChat
    {
        [TestMethod]
        public void AopenSession()
        {
            Globals.chatSessionId = ChatSessionController.openSession(57, "testSession", 25, 17);
            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void BjoinSession()
        {
            ChatSessionController.joinSession(58,Globals.chatSessionId);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CgetSessions()
        {
            Session.userId = 58;
            DataTable sessions = ChatSessionController.listSessions();
            DataRow session = sessions.Rows[sessions.Rows.Count - 1];
            Assert.IsTrue(
                session[0].ToString() == Globals.chatSessionId.ToString() &&
                session[1].ToString() == "57" &&
                session[2].ToString() == "testSession"
                );
        }
        [TestMethod]
        public void DsendMessages()
        {
            ChatMessageController.sendMessage(Globals.chatSessionId, 57, "testMessage1");
            ChatMessageController.sendMessage(Globals.chatSessionId, 58, "testMessage2");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void EgetMessages()
        {
            DataTable messages = ChatMessageController.listMessages(Globals.chatSessionId);
            Assert.IsTrue(
                messages.Rows[0][1].ToString() == "57" &&
                messages.Rows[1][1].ToString() == "58" &&
                messages.Rows[0][3].ToString() == "testMessage1" &&
                messages.Rows[1][3].ToString() == "testMessage2"
                );
        }
        [TestMethod]
        public void FcloseSession()
        {
            ChatSessionController.closeSession(Globals.chatSessionId);
            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void GgetRegisters()
        {
            Session.userId = 58;
            DataTable registers = ChatSessionController.listRegister();
            DataRow register = registers.Rows[registers.Rows.Count - 1];
            Assert.IsTrue(
                register[0].ToString() == Globals.chatSessionId.ToString() &&
                register[1].ToString() == "57" &&
                register[2].ToString() == "testSession"
                );
        }
    }
}
