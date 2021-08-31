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
        private int _chatId;
        public ConnectedUser host { get; set; }
        public ConnectedUser teacher { get; set; }
        public ObservableCollection<ConnectedUser> students { get; set; } = new ObservableCollection<ConnectedUser>();
        public EventHandler closeSession;
        
        public UserControlMessages(int chatId)
        {
            messagePool = new DispatcherTimer();
            messagePool.Interval = TimeSpan.FromSeconds(0.5);
            messagePool.Tick += pool_Tick;
            messagePool.Start();

            statusCheck = new DispatcherTimer();
            statusCheck.Interval = TimeSpan.FromSeconds(3);
            statusCheck.Tick += status_Tick;
            statusCheck.Start();
            InitializeComponent();
            _chatId = chatId;
            loadMessages();
            

        }
        private void pool_Tick(object sender, EventArgs e)
        {
            loadMessages();
        }
        private void status_Tick(object sender, EventArgs e)
        {
            checkStatus();
            loadUsers();
        }
        private void checkStatus()
        {
            string endTime = ChatSessionController.checkSessionEndTime(_chatId);
            if (endTime != null)
            {
                MessageBox.Show("This session was closed at " + endTime, "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                closeSession?.Invoke(this, null);
            }
        }
        private void loadMessages()
        {
            Dictionary<int, ChatMessage> messageDictionary = new Dictionary<int, ChatMessage>();
            
            foreach (DataRow messageRow in ChatMessageController.listMessages(_chatId).Rows)
            {
                if(!messageDictionary.ContainsKey(int.Parse(messageRow["ID"].ToString())))
                {
                    messageDictionary.Add(int.Parse(messageRow["ID"].ToString()), new ChatMessage
                        (
                        int.Parse(messageRow["ID"].ToString()),
                        messageRow.Field<DateTime>("Time"),
                        messageRow.Field<string>("Text"),
                        PersonController.getPersonNick(int.Parse(messageRow["Sender_ID"].ToString())),
                        messageRow.Field<int>("Sender_ID"),
                        _chatId,
                        messageRow.Field<string>("CI")));
                }
            }
            
            messageBox.ItemsSource = messageDictionary;
        }
        public void loadUsers()
        {
            //DataTable userTable = ChatSessionController.getStudents(_chatId);

            //for (int index = 0; index <= userTable.Rows.Count - 1; index++)
            //{
            //    if(students.Where(student => student.userId == int.Parse(userTable.Rows[index]["ID"].ToString())).Any())
            //    {
            //        students.Add(new ConnectedUser(
            //        int.Parse(userTable.Rows[index]["ID"].ToString()),
            //        userTable.Rows[index]["CI"].ToString(),
            //        userTable.Rows[index]["Nick_Name"].ToString(),
            //        userTable.Rows[index]["First_Name"] + " " + userTable.Rows[index]["First_Surname"],
            //        userTable.Rows[index]["Name"].ToString(),
            //        userTable.Rows[index]["Status"].ToString()
            //        ));
            //    }
            //    studentsBox.ItemsSource = students;

                Dictionary<int, ConnectedUser> studentDictionary = new Dictionary<int, ConnectedUser>();

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
                }
            studentsBox.ItemsSource = studentDictionary;
            //else if (students[index].userId == int.Parse(userTable.Rows[index]["ID"].ToString()))
            //{
            //    students[index].userNick = userTable.Rows[index]["CI"].ToString();
            //    students[index].personalName = userTable.Rows[index]["First_Name"] + " " + userTable.Rows[index]["First_Surname"];
            //    students[index].userRole = userTable.Rows[index]["Name"].ToString();
            //    students[index].status = userTable.Rows[index]["Status"].ToString();
            //}

        //}
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
