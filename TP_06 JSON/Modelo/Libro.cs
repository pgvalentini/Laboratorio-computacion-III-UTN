using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Practico6Json.Modelo
{
    class Libro
    {
        private string nombre;
        private int anioPublicacion;
        private string editorial;
        //private Escritor escritor;

        public string Nombre { get => nombre; set => nombre = value; }
        public int AnioPublicacion { get => anioPublicacion; set => anioPublicacion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        //internal Escritor Escritor { get => escritor; set => escritor = value; }
    }
}
