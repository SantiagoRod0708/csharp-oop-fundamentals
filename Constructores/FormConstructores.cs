using System;
using System.Windows.Forms;

namespace Constructores
{
    public partial class FormConstructores : Form
    {
        public FormConstructores()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            int precio = int.Parse(txtPrecio.Text);
            string descripcion = txtDescripcion.Text;
            int clave = int.Parse(txtClave.Text);

            
            Producto nuevoProducto = new Producto(nombre, precio, descripcion, clave);

            
            MessageBox.Show($"¡Producto Creado!\nClave: {nuevoProducto.Clave}\nNombre: {nuevoProducto.Nombre}\nPrecio: ${nuevoProducto.Precio}", 
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
