using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
   public class ModelCourse : ModelDataBaseObject 
    {
        public int courseId { get; set; }
        public String courseName { get; set; }
    }
}
