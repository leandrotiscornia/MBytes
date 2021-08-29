using System;
using System.Collections.Generic;
using System.ComponentModel;
using Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class chatMessage : INotifyPropertyChanged
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

        
        public int messageId
        {
            get { return _messageId; }
            set
            {
                _messageId = value;
                OnPropertyOnPropertyChanged("messageId");
            }
        }
        public int senderId
        {
            get { return _senderId; }
            set
            {
                _senderId = value;
                OnPropertyOnPropertyChanged("senderId");
            }
        }
        public string senderName
        {
            get { return _senderName; }
            set
            {
                _senderName = value;
                OnPropertyOnPropertyChanged("senderName");
            }
        }
        public DateTime time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyOnPropertyChanged("time");
            }
        }
        public string text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyOnPropertyChanged("text");
            }
        }
        public Dictionary<int, bool> readed
        {
            get { return _readed; }
            set
            {
                _readed = value;
                OnPropertyOnPropertyChanged("readed");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyOnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public chatMessage(int messageId, DateTime time, string text, string senderName, int senderId, int colorGenerator)
        {
            _senderName = senderName;
            _messageId = messageId;
            _time = time;
            _text = text;
            corner = "15 15 15 0";
            align = "left";
            pictureAlign = "10 -34 140 34";
            if (senderId == Session.userId)
            {
                color = "#FF1D8CD8";
                corner = "15 15 0 15";
                align = "right";
                pictureAlign = "140 -34 10 34";
            }
            else if(senderId * colorGenerator % 10 == 0)
                color = "#FFD43D3D";
            else if (senderId * colorGenerator % 10 == 1)
                color = "#FFE87B20";
            else if (senderId * colorGenerator % 10 == 2)
                color = "#FF9935D3";
            else if (senderId * colorGenerator % 10 == 3)
                color = "#FF1CB095";
            else if (senderId * colorGenerator % 10 == 4)
                color = "#FF1D8912";
            else if (senderId * colorGenerator % 10 == 5)
                color = "#FF5D320F";
            else if (senderId * colorGenerator % 10 == 6)
                color = "#FFA5AA3B";
            else if (senderId * colorGenerator % 10 == 7)
                color = "#FFD43D3D";
            else if (senderId * colorGenerator % 10 == 8)
                color = "#FF0CBFBF";
            else if (senderId * colorGenerator % 10 == 9)
                color = "#FF596768";
        }
    }
}