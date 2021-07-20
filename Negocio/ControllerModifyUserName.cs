using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
     public static class ControllerModifyUserName
     {
        public static void modifyUserName(string userNameData , int userIDData)
        {
            ModelPerson userNameToModify = new ModelPerson();
            userNameToModify.updateUserName(userNameData,userIDData);
            
        }
            
     }
}
