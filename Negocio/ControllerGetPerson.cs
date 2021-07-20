using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public static class ControllerGetPerson
    {
        public static string getPersonNick(int personId)
        {
            string nickName;
            ModelPerson person = new ModelPerson();
            person.personId = personId;
            nickName = person.getPersonNick();
            if (nickName != null)
                return nickName;
            else
                nickName = person.getPersonName();
            return nickName;
        }
        public static DataTable getPersonData(int personId)
        {
            DataTable personData = new DataTable();

            //TODO: get all the data from a specific person

            return personData;
        }
        



    }
}
