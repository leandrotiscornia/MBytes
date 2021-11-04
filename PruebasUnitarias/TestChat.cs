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
            Globals.chatSessionId = ChatSessionController.openSession(71, "testSession", 25, 17);
            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void BjoinSession()
        {
            ChatSessionController.joinSession(70,Globals.chatSessionId);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CgetSessions()
        {
            Session.userId = 70;
            DataTable sessions = ChatSessionController.listSessions();
            DataRow session = sessions.Rows[sessions.Rows.Count - 1];
            Assert.IsTrue(
                session[0].ToString() == Globals.chatSessionId.ToString() &&
                session[1].ToString() == "71" &&
                session[2].ToString() == "testSession"
                );
        }
        [TestMethod]
        public void DsendMessages()
        {
            ChatMessageController.sendMessage(Globals.chatSessionId, 71, "testMessage1");
            ChatMessageController.sendMessage(Globals.chatSessionId, 70, "testMessage2");
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void EgetMessages()
        {
            DataTable messages = ChatMessageController.listMessages(Globals.chatSessionId);
            Assert.IsTrue(
                messages.Rows[0][1].ToString() == "71" &&
                messages.Rows[1][1].ToString() == "70" &&
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
            Session.userId = 70;
            DataTable registers = ChatSessionController.listRegister();
            DataRow register = registers.Rows[registers.Rows.Count - 1];
            Assert.IsTrue(
                register[0].ToString() == Globals.chatSessionId.ToString() &&
                register[1].ToString() == "71" &&
                register[2].ToString() == "testSession"
                );
        }
    }
}
