using Castle.Windsor;
using System;

namespace CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<Persona>());
            container.Register(Castle.MicroKernel.Registration.Component.For<INombre>().ImplementedBy<Nombre>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IApellido>().ImplementedBy<Apellido>());

            var persona = container.Resolve<Persona>();

            Console.WriteLine("Hola {0}!", persona.NombreCompleto());
        }
    }
}
