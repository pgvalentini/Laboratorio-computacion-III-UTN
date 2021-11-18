using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Primera : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        Label13.Text = "Datos";
        Label14.Text = "Caja de texto: " + txt1.Text;
        Label15.Text = "Combo: " + combo.SelectedValue;
        Label16.Text = "Imagen: " + imagen.ImageUrl;
        Label17.Text = "CheckBox: " + checkBox.SelectedValue;
        Label18.Text = "Hipervinculo: " + link.Text;
        Label19.Text = "Radio Button: " + radio.SelectedValue;
        Label20.Text = "Campo oculto: " + oculto.Value;
    }
}