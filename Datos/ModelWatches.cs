using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
  public class ModelWatches : ModelDataBaseObject
    {
        public int TeacherId { get; set; }

        public DateTime WatchDay { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
