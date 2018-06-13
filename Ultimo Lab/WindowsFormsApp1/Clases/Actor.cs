using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    [Serializable]
    public class Actor : Persona
    {
        public Actor(string nombre, string apellido, string fechaNac, string biografia) : base(nombre, apellido, fechaNac, biografia)
        {
        }

        /*
        public override string AgregarLista()
        {
             return "";
        }
        */
    }
}
