using System;
using System.Windows.Forms;

namespace Herencia
{
    public partial class FormHerencia : Form
    {
        public FormHerencia()
        {
            InitializeComponent();
        }

        private void btnRegistrarCoche_Click(object sender, EventArgs e)
        {
            
            Coche miCoche = new Coche
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Año = int.Parse(txtAño.Text),
                Color = txtColor.Text,
                NumPuerta = int.Parse(txtPuertas.Text)
            };

            
            string informacionCompleta = miCoche.MostrarInformacion();

            
            txtResultado.Text = informacionCompleta;
        }
    }
}
