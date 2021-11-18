using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class resumen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Nombre: " + Session["Nombre"].ToString();
        Label2.Text = "Apellido: " + Session["Apellido"].ToString();
        Label3.Text = "DNI: " + Session["DNI"].ToString();
        Label4.Text = "Domicilio: " + Session["Domicilio"].ToString();
        Label5.Text = "Nacionalidad: " + Session["Nacionalidad"].ToString();
        Label6.Text = "Sexo: " + Session["Sexo"].ToString();
        Label7.Text = "Fecha Nacimiento: " + Session["FechaNacimiento"].ToString();
        Label8.Text = "Nivel Estudio: " + Session["NivelEstudio"].ToString();
        Label9.Text = "Titulo: " + Session["Titulo"].ToString();
        Label10.Text = "Establecimiento: " + Session["Establecimiento"].ToString();
        Label11.Text = "Periodo de Ocupacion: " + Session["PeriodoOcupacion"].ToString();
        Label12.Text = "Lugar de Trabajo: " + Session["LugarTrabajo"].ToString();
        Label13.Text = "Tarea Desempeñada: " + Session["TareaDesempeniada"].ToString();
        Label14.Text = "Idioma: " + Session["Idioma"].ToString();
        Label15.Text = "Nivel de Conocimiento: " + Session["NivelConocimiento"].ToString();
    }
}