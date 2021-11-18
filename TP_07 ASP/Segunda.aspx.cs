using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Segunda : System.Web.UI.Page
{
    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        if (!ValidPass()) return;
        if (pass.Text != repitePass.Text) return;
        if (!aceptarCondiciones.Checked) return;

        string sql = "INSERT INTO Usuario " +
            "(Nombre, Apellido, NombreUsuario, Password, FechaNac, Sexo, Telefono, Ubicacion) VALUES (" +
            "'" + nombre.Text + "', " +
            "'" + apellido.Text + "', " +
            "'" + nombreUsuario.Text + "', " +
            "'" + pass.Text + "', " +
            "'" + diaNac.Text+"-"+mesNac.SelectedValue.ToString()+"-"+anioNac.Text + "', " +
            "'" + sexo.Text + "', " +
            "'" + tel.Text + "', " +
            "'" + ubicacion + "')";

        try
        {
            MySqlConnection conexionDB = ConexionDB();
            conexionDB.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionDB);
            comando.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }     
    }

    public MySqlConnection ConexionDB()
    {
        string servidor = "localhost";
        string db = "lab3pract7zavi";
        string usuario = "root";
        string password = "root";

        string cadenaConexion = "Database=" + db +
                                "; Data Source=" + servidor +
                                //"; Port=" + puerto +
                                "; User Id= " + usuario +
                                "; Password=" + password + "";

        try
        {
            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);

            return conexionDb;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return null;
        }
    }

    public bool ValidEmailAddress(string emailAddress, out string errorMessage)
    {
        if (emailAddress.Length == 0)
        {
            errorMessage = "email address is required.";
            return false;
        }

        if (emailAddress.IndexOf("@") > -1)
        {
            if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
            {
                errorMessage = "";
                return true;
            }
        }

        errorMessage = "El email tiene que estar en un formato válido.\n" +
           "Por ejemplo 'nombre@servidor.com' ";
        return false;
    }

    public bool ValidPass()
    {
        if (pass.Text.Length == 0)
        {
            return false;
        }

        if (pass.Text.Contains("!")||
            pass.Text.Contains("@") ||
            pass.Text.Contains("#") ||
            pass.Text.Contains("$") ||
            pass.Text.Contains("%") ||
            pass.Text.Contains("^") ||
            pass.Text.Contains("&") ||
            pass.Text.Contains("*") ||
            pass.Text.Contains("+") ||
            pass.Text.Contains(";") ||
            pass.Text.Contains(":"))
        {
            return true;
        }
        return false;
    }
}