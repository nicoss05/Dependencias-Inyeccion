using Autocaf1.IRepositorio;
using Autocaf1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocaf1.Repositorio
{
   public class ProfesorRepositorio:IProfesorRepositorio
    {
        public void Print(Profesor oProfesor)
        {
            Console.WriteLine("Profesor Informacion:");
            Console.WriteLine(string.Format("Id:{0}", oProfesor.Id));
            Console.WriteLine(string.Format("Nombre:{0}", oProfesor.Nombre));

        }
    }
}
