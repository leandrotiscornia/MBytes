using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerInsertCourse
    {
        public void insertCourse( string [] courseData)
        {
            ModelCourse courseToInsert = new ModelCourse();
            courseToInsert.courseName = courseData[0];
            courseToInsert.insertObject();
        }
    }
}
