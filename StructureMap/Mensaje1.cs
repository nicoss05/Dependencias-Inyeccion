using System;
using System.Collections.Generic;
using System.Text;

namespace StructureMap
{
    internal class Mensaje1 : IMensaje
    {
        public string GetMensaje()
        {
            return "Buenos días";

        }
    }
}
