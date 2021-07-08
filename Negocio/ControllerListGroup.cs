using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ControllerListGroup
    {
        public void listGroup ( string [] groupData)
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
