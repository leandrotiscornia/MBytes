using System;
using System.Collections.Generic;
using System.ComponentModel;
using Negocio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ConnectedUser : INotifyPropertyChanged
    {
        private int _userId;
        private string _userNick;
        private string _personalName;
        private string _userRole;
        private string _status { get; set; }
        public string statusColor { get; set; }
        public string opacity { get; set; }
        public string picture { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ConnectedUser(int userId, string userCI, string userNick, string personalName, string userRole, string status)
        {
            _userId = userId;
            _userNick = userNick;
            _personalName = personalName;
            _userRole = userRole;
            picture = PictureController.getPicturePath() + userCI + ".jpg";
            opacity = "1";
            _status = status;
            switch (status)
            {
                case "Online":
                    statusColor = "#FF208D07";
                    opacity = "1";
                    break;
                case "Offline":
                    statusColor = "#FF9EA8A7";
                    opacity = "0.5";
                    break;
                case "Invited":
                    statusColor = "#FF1FCDBD";
                    opacity = "1";
                    break;
                case "Inactive":
                    statusColor = "#FFBDCD1F";
                    opacity = "1";
                    break;
                case "Host":
                    statusColor = "#ec4c4c";
                    opacity = "1";
                    break;
                default:
                    break;
            }
        }
        
        public int userId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                OnPropertyChanged("userId");
            }
        }
        public string status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status");
            }
        }
        public string userNick
        {
            get { return _userNick; }
            set
            {
                _userNick = value;
                OnPropertyChanged("userNick");
            }
        }
        public string personalName
        {
            get { return _personalName; }
            set
            {
                _personalName = value;
                OnPropertyChanged("personalName");
            }
        }
        public string userRole
        {
            get { return _userRole; }
            set
            {
                _userRole = value;
                OnPropertyChanged("userRole");
            }
        }
        
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(userId, new PropertyChangedEventArgs(name));
        }
        public void statusCheck()
        {
            switch (_status)
            {
                case "Online":
                    statusColor = "#FF208D07";
                    opacity = "1";
                    break;
                case "Offline":
                    statusColor = "#FF9EA8A7";
                    opacity = "0.5";
                    break;
                case "Invited":
                    statusColor = "#FF1FCDBD";
                    opacity = "1";
                    break;
                case "Inactive":
                    statusColor = "#FFBDCD1F";
                    opacity = "1";
                    break;
                case "Host":
                    statusColor = "#ec4c4c";
                    opacity = "1";
                    break;
                default:
                    break;
            }
        }
    }
}
