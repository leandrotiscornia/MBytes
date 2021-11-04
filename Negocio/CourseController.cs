using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class CourseController
    {
        public static void insertCourse(string courseName, int numberOfGrades)
        {
            ModelCourse courseToInsert = new ModelCourse();
            courseToInsert.courseName = courseName;
            courseToInsert.numberOfGrades = numberOfGrades;
            courseToInsert.insertCourse();
        }
        public static void modifyCourse(int courseId, string courseName, int numberOfGrades, string oldCourseName)
        {
            ModelCourse courseToModify = new ModelCourse();
            courseToModify.courseId = courseId;
            courseToModify.courseName = courseName;
            courseToModify.numberOfGrades = numberOfGrades;
            courseToModify.modifyCourse(oldCourseName);
        }
        public static DataTable listCourses()
        {
            ModelCourse courseToList = new ModelCourse();
            return courseToList.listCourses();
        }
        public static void deleteCourse(int courseId)
        {
            ModelCourse courseToDelete = new ModelCourse();
            courseToDelete.courseId = courseId;
            courseToDelete.deleteCourse();
        }
        public static string[] getCourseInfo(int courseId)
        {
            ModelCourse courseToConsult = new ModelCourse();
            courseToConsult.courseId = courseId;
            return courseToConsult.getCourse();
        }
    }
}
