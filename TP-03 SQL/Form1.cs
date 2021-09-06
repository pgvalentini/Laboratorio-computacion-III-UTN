using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_03_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bConectar_Click(object sender, EventArgs e)
        {
            String servidor = tBServidor.Text;
            String usuario = tBUsuario.Text;
            String puerto = tBPuerto.Text;
            String contrasena = tBContra.Text;
            String id = tBID.Text;

            String cadenaConexion = "Database=" + id + "; Data Source=" + servidor+"; Port=" + "; User Id= " + usuario + "; Password=" + contrasena;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;

            try
            {
                String consulta = "SHOW DATABASES";                 //Solo me regresa una columna                 
                MySqlCommand comando = new MySqlCommand(consulta);  //Para agregar o ejecutar nuestra consulta
                comando.Connection = conexionBD;                    //Esto es nuestro objeto de la conexión 
                conexionBD.Open();                                  //Abrir la conexión
                reader = comando.ExecuteReader();                   //Enviar nuestro query para ejecutar
                                                                    //y lo mande a nuestro DataReadear que funciona como contenedor
                while(reader.Read())
                {
                    data += reader.GetString(0) + "    ";                    //Por eso el indice es 0
                }
                MessageBox.Show(data);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: "+ex.Message);
                
            }
            finally
            {
                conexionBD.Close();
            }


        }
    }
}
