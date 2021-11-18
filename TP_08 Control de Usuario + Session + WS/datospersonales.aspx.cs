using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class datospersonales : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        Session["Nombre"] = Nombre.Text;
        Session["Apellido"] = Apellido.Text;
        Session["DNI"] = DNI.Text;
        Session["Domicilio"] = Domicilio.Text;
        Session["Nacionalidad"] = Nacionalidad.Text;
        Session["Sexo"] = Sexo.Text;
        Session["FechaNacimiento"] = FechaNacimiento.Text;
        Response.Redirect("estudios.aspx");
    }
}