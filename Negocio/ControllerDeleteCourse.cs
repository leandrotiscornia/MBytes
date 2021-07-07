using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerDeleteCourse
    {
        public void deleteCourse(string [] courseData)
        {
            ModelCourse courseToDelete = new ModelCourse();
            courseToDelete.courseId = Int32.Parse(courseData[0]);
            courseToDelete.deleteObject();
        }
    }
}
