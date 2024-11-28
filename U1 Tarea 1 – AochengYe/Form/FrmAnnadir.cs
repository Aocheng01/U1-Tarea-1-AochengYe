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
            if (string.IsNullOrEmpty(txtBoxTitulo.Text) || string.IsNullOrEmpty(txtBoxAutor.Text) || string.IsNullOrEmpty(txtBoxPrecio.Text) || string.IsNullOrEmpty(txtBoxUnidades.Text))
            {
                MessageBox.Show("Se ha producido un error.\nLos campos título, autor, precio y unidades son obligatorios.");
                txtBoxTitulo.BackColor = Color.Red;
                datosValidos = false;
            }
            if (string.IsNullOrEmpty(txtBoxAutor.Text))
            {
                txtBoxAutor.BackColor = Color.Red;
            }
            if (string.IsNullOrEmpty(txtBoxPrecio.Text))
            {
                txtBoxPrecio.BackColor = Color.Red;
            }
            if (string.IsNullOrEmpty(txtBoxUnidades.Text))
            {
                txtBoxUnidades.BackColor = Color.Red;
            }



            if (datosValidos)
            {
                Libro nuevoLibro = new Libro(
                    txtBoxTitulo.Text,
                    txtBoxAutor.Text,
                    txtBoxEditorial.Text,
                    fechaPublicacionPicker.Value,
                    txtBoxImagen.Text,
                    txtBoxDescripcion.Text,
                    float.Parse(txtBoxPrecio.Text),
                    int.Parse(txtBoxUnidades.Text),
                    checkBoxEnVenta.Checked
                );
                DaoLibro daoLibro = new DaoLibro();
                daoLibro.insertarLibro(nuevoLibro);

                //despues de insertar libro, limpiar todos los textbox
                txtBoxTitulo.Clear();
                txtBoxAutor.Clear();
                txtBoxPrecio.Clear();
                txtBoxUnidades.Clear();
                txtBoxImagen.Clear();
                txtBoxDescripcion.Clear();
                txtBoxEditorial.Clear();
                checkBoxEnVenta.CheckState = CheckState.Unchecked;
                fechaPublicacionPicker.Value = DateTime.Now;



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

        private void FrmAnnadir_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBoxPrecio_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxPrecio.BackColor = Color.White;
        }

        private void txtBoxUnidades_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxUnidades.BackColor = Color.White;
        }
    }
}

