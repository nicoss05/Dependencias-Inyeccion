using System;
using System.Collections.Generic;
using System.Text;

namespace StructureMap
{
    internal class Contenedor
    {
        internal static IContainer InitContainer()
        {
            var container = new Container(c => c.For<IMensaje>().Use<Mensaje2>());
            return container;
        }
    }
}
