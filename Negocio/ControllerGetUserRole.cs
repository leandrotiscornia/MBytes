using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class ControllerGetUserRole
    {
        public int getUserId(string userName)
        {
            int userId;
            ModelPerson user = new ModelPerson();
            userId = user.getUserId(userName);
            return userId;
        }
        public string getUserRole(int userId)
        {
            string userRole;
            ModelPerson user = new ModelPerson();
            user.personId = userId;
            userRole = user.getUserRole();
            return userRole;
        }


    }
}
