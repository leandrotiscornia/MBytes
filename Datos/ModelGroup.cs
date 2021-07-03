using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelGroup : ModelDataBaseObject

    {
        private int _groupId;
        private string _groupName;
        private string _groupGrade;
        private string _shift;

        public int groupId
        {
            get { return _groupId; }
            set { _groupId = value; }

        }
        public string groupName
        {
            get { return _groupName; }
            set { _groupName = value; }

        }

        public string groupGrade
        {
            get { return _groupGrade; }
            set { _groupGrade = value; }

        }

        public string shift
        {
            get { return _shift; }
            set { _shift = value; }

        }
    }
}
