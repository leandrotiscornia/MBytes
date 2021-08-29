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
        private string _senderName;
        private DateTime _time;
        private string _text;
        private Dictionary<int, bool> _readed;
        private string _color;
        private string _corner;

        public int messageId
        {
            get { return _messageId; }
            set
            {
                _messageId = value;
                OnPropertyOnPropertyChanged("messageId");
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

        public chatMessage(int messageId, DateTime time, string text, string senderName)
        {
            _senderName = senderName;
            _messageId = messageId;
            _time = time;
            _text = text;
            if (messageId == Session.userId)
            {
                _color = "";
                _corner = "";
            }
        }
    }
}