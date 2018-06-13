using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    [Serializable]
    public class Pelicula
    {
        public string nombre, director, descripcion;
        public int presupuesto;
        public string fechaEstr;
        public Critica critica;

        public Pelicula(string nombre, string director, string fechaEstr, string descripcion, int presupuesto, Estudio estudio, Critica critica)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstr = fechaEstr;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.critica = critica;
        }
    }
}
