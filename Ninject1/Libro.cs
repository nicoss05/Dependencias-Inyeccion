using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject1
{
    public class Libro
    {
        ILibrero libroIUnidad;
        public Libro(ILibrero objetoLibrero)
        {
            libroIUnidad = objetoLibrero;
        }
        public void IngresoLibro()
        {
            libroIUnidad.InstertarLibro();
        }
    }
}
