using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class ControllerModifyGroup
    {
        public void modifyGroup (string [] groupData)
        {
            ModelGroup groupToModify = new ModelGroup();
            groupToModify.groupId = Int32.Parse(groupData[0]);
            groupToModify.groupName = groupData[1];
            groupToModify.groupGrade = groupData[2];
            groupToModify.shift = groupData[3];
            groupToModify.modifyObject();
        }
    }
}
