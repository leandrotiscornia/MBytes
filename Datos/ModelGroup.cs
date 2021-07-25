using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class ModelGroup : ModelDataBaseObject

    {
        public int groupId { get; set; }
        public string groupName { get; set; }

        public string groupGrade { get; set; }

        public string shift { get; set; }
    }
}
