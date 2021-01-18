using Autocaf1.IRepositorio;
using Autocaf1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocaf1.Repositorio
{
    public class EstudianteRepositorio: IEstudianteRepositorio
    {
        public void Print(Estudiante oEstudiante)
        {
            Console.WriteLine("Estudiante Informacion:");
            Console.WriteLine(string.Format("Id:{0}",oEstudiante.Id));
            Console.WriteLine(string.Format("Nombre:{0}", oEstudiante.Nombre));

        }
    }
}
