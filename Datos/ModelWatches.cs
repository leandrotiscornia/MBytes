using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelWatches : ModelDataBaseObject
    {
        private int _teacherId;
        private DateTime _watchDay;
        private DateTime _startTime;
        private DateTime _endTime;
        
        public int TeacherId
        {
            get { return _teacherId; }
            set { _teacherId = value; }
        }

        public DateTime WatchDay
        {
            get { return _watchDay; }
            set { _watchDay = value; }
        } 

        public DateTime StarTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

    }
}
