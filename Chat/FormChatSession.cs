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
        private bool _readOnlyMode;
        public FormChatSession(int chatId, bool readOnlyMode)
        {
            _chatId = chatId;
            _readOnlyMode = readOnlyMode;
            InitializeComponent();
        }

        private void FormChatSession_Load(object sender, EventArgs e)
        {
            messagesControl = new UserControlMessages(_chatId);
            if (_readOnlyMode)
            {
                messagesControl.tbMessage.IsEnabled = false;
                messagesControl.btnSend.IsEnabled = false;
                messagesControl.timer.IsEnabled = false;
            }
            messageHost.Child = messagesControl;
        }

        private void FormChatSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatSessionController.closeSession(_chatId);
            messagesControl.timer.Stop();
        }
    }
    
}