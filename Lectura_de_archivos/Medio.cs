using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_de_archivos
{
    internal class Medio
    {
        public string nombre, genero;
        public int año;

        public Medio(string nombre, string genero, int año)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
        }
    }
}
