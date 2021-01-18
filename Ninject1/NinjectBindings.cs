using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject1
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ILibrero>().To<Libreria>();
        }
    }
}
