using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class PeliculaActor
    {
        Pelicula pelicula;
        Actor actor;

        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
