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
    public partial class FormChatSession : Form
    {
        private int _chatId;

        public FormChatSession(int chatId)
        {
            InitializeComponent();
        }

        private void FormChatSession_Load(object sender, EventArgs e)
        {
            UserControlMessages messagesControl = new UserControlMessages(_chatId);
            messageHost.Child = messagesControl;
        }

        
    }
    
}