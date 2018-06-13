using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    [Serializable]
    public class Estudio
    {
        public string nombre, direccion;
        public string fechaApert;

        public Estudio(string nombre, string direccion, string fechaApert)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApert = fechaApert;
        }
    }
}
