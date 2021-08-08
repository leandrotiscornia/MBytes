using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerCourse
    {
        public static void insertCourse(string[] courseData)
        {
            ModelCourse courseToInsert = new ModelCourse();
            courseToInsert.courseName = courseData[0];
            courseToInsert.insertObject();
        }
        public static void modifyCourse(string[] courseData)
        {
            ModelCourse courseToModify = new ModelCourse();
            courseToModify.courseId = Int32.Parse(courseData[0]);
            courseToModify.courseName = courseData[1];
            courseToModify.modifyObject();
        }
        public static void listCouse(string[] courseData)
        {
            ModelCourse courseToList = new ModelCourse();
            courseToList.courseId = Int32.Parse(courseData[0]);
            courseToList.courseName = courseData[1];
            courseToList.listObjects();
        }
        public static void deleteCourse(string[] courseData)
        {
            ModelCourse courseToDelete = new ModelCourse();
            courseToDelete.courseId = Int32.Parse(courseData[0]);
            courseToDelete.deleteObject();
        }

    }
}
