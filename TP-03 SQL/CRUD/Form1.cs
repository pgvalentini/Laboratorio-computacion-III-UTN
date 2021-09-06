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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = textBoxCodigo.Text;
                String nombre = textBoxNombre.Text;
                String descripcion = textBoxDescripcion.Text;
                double precioP = Double.Parse(textBoxPrecioP.Text);
                int existencia = int.Parse(textBoxExistencia.Text);

                string sql = "INSERT INTO productos (codigo,nombre,descripcion,precio_publico,existencias) values ('" + codigo + "','" + nombre + "','" + descripcion + "','" + precioP + "','" + existencia + "')";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");
                    limpiar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String codigo = textBoxCodigo.Text;
            MySqlDataReader reader = null;
            String sql = "SELECT id,codigo,nombre,descripcion,precio_publico,existencias FROM productos WHERE codigo LIKE '"+codigo+"'LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxID.Text = reader.GetString(0);                    
                        textBoxCodigo.Text = reader.GetString(1);                    
                        textBoxNombre.Text = reader.GetString(2);                    
                        textBoxDescripcion.Text = reader.GetString(3);                    
                        textBoxPrecioP.Text = reader.GetString(4);                    
                        textBoxExistencia.Text = reader.GetString(5);                    
                                    
                    }
                }else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            String id = textBoxID.Text;
            String codigo = textBoxCodigo.Text;
            String nombre = textBoxNombre.Text;
            String descripcion = textBoxDescripcion.Text;
            double precioP = Double.Parse(textBoxPrecioP.Text);
            int existencia = int.Parse(textBoxExistencia.Text);

            string sql = "UPDATE productos SET codigo='"+codigo+"', nombre='"+nombre+"', descripcion='"+descripcion+"', precio_pulico='"+precioP+"',existencias='"+existencia+"'WHERE id='"+id+"'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = textBoxID.Text;
            
            string sql = "DELETE FROM productos WHERE id='"+id+"'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBoxID.Text = "";
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecioP.Text = "";
            textBoxExistencia.Text = "";
        }
    }
}
