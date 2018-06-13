using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    [Serializable]
    public abstract class Persona
    {
        public string nombre, apellido, biografia;
        public string fechaNac;
 
        public Persona(string nombre, string apellido, string fechaNac, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.biografia = biografia;
        }

        //public abstract void AgregarLista(object s);

    }
}
