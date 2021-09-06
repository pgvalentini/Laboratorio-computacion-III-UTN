using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            String servidor = "localhost";
            String bd = "tienda";
            String usuario = "root";
            String password = "password";
            String cadenaconexion = "Database=" + bd + "; Data Source=" + servidor+"; User id= " + usuario + "; Password=" + password + "";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        
    }
}
