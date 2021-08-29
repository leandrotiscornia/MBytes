using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using Negocio;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat
{
    /// <summary>
    /// Lógica de interacción para UserControlMessages.xaml
    /// </summary>
    public partial class UserControlMessages : UserControl
    {
        private Dictionary<int, chatMessage> messagesDictionary;
        private int _chatId;
        public UserControlMessages(int chatId)
        {
            messagesDictionary = new Dictionary<int, chatMessage>();
            InitializeComponent();
            _chatId = chatId;
        }

        public void loadMessages()
        {
            foreach(DataRow messageRow in ChatMessageController.listMessages(_chatId).Rows)
            {
                if(messagesDictionary[messageRow.Field<int>("ID")] != null)
                {
                    messagesDictionary.Add(messageRow.Field<int>("ID"), new chatMessage
                        (
                        messageRow.Field<int>("ID"),
                        messageRow.Field<DateTime>("Time"),
                        messageRow.Field<string>("Text"),
                        messageRow.Field<string>("Sender Name")
                        ));
                }
                messageBox.ItemsSource = messagesDictionary;
            }
        }
        public void sendMessage()
        {
            ChatMessageController.sendMessage(_chatId, Session.userId, tbMessage.Text);
            loadMessages();
        }
        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            if (tbMessage.Text != null) sendMessage();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadMessages();
        }
    }
    
}
