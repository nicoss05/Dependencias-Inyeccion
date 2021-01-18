using StructureMap;


namespace StructureMap
{
    internal class Contenedor
    {
    internal static IContainer IntContainer()
        {
            var container = new Container(c => c.For<IMensaje>().Use<Mensaje1>());
            return container;
        }
        
    }
}
