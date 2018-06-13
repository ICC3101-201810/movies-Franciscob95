using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1.Clases
{
    public static class Controller
    {
        private static List<Director> directores;
        private static List<Actor> actores;
        private static List<Productor> productores;
        private static List<Pelicula> peliculas;
        private static List<Estudio> estudios;
        private static int decicion; // 0 = pelicula, 1 = actor, 2 = director, 3 = productor y 4 = estudio

        public static void Init()
        {
            directores = new List<Director>();
            actores = new List<Actor>();
            productores = new List<Productor>();
            peliculas = new List<Pelicula>();
            estudios = new List<Estudio>();
            Deserializar();
        }

        public static void AgregarActor(Actor a)
        {
            actores.Add(a);
        }

        public static void AgregarDirector(Director d)
        {
            directores.Add(d);
        }

        public static void AgregarProductor(Productor p)
        {
            productores.Add(p);
        }

        public static void AgregarPelicula(Pelicula p)
        {
            peliculas.Add(p);
        }

        public static void AgregarEstudio(Estudio e)
        {
            estudios.Add(e);
        }

        public static List<Actor> ReturnActores()
        {
            return actores;
        }

        public static List<Director> ReturnDirector()
        {
            return directores;
        }

        public static List<Productor> ReturnProductores()
        {
            return productores;
        }

        public static List<Pelicula> ReturnPeliculas()
        {
            return peliculas;
        }

        public static List<Estudio> ReturnEstudioS()
        {
            return estudios;
        }

        public static int ReturnDecicion(int i)
        {
            decicion = i;
            return decicion;
        }

        public static int ReturnDecicion2()
        {
            return decicion;
        }

        public static Estudio ReturnEstudio(string nom)
        {
            foreach (Estudio e in estudios)
            {
                if (nom == e.nombre)
                {
                    return e;
                }
            }
            return null;
        }

        public static void Serializar()
        {
            BinaryFormatter serializador = new BinaryFormatter();
            Stream miStream = new FileStream("Directores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador.Serialize(miStream, directores);
            miStream.Close();

            BinaryFormatter serializador2 = new BinaryFormatter();
            Stream miStream2 = new FileStream("Actores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador2.Serialize(miStream2, actores);
            miStream2.Close();

            BinaryFormatter serializador3 = new BinaryFormatter();
            Stream miStream3 = new FileStream("Productores.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador3.Serialize(miStream3, productores);
            miStream3.Close();

            BinaryFormatter serializador4 = new BinaryFormatter();
            Stream miStream4 = new FileStream("Peliculas.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador4.Serialize(miStream4, peliculas);
            miStream4.Close();

            BinaryFormatter serializador5 = new BinaryFormatter();
            Stream miStream5 = new FileStream("Estudios.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            serializador5.Serialize(miStream5, estudios);
            miStream5.Close();
        }

        public static void Deserializar()
        {
            if (File.Exists("Directores.txt"))
            {
                BinaryFormatter serializador = new BinaryFormatter();
                Stream miStream = new FileStream("Directores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                directores = (List<Director>)serializador.Deserialize(miStream);
                miStream.Close();
            }
            if (File.Exists("Actore.txt"))
            {
                BinaryFormatter serializador2 = new BinaryFormatter();
                Stream miStream2 = new FileStream("Actores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                actores = (List<Actor>)serializador2.Deserialize(miStream2);
                miStream2.Close();
            }
            if (File.Exists("Productore.txt"))
            {
                BinaryFormatter serializador3 = new BinaryFormatter();
                Stream miStream3 = new FileStream("Productores.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                productores = (List<Productor>)serializador3.Deserialize(miStream3);
                miStream3.Close();
            }
            if (File.Exists("Peliculas.txt"))
            {
                BinaryFormatter serializador4 = new BinaryFormatter();
                Stream miStream4 = new FileStream("Peliculas.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                peliculas = (List<Pelicula>)serializador4.Deserialize(miStream4);
                miStream4.Close();
            }
            if (File.Exists("Estudios.txt"))
            {
                BinaryFormatter serializador5 = new BinaryFormatter();
                Stream miStream5 = new FileStream("Estudios.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                estudios = (List<Estudio>)serializador5.Deserialize(miStream5);
                miStream5.Close();
            }
        }
    }
}
