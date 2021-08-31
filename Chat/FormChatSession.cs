using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormChatSession : Form, IDisposable
    {
        private int _chatId;
        UserControlMessages messagesControl;
        private int _hostId;
        private bool _readOnlyMode;
        public FormChatSession(int chatId, bool readOnlyMode, int hostId)
        {
            _chatId = chatId;
            _readOnlyMode = readOnlyMode;
            _hostId = hostId;
            InitializeComponent();
            
        }
        private void messagesControl_closeSession(object sender, EventArgs e)
        {
            messagesControl.messagePool.Stop();
            messagesControl.statusCheck.Stop();
            Close();
        }
        private void FormChatSession_Load(object sender, EventArgs e)
        {
            messagesControl = new UserControlMessages(_chatId);
            messagesControl.closeSession += new EventHandler(messagesControl_closeSession);
            if (_readOnlyMode)
            {
                messagesControl.tbMessage.IsEnabled = false;
                messagesControl.btnSend.IsEnabled = false;
                messagesControl.messagePool.IsEnabled = false;
                messagesControl.statusCheck.IsEnabled = false;
            }
            messageHost.Child = messagesControl;
        }

        private void FormChatSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hostId == Session.userId) closeSession();
        }
        private void closeSession()
        {
            ChatSessionController.closeSession(_chatId);
            messagesControl.messagePool.Stop();
            messagesControl.statusCheck.Stop();
        }
    }
    
}