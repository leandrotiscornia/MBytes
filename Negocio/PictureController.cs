using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class PictureController
    {
        public static string getPicturePath()
        {
            return Paths.Default.PictureRoute;
        }
    }
}
