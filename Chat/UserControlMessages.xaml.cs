using System;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JB.Collections.Reactive;
using System.Windows.Threading;
using System.Collections.Specialized;

namespace Chat
{
    /// <summary>
    /// Lógica de interacción para UserControlMessages.xaml
    /// </summary>
    public partial class UserControlMessages : UserControl
    {
        public DispatcherTimer messagePool { get; set; }
        public DispatcherTimer statusCheck { get; set; }
        public DispatcherTimer activityCheck { get; set; }
        private int _chatId;
        public ConnectedUser host { get; set; }
        public ConnectedUser teacher { get; set; }
        public EventHandler closeSession;
        public ObservableDictionary<int, ChatMessage> messageDictionary { get; set;}
        public ObservableDictionary<int, ConnectedUser> hostDictionary { get; set; } 
        public ObservableDictionary<int, ConnectedUser> teacherDictionary { get; set; }
        public ObservableDictionary<int, ConnectedUser> studentDictionary { get; set; }
        private string userStatus;
        
        public UserControlMessages(int chatId)
        {
            studentDictionary = new ObservableDictionary<int, ConnectedUser>();
            messageDictionary = new ObservableDictionary<int, ChatMessage>();
            teacherDictionary = new ObservableDictionary<int, ConnectedUser>();
            hostDictionary = new ObservableDictionary<int, ConnectedUser>();
            userStatus = "Online";
            
            messagePool = new DispatcherTimer();
            messagePool.Interval = TimeSpan.FromSeconds(0.5);
            messagePool.Tick += pool_Tick;
            messagePool.Start();
            
            statusCheck = new DispatcherTimer();
            statusCheck.Interval = TimeSpan.FromSeconds(3);
            statusCheck.Tick += status_Tick;
            statusCheck.Start();

            activityCheck = new DispatcherTimer();
            activityCheck.Interval = TimeSpan.FromMinutes(0.5);
            activityCheck.Tick += activity_Tick;
            activityCheck.Start();

            InitializeComponent();
            _chatId = chatId;
            loadMessages();
            loadStudents();
            loadTeachers();
            loadHost();
            messageBox.ItemsSource = messageDictionary;
            studentsBox.ItemsSource = studentDictionary;
            teacherBox.ItemsSource = teacherDictionary;
            hostBox.ItemsSource = hostDictionary;
        }
        private void activity_Tick(object sender, EventArgs e)
        {
            setInactive();
        }
        private void pool_Tick(object sender, EventArgs e)
        {
            loadMessages();
        }
        private void status_Tick(object sender, EventArgs e)
        {
            checkStatus();
            loadStudents();
            loadTeachers();
        }
        private void checkStatus()
        {
            string endTime = ChatSessionController.checkSessionEndTime(_chatId);
            if (endTime != null)
            {
                MessageBox.Show("This session was closed at " + endTime, "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                Focusable = false;
                closeSession?.Invoke(this, null);
            }
        }
        private void loadMessages()
        {
            int messageIdIndex;
            foreach (DataRow messageRow in ChatMessageController.listMessages(_chatId).Rows)
            {
                messageIdIndex = int.Parse(messageRow["ID"].ToString());
                if (!messageDictionary.ContainsKey(messageIdIndex))
                {
                    messageDictionary.Add(messageIdIndex, new ChatMessage(
                    messageIdIndex,
                    messageRow.Field<DateTime>("Time"),
                    messageRow.Field<string>("Text"),
                    PersonController.getPersonNick(int.Parse(messageRow["Sender_ID"].ToString())),
                    messageRow.Field<int>("Sender_ID"),
                    _chatId,
                    messageRow.Field<string>("CI")));
                } else if (messageDictionary[messageIdIndex].text != messageRow.Field<string>("Text"))
                {
                    messageDictionary[messageIdIndex].text = messageRow.Field<string>("Text");
                    messageDictionary[messageIdIndex].time = messageRow.Field<DateTime>("Time");
                }
            }
        }
        public void loadStudents()
        {
            foreach (DataRow studentRow in ChatSessionController.getStudents(_chatId).Rows)
            {
                if (!studentDictionary.ContainsKey(int.Parse(studentRow["ID"].ToString())))
                {
                    studentDictionary.Add(int.Parse(studentRow["ID"].ToString()), new ConnectedUser(
                    int.Parse(studentRow["ID"].ToString()),
                    studentRow["CI"].ToString(),
                    studentRow["Nick_Name"].ToString(),
                    studentRow["First_Name"] + " " + studentRow["First_Surname"],
                    studentRow["Name"].ToString(),
                    studentRow["Status"].ToString()
                    ));
                }
                else
                {
                    studentDictionary[int.Parse(studentRow["ID"].ToString())].status = studentRow["Status"].ToString();
                    studentDictionary[int.Parse(studentRow["ID"].ToString())].statusCheck();
                }
                    
            }
        }
        public void loadTeachers()
        {
            DataTable teachers = ChatSessionController.getTeacher(_chatId);
            if (teachers.Rows.Count == 0)
                return;
            DataRow teacherRow = teachers.Rows[0];
            if (!teacherDictionary.ContainsKey(int.Parse(teacherRow["ID"].ToString())))
            {
                teacherDictionary.Add(int.Parse(teacherRow["ID"].ToString()), new ConnectedUser(
                int.Parse(teacherRow["ID"].ToString()),
                teacherRow["CI"].ToString(),
                teacherRow["Nick_Name"].ToString(),
                teacherRow["First_Name"] + " " + teacherRow["First_Surname"],
                teacherRow["Name"].ToString(),
                teacherRow["Status"].ToString()
                ));
            }
            else
            {
                teacherDictionary[int.Parse(teacherRow["ID"].ToString())].status = teacherRow["Status"].ToString();
                teacherDictionary[int.Parse(teacherRow["ID"].ToString())].statusCheck();
            }
        }
        public void loadHost()
        {
            DataRow hostRow = ChatSessionController.getHost(_chatId).Rows[0];
            if (!hostDictionary.ContainsKey(int.Parse(hostRow["ID"].ToString())))
            {
                hostDictionary.Add(int.Parse(hostRow["ID"].ToString()), new ConnectedUser(
                int.Parse(hostRow["ID"].ToString()),
                hostRow["CI"].ToString(),
                hostRow["Nick_Name"].ToString(),
                hostRow["First_Name"] + " " + hostRow["First_Surname"],
                hostRow["Name"].ToString(),
                "Host"
                ));
            }
        }
        public void readMessages()
        {

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
            resetTimer(activityCheck);
        }

        private void resetTimer(DispatcherTimer timer)
        {
            timer.Stop();
            timer.Start();
        }
        private void setInactive()
        {
            ChatSessionController.setInactive(Session.userId, _chatId);
            userStatus = "Inactive";
        }

        private void TbMessage_TextInput(object sender, TextCompositionEventArgs e)
        {
            resetTimer(activityCheck);
            if(userStatus != "Online")
            {
                ChatSessionController.setActive(Session.userId, _chatId);
                userStatus = "Online";
            }
        }

        private void TbMessage_TouchEnter(object sender, TouchEventArgs e)
        {
            if (tbMessage.Text != "") sendMessage();
        }
    }
    
}
