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


            Libro libro = daoLibro.buscarLibro(int.Parse(txtBoxID.Text));

            if (libro == null)
            {
                MessageBox.Show("No se encontró el libro con el id:" + txtBoxID + " o con título: " + txtBoxTituloBuscar);
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
                if (libro.enventa == true)
                {
                    checkBoxEnVenta.Checked = true;
                }
            }
        }
    }
}
