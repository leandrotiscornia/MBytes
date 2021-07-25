using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerModifyPerson
    {
        public static void modifyPerson (string [] personData)
        {
            ModelPerson personToModify = new ModelPerson();
            personToModify.personId = Int32.Parse(personData[0]);
            personToModify.ci = personData[1];
            personToModify.firstName = personData[2];
            personToModify.secondName = personData[3];
            personToModify.firstSurname = personData[4];
            personToModify.secondSurname = personData[5];
            personToModify.createObjectPersonToModify();
            personToModify.modifyObject();
        }
    }
}
