using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Practico6Json.Modelo
{
    class Escritor
    {
        private long id;
        private string apellido;
        private string nombre;
        private long dni;
        private List<Libro> libros;

        public long Id { get => id; set => id = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public long Dni { get => dni; set => dni = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }
    }
}
