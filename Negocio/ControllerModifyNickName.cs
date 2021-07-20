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
         public static void modifyNickName(string nickNameData, string ciData)
         {
             ModelPerson nickNameToModify = new ModelPerson();
             nickNameData = nickNameToModify.nickName; 
             ciData = nickNameToModify.ci;
             nickNameToModify.updateNickName(nickNameData,ciData);
         }
         
    }

}
