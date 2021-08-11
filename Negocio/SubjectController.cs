using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class SubjectController
    {
        public static void insertSubject(string[] subjectData)
        {
            ModelSubject subjectToInsert = new ModelSubject();
            subjectToInsert.subjectName = subjectData[0];
            subjectToInsert.insertObject();
        }
        public static void modifySubject(string[] subjectData)
        {
            ModelSubject subjectToModify = new ModelSubject();
            subjectToModify.subjectId = Int32.Parse(subjectData[0]);
            subjectToModify.subjectName = subjectData[1];
            subjectToModify.modifyObject();
        }
        public static void listSubject(string[] dataSubject)
        {
            ModelSubject subjectToList = new ModelSubject();
            subjectToList.subjectId = Int32.Parse(dataSubject[0]);
            subjectToList.subjectName = dataSubject[1];
            subjectToList.listObjects();
        }
        public static void deleteSubject(string[] subjectData)
        {
            ModelSubject subjectToDelete = new ModelSubject();
            subjectToDelete.subjectId = Int32.Parse(subjectData[0]);
            subjectToDelete.deleteObject();
        }


    }
}
