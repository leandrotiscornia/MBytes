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
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Collections.Specialized;

namespace Chat
{
    /// <summary>
    /// Lógica de interacción para UserControlMessages.xaml
    /// </summary>
    public partial class UserControlMessages : UserControl
    {
        public DispatcherTimer timer { get; set; }
        private int _chatId;
        private int _randomColor;
        public UserControlMessages(int chatId)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
            timer.Start();
            InitializeComponent();
            _chatId = chatId;
            Random random = new Random();
            _randomColor = random.Next(0, 9);
            we.Content = _randomColor;
            loadMessages();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            loadMessages();
        }
        public void loadMessages()
        {
            Dictionary<int, chatMessage> messagesDictionary = new Dictionary<int, chatMessage>();
            
            foreach (DataRow messageRow in ChatMessageController.listMessages(_chatId).Rows)
            {
                if(!messagesDictionary.ContainsKey(int.Parse(messageRow["ID"].ToString())))
                {
                    messagesDictionary.Add(int.Parse(messageRow["ID"].ToString()), new chatMessage
                        (
                        int.Parse(messageRow["ID"].ToString()),
                        messageRow.Field<DateTime>("Time"),
                        messageRow.Field<string>("Text"),
                        messageRow.Field<string>("Sender Name"),
                        messageRow.Field<int>("Sender_ID"),
                        _randomColor));
                }
            }
            messageBox.ItemsSource = messagesDictionary;
        }
        public void sendMessage()
        {
            ChatMessageController.sendMessage(_chatId, Session.userId, tbMessage.Text);
            loadMessages();
            tbMessage.Clear();
            tbMessage.Focus();
        }
        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            if (tbMessage.Text != "") sendMessage();
        }

       
        private void UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbMessage.IsFocused && e.Key == Key.Enter && tbMessage.Text != "")
                sendMessage();
        }

       
    }
    
}
