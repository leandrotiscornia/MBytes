using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerGetProfileData
    {
        public static List<string> getProfileData()
        {
            List<string> profileData = new List<string>();
            ModelPerson person = new ModelPerson();
            person.personId = Session.userId;
            person.getProfileData();
            profileData.Add(person.userName);
            profileData.Add(person.ci);
            profileData.Add(person.firstName);
            profileData.Add(person.secondName);
            profileData.Add(person.firstSurname);
            profileData.Add(person.secondSurname);
            profileData.Add(person.nickName);
            return profileData;
        }
    }
}
