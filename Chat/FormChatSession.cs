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
        private int _senderId;
        private DateTime _date;
        private string _text;


        public FormChatSession(int chatId, int senderId, DateTime date, string text)
    {
        InitializeComponent();
        this._chatId = chatId;
        this._senderId = senderId;
        this._date = date;
        this._text = text;
        }


        private void loadChatMessages()
        {
            DataTable chatMessage = new DataTable();
            chatMessage = ChatMessageController.getChatMessage(_chatId);
            rtbReadMessages.Clear();
            foreach (DataRow chatMessages in chatMessage.Rows)
            {
                string nickName;
                nickName = PersonController.getPersonNick(Int32.Parse(chatMessages[0].ToString()));
                rtbReadMessages.AppendText(nickName + "\n");
                rtbReadMessages.AppendText(chatMessages[1].ToString() + "\n");
            }

        }
        private void FormChatSession_Load(object sender, EventArgs e)
        {
            loadChatMessages();
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string chatMessage = txbWriteMessage.Text;
            ChatMessageController.sendChatMessage(_chatId, Session.userId, chatMessage);
            this.Close();
        }

    }
}