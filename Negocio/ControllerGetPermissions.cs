using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerGetPermissions
    {
        public static List<string> getFeatures()
        {
            List<string> features;
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            features = person.getFeatures();
            return features;
        }




    }
}
