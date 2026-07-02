using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_de_archivos
{
    public partial class Form1 : Form
    {
        List<Pelicula>pelicula = new List<Pelicula>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("peliculas.txt");
            while (!reader.EndOfStream) 
            {
                string[] linea = reader.ReadLine().Split('|');
                Pelicula p = new Pelicula(linea[0],
                int.Parse(linea[1]),
                linea[2],
                int.Parse(linea[3]),
                bool.Parse(linea[4]) );
                pelicula.Add(p);
                cmbPelicula.Items.Add(linea[0]);
            }
            reader.Close();
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            string peliculaSeleccionada = cmbPelicula.Text;
            foreach(var p in pelicula) 
            {
                if(p.nombre == peliculaSeleccionada) 
                {
                    textAño.Text = ""+ p.año;
                    textGenero.Text = p.genero;
                    cmbCali.Text = "" + p.Calificacion;

                    if (p.PuedeEditar)
                    {
                        textAño.Enabled = true;
                        textGenero.Enabled = true;
                        cmbCali.Enabled = true;
                    }
                    else
                    {
                        textAño.Enabled = false;
                        textGenero.Enabled = false;
                        cmbCali.Enabled = false;
                    }

                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string peliculaSeleccionada = cmbPelicula.Text;
            foreach (var p in pelicula)
            { 
                if (p.nombre == peliculaSeleccionada)
                {
                    MessageBox.Show(p.ToString());
                    p.año = int.Parse(textAño.Text);
                    p.genero=textGenero.Text;
                    p.Calificacion = int.Parse(cmbCali.Text);
                }
            }
            StreamWriter writer = new StreamWriter("peliculas.txt");
            foreach (var p in pelicula) 
            {
                writer.WriteLine(p.nombre + "|" + p.año + "|" + p.genero + "|" + p.Calificacion + "|" + p.PuedeEditar);          
            }
            writer.Close();

        }
    }
}
