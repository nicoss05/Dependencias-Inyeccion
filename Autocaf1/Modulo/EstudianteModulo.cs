using Autocaf1.IRepositorio;
using Autocaf1.Repositorio;
using Autofac;

namespace Autocaf1.Modulo
{
   public class EstudianteModulo :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EstudianteRepositorio>().As<IEstudianteRepositorio>();
            base.Load(builder);
        }
    }
}
