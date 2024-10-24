using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U1_Tarea_1___AochengYe.dao;
using U1_Tarea_1___AochengYe.dto;

namespace U1_Tarea_1___AochengYe
{
    public partial class FrmAnnadir : Form
    {
        public FrmAnnadir()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            if (txtBoxTitulo.Text.Length < 1)
            {
                MessageBox.Show("Se ha producido un error.\nLos campos título y autor son obligatorios.");
                txtBoxTitulo.BackColor = Color.Red;
                datosValidos = false;
            }
            if (txtBoxAutor.Text.Length < 1)
            {
                MessageBox.Show("Se ha producido un error.\nLos campos título y autor son obligatorios.");
                txtBoxAutor.BackColor = Color.Red;
                datosValidos = false;
            }
            DateTime fechaPublicacion;
            bool fechaValida = DateTime.TryParse(txtBoxFchaPublicacion.Text, out fechaPublicacion);
            if (!fechaValida)
            {
                MessageBox.Show("Formato de fecha incorrecto. Por favor, ingrese una fecha válida.");
                txtBoxFchaPublicacion.BackColor = Color.Red;
                datosValidos = false;
            }
            if (datosValidos)
            {
                Libro nuevoLibro = new Libro(
                    txtBoxTitulo.Text,
                    txtBoxAutor.Text,
                    txtBoxEditorial.Text,
                    fechaPublicacion,
                    txtBoxImagen.Text,
                    txtBoxDescripcion.Text,
                    float.Parse(txtBoxPrecio.Text),
                    int.Parse(txtBoxUnidades.Text),
                    checkBoxEnVenta.Checked
                );
                DaoLibro daoLibro = new DaoLibro();
                daoLibro.insertarLibro(nuevoLibro);
                MessageBox.Show("Libro añadido correctamente.");
            }
        }


        private void txtBoxAutor_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxAutor.BackColor = Color.White;
        }

        private void txtBoxTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxTitulo.BackColor = Color.White;
        }

        private void txtBoxFchaPublicacion_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxFchaPublicacion.BackColor = Color.White;
        }
    }
}

