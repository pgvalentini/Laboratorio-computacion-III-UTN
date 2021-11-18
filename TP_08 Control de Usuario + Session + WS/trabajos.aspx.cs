using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class trabajos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        Session["PeriodoOcupacion"] = PeriodoOcupacion.Text;
        Session["LugarTrabajo"] = LugarTrabajo.Text;
        Session["TareaDesempeniada"] = TareaDesempeniada.Text;
        Response.Redirect("idioma.aspx");
    }
}