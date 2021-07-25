using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerModifyNickName
    {
         public static void modifyNickName(string nickNameData)
         {
             ModelPerson nickNameToModify = new ModelPerson();
            nickNameToModify.personId = Session.userId;
            nickNameToModify.nickName = nickNameData;
             nickNameToModify.updateNickName();
         }
         
    }

}
