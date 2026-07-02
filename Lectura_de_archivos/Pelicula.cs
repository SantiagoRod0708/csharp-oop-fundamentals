using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_de_archivos
{
    internal class Pelicula : Medio
    {
        private int calificacion;
        private bool puedeEditar;
        public Pelicula(string nombre, int año, string genero, int calificacion, bool puedeEditar) 
            : base(nombre, genero, año)
        {
            this.calificacion = calificacion;
            this.puedeEditar = puedeEditar;
        }

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public bool PuedeEditar { get => puedeEditar; set => puedeEditar = value; }

        public override string ToString() 
        {
            return "La pelicula " + nombre + " ha sido editada.";
        }
        
    }
}
