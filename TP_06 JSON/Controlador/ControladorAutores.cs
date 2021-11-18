using Lab3Practico4ReadWriteFiles;
using Lab3Practico6Json.Modelo;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Practico6Json.Controlador
{
    class ControladorAutores : Conexion
    {

        public List<Escritor> TraerEscritores()
        {
            List<Escritor> escritores = new List<Escritor>();

            try
            {
                MySqlDataReader reader;
                String sql = "Select * from labpract6zavi.escritor";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Escritor escritor = new Escritor();
                    escritor.Id = reader.GetInt64(0);
                    escritor.Apellido = reader.GetString(1);
                    escritor.Nombre = reader.GetString(2);
                    escritor.Dni = reader.GetInt64(3);
                    escritor.Libros = TraerLibrosDeUnEscritor(reader.GetInt64(0));
                    //Console.WriteLine("Id: " + reader.GetInt64(0));
                    escritores.Add(escritor);


                }
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


            return escritores;
        }

        public List<Libro> TraerLibros()
        {
            List<Libro> libros = new List<Libro>();

            try
            {
                MySqlDataReader reader;
                String sql = "Select * from labpract6zavi.libro";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro();
                    libro.Nombre = reader.GetString(0);
                    libro.AnioPublicacion = reader.GetInt32(1);
                    libro.Editorial = reader.GetString(2);
                    //libro.Escritor = TraerEscritor(reader.GetInt64(3));
                    
                    //Console.WriteLine("Id: " + reader.GetInt64(0));
                    libros.Add(libro);

                }
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return libros;
        }


        public Escritor TraerEscritor(long num)
        {
            Escritor escritor = new Escritor();

            try
            {
                MySqlDataReader reader;
                String sql = "Select * from labpract6zavi.escritor WHERE id='" + num + "'";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    escritor = new Escritor();
                    escritor.Id = reader.GetInt64(0);
                    escritor.Apellido = reader.GetString(1);
                    escritor.Nombre = reader.GetString(2);
                    escritor.Dni = reader.GetInt64(3);
                    //Console.WriteLine("Id: " + reader.GetInt64(0));
                    

                }
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


            return escritor;
        }


        public List<Libro> TraerLibrosDeUnEscritor(long num)
        {
            List<Libro> libros = new List<Libro>();

            try
            {
                MySqlDataReader reader;
                String sql = "Select * from labpract6zavi.libro WHERE idEscritor = '" + num + "'";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro();
                    libro.Nombre = reader.GetString(0);
                    libro.AnioPublicacion = reader.GetInt32(1);
                    libro.Editorial = reader.GetString(2);
                    //libro.Escritor = TraerEscritor(reader.GetInt64(3));

                    //Console.WriteLine("Id: " + reader.GetInt64(0));
                    libros.Add(libro);

                }
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return libros;
        }


        public void EscribirJsonFile(List<Escritor> escritores, string pathFile)
        {
            //Llamo a JsonConvert.SerializeObject y le paso lo que quiero convertir a Json 
            //(un array de clientes, y lo indento (lo estructura con tabs para que se vea ordenado
            string jsonFile = JsonConvert.SerializeObject(escritores.ToArray(), Formatting.Indented);

            //Con este método escribo a ese string en la ruta
            File.WriteAllText(pathFile, jsonFile);


        }

    }
}
