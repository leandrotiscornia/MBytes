using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ModelSubject : ModelDataBaseObject
    {
        private int _subjectId;
        private string _subjectName;


        public int subjectId
        {
            get { return _subjectId; }
            set { _subjectId = value; }

        }

        public string subjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }
    }

}

