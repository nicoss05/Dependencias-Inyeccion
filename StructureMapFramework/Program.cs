using StructureMap;
using System;

namespace StructureMapFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var objeto1 = Contenedor.InitContainer().GetInstance<IMensaje>();
            var mensaje = objeto1.GetMessage();
            Console.WriteLine(mensaje);
        }
    }
}
