using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class estudios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        Session["NivelEstudio"] = NivelEstudio.Text;
        Session["Titulo"] = Titulo.Text;
        Session["Establecimiento"] = Establecimiento.Text;
        Response.Redirect("trabajos.aspx");
    }
}