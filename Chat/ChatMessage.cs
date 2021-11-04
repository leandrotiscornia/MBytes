using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Runtime.CompilerServices;

using Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatMessage : INotifyPropertyChanged
    {
        private int _messageId;
        private int _senderId;
        private string _senderName;
        private DateTime _time;
        private string _text;
        private Dictionary<int, bool> _readed;
        public string color { get; set; }
        public string corner { get; set; }
        public string align { get; set; }
        public string pictureAlign { get; set; }
        public string timeAlign { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public string picture { get; set; }
        public ChatMessage(int messageId, DateTime time, string text, string senderName, int senderId, int sessionId, string senderCI)
        {
            _senderName = senderName;
            _messageId = messageId;
            _time = time;
            _text = text;
            corner = "15 15 15 0";
            align = "left";
            pictureAlign = "10 -40 140 34";
            timeAlign = "0,0,0,-16";
            picture = PictureController.getPicturePath() + senderCI + ".jpg"; 
            if (senderId == Session.userId)
            {
                color = "#FF1D8CD8";
                corner = "15 15 0 15";
                align = "right";
                timeAlign = "0,0,74,-16";
                pictureAlign = "140 -40 10 34";
            }
            else if (senderId * sessionId % 10 == 0)
                color = "#FFD43D3D";
            else if (senderId * sessionId % 10 == 1)
                color = "#FFE87B20";
            else if (senderId * sessionId % 10 == 2)
                color = "#FF9935D3";
            else if (senderId * sessionId % 10 == 3)
                color = "#FF1CB095";
            else if (senderId * sessionId % 10 == 4)
                color = "#FF1D8912";
            else if (senderId * sessionId % 10 == 5)
                color = "#FF5D320F";
            else if (senderId * sessionId % 10 == 6)
                color = "#FFA5AA3B";
            else if (senderId * sessionId % 10 == 7)
                color = "#FFD43D3D";
            else if (senderId * sessionId % 10 == 8)
                color = "#FF0CBFBF";
            else if (senderId * sessionId % 10 == 9)
                color = "#FF596768";
        }

        public int messageId
        {
            get { return _messageId; }
            set
            {
                _messageId = value;
                OnPropertyChanged("messageId");
            }
        }
        public int senderId
        {
            get { return _senderId; }
            set
            {
                _senderId = value;
                OnPropertyChanged("senderId");
            }
        }
        public string senderName
        {
            get { return _senderName; }
            set
            {
                _senderName = value;
                OnPropertyChanged("senderName");
            }
        }
        public DateTime time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged("time");
            }
        }
        public string text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("text");
            }
        }
        public Dictionary<int, bool> readed
        {
            get { return _readed; }
            set
            {
                _readed = value;
                OnPropertyChanged("readed");
            }
        }

       

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged?.Invoke(messageId, new PropertyChangedEventArgs(name));
        }

        
    }
}