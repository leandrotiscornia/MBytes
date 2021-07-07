using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    class ControllerDeleteGroup
    {
        public void deleteGroup ( string [] groupData)
        {
            ModelGroup groupToDelete = new ModelGroup();
            groupToDelete.groupId = Int32.Parse(groupData[0]);
            groupToDelete.deleteObject();
        }
    }
}
