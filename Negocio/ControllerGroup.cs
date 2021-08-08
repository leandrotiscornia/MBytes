using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerGroup
    {
        public static void insertGroup(string[] groupData)
        {
            ModelGroup groupToInsert = new ModelGroup();
            groupToInsert.groupName = groupData[0];
            groupToInsert.groupGrade = groupData[1];
            groupToInsert.shift = groupData[2];
            groupToInsert.insertObject();
        }
        public static void modifyGroup(string[] groupData)
        {
            ModelGroup groupToModify = new ModelGroup();
            groupToModify.groupId = Int32.Parse(groupData[0]);
            groupToModify.groupName = groupData[1];
            groupToModify.groupGrade = groupData[2];
            groupToModify.shift = groupData[3];
            groupToModify.modifyObject();
        }
        public static void deleteGroup(string[] groupData)
        {
            ModelGroup groupToDelete = new ModelGroup();
            groupToDelete.groupId = Int32.Parse(groupData[0]);
            groupToDelete.deleteObject();
        }
        public static void listGroup(string[] groupData)
        {
            ModelGroup groupToList = new ModelGroup();
            groupToList.groupId = Int32.Parse(groupData[0]);
            groupToList.groupName = groupData[1];
            groupToList.groupGrade = groupData[2];
            groupToList.shift = groupData[3];
            groupToList.listObjects();
        }

    }
}
