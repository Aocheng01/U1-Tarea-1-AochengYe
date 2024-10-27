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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DaoLibro daoLibro = new DaoLibro();
            List<Libro> listaLibros = daoLibro.listarLibros();
            dataGridView1.DataSource = listaLibros;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtBoxTitulo.Text = selectedRow.Cells["titulo"].Value.ToString();
                txtBoxAutor.Text = selectedRow.Cells["autor"].Value.ToString();
                txtBoxEditorial.Text = selectedRow.Cells["editorial"].Value.ToString();
                txtBoxFchaPublicacion.Text = selectedRow.Cells["fecha_publicacion"].Value.ToString();
                txtBoxImagen.Text = selectedRow.Cells["imagen"].Value.ToString();
                txtBoxDescripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
                txtBoxPrecio.Text = selectedRow.Cells["precio"].Value.ToString();
                txtBoxUnidades.Text = selectedRow.Cells["unidades"].Value.ToString();
                checkBoxEnVenta.Checked = (bool)selectedRow.Cells["enVenta"].Value;
            }
        }
    }
}
