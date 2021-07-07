using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerModifyCourse
    {
        public void modifyCourse(string[] courseData) {
            ModelCourse courseToModify = new ModelCourse();
            courseToModify.courseId = Int32.Parse(courseData[0]);
            courseToModify.courseName = courseData[1];
            courseToModify.modifyObject();
        }
    }
}
