using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_Dinamica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dato = textBoxBuscar.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {
            List<Productos> productos = new List<Productos>();
            Controlador_Producto controladorProducto = new Controlador_Producto();
            dataProductos.DataSource = controladorProducto.consulta(dato);
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Productos productos = new Productos();
            productos.Codigo = textBoxCodigo.Text;
            productos.Nombre = textBoxNombre.Text;
            productos.Descripcion = textBoxDescrip.Text;
            productos.Precio_publico = double.Parse(textBoxPrecio.Text);
            productos.Existencias = int.Parse(textBoxExistencias.Text);

            Controlador_Producto controlador_Producto = new Controlador_Producto();

            if (textBoxID.Text != "")
            {
                productos.Id = int.Parse(textBoxID.Text);
                bandera = controlador_Producto.actualizar(productos);
            }
            else
            {
                bandera = controlador_Producto.insertar(productos); 
            }
            if (bandera)
            {
                MessageBox.Show("Guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDescrip.Text = "";
            textBoxPrecio.Text = "";
            textBoxExistencias.Text = "";
            textBoxID.Text = "";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataProductos.CurrentRow.Cells[0].Value.ToString();
            textBoxNombre.Text = dataProductos.CurrentRow.Cells[1].Value.ToString();
            textBoxDescrip.Text = dataProductos.CurrentRow.Cells[2].Value.ToString();
            textBoxPrecio.Text = dataProductos.CurrentRow.Cells[3].Value.ToString();
            textBoxExistencias.Text = dataProductos.CurrentRow.Cells[4].Value.ToString();
            textBoxCodigo.Text = dataProductos.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro quiere eliminar?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result==DialogResult.Yes)
            {
                int id = int.Parse(dataProductos.CurrentRow.Cells[0].Value.ToString());
                Controlador_Producto control = new Controlador_Producto();
                control.eliminar(id);
            }
        }
    }
}
