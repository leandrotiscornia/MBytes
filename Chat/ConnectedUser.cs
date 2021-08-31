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
        public string status { get; set; }
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
            picture = PictureController.getPicturePath() + userCI;
            opacity = "1";
            this.status = status;
            switch (status)
            {
                case "Online":
                    statusColor = "#FF208D07";
                    break;
                case "Offline":
                    statusColor = "#FF9EA8A7";
                    opacity = "0.5";
                    break;
                case "Invited":
                    statusColor = "#FF1FCDBD";
                    break;
                case "Inactive":
                    statusColor = "#FFBDCD1F";
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
