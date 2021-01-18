using Autocaf1.IRepositorio;
using Autocaf1.Model;
using Autocaf1.Modulo;
using Autofac;
using System;
using System.ComponentModel;
using IContainer = Autofac.IContainer;

namespace Autocaf1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante oEstudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Monica"
            };
            Profesor oProfesor = new Profesor
            {
                Id = 1,
                Nombre = "Gorky"
            };
            var container = BuildContainer();

            var EstudianteRepositorio = container.Resolve<IEstudianteRepositorio>();
            EstudianteRepositorio.Print(oEstudiante);

            var ProfesorRepositorio = container.Resolve<IProfesorRepositorio>();
            ProfesorRepositorio.Print(oProfesor);

            Console.ReadLine();
        }
        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<EstudianteModulo>();
            builder.RegisterModule<ProfesorModulo>();
            return builder.Build();


        }
    }
}
