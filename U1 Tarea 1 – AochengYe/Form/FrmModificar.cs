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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DaoLibro daoLibro = new DaoLibro();
            

            Libro libro = daoLibro.buscarLibro(int.Parse(txtBoxID.Text));

         
            txtBoxTitulo.Text=libro.titulo;
            txtBoxPrecio.Text = libro.precio.ToString();
            txtBoxDescripcion.Text = libro.descripcion;
            txtBoxEditorial.Text = libro.editorial;
            fechaPublicacionPicker.Value = libro.fecha_publicacion;
            txtBoxImagen.Text=libro.imagen;
            txtBoxUnidades.Text = libro.unidades.ToString();
            txtBoxAutor.Text = libro.autor;
            if (libro.enventa == true) { 
            checkBoxEnVenta.Checked = true;
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DaoLibro daoLibro = new DaoLibro();
            bool enventaEstado=false;
            if (checkBoxEnVenta.Checked) { 
                enventaEstado = true;
            }
            Libro libroNuevo = new Libro(txtBoxTitulo.Text, txtBoxAutor.Text, txtBoxEditorial.Text, fechaPublicacionPicker.Value,txtBoxImagen.Text,txtBoxDescripcion.Text,float.Parse(txtBoxPrecio.Text),int.Parse(txtBoxUnidades.Text),enventaEstado);

            daoLibro.modificarLibro(int.Parse(txtBoxID.Text), libroNuevo);

            

        }
    }
}
