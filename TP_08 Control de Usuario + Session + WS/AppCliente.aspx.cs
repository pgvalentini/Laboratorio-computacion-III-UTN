using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.WebServiceSoapClient servicio = new ServiceReference1.WebServiceSoapClient();
        Label2.Text = servicio.Convertir(int.Parse(TextBox1.Text));
    }
}