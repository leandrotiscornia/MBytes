using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class ControllerCheckExistence
    {
        public static string checkExistence(string tableName, string objectKey, string objectKeyValue)
        {
            string result;
            ModelDataBaseObject objectToCheck = new ModelDataBaseObject();
            objectToCheck.objectKey = objectKey;
            objectToCheck.tableName = tableName;
            objectToCheck.objectKeyValue = objectKeyValue;
            result = objectToCheck.checkObjectExistence();
            return result;
        }

    }
}
