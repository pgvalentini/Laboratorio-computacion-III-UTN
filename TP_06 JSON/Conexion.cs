
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Practico4ReadWriteFiles
{
    class Conexion
    {
        public MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "labpract6zavi";
            string usuario = "root";
            string password = "root";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + 
                servidor + "; User Id= " + usuario + "; Password=" + 
                password+"";

            try
            {
                MySqlConnection ConexionBD = new MySqlConnection(cadenaConexion);
                
                return ConexionBD;
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return null;
            }
        }
    }
}
