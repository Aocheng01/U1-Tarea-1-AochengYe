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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DaoLibro daoLibro = new DaoLibro();
            Libro libro = null;
            
            //Con operador ternario 
            int? id = string.IsNullOrEmpty(txtBoxID.Text) ? (int?)null : int.Parse(txtBoxID.Text);
            
            string titulo = string.IsNullOrEmpty(txtBoxTituloBuscar.Text) ? null : txtBoxTituloBuscar.Text;

            //con if else, es más largo y tedioso, mejor con op ternario.
            //int? id;
            //if (string.IsNullOrEmpty(txtBoxID.Text))
            //{
            //    id = null;
            //}
            //else
            //{
            //    id = int.Parse(txtBoxID.Text);
            //}
            //string titulo;
            //if (string.IsNullOrEmpty(txtBoxTituloBuscar.Text))
            //{
            //    titulo = null;
            //}
            //else
            //{
            //    titulo = txtBoxTituloBuscar.Text;
            //}


            libro = daoLibro.buscarLibro(id, titulo);
            if (libro == null)
            {
                MessageBox.Show("No se encontró el libro con el id: " + txtBoxID.Text + " o con título: " + txtBoxTituloBuscar.Text);
            }
            else
            {
                txtBoxTitulo.Text = libro.titulo;
                txtBoxPrecio.Text = libro.precio.ToString();
                txtBoxDescripcion.Text = libro.descripcion;
                txtBoxEditorial.Text = libro.editorial;
                fechaPublicacionPicker.Value = libro.fecha_publicacion;
                txtBoxImagen.Text = libro.imagen;
                txtBoxUnidades.Text = libro.unidades.ToString();
                txtBoxAutor.Text = libro.autor;
                checkBoxEnVenta.Checked = libro.enventa;
            }
        }
    }
}
