using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerListCourse
    {
        public void listCouse(string [] courseData)
        {
            ModelCourse courseToList = new ModelCourse();
            courseToList.courseId = Int32.Parse(courseData[0]);
            courseToList.courseName = courseData[1];
            courseToList.listObjects();
        }
    }
}
