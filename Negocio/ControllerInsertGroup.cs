using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class ControllerInsertGroup
    {
        public void insertGroup ( string [] groupData)
        {
            ModelGroup groupToInsert = new ModelGroup();
            groupToInsert.groupName = groupData[0];
            groupToInsert.groupGrade = groupData[1];
            groupToInsert.shift = groupData[2];
            groupToInsert.insertObject();

        }
    }
}
