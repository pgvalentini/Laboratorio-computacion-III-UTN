using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class idioma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        Session["Idioma"] = Idioma.Text;
        Session["NivelConocimiento"] = NivelConocimiento.Text;
        Response.Redirect("resumen.aspx");
    }
}