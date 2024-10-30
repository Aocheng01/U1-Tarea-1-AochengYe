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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Otra forma pero no se selecciona en cualquier cell.
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            //    txtBoxTitulo.Text = selectedRow.Cells["titulo"].Value.ToString();
            //    txtBoxAutor.Text = selectedRow.Cells["autor"].Value.ToString();
            //    txtBoxEditorial.Text = selectedRow.Cells["editorial"].Value.ToString();
            //    txtBoxFchaPublicacion.Text = selectedRow.Cells["fecha_publicacion"].Value.ToString();
            //    txtBoxImagen.Text = selectedRow.Cells["imagen"].Value.ToString();
            //    txtBoxDescripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
            //    txtBoxPrecio.Text = selectedRow.Cells["precio"].Value.ToString();
            //    txtBoxUnidades.Text = selectedRow.Cells["unidades"].Value.ToString();
            //    checkBoxEnVenta.Checked = (bool)selectedRow.Cells["enVenta"].Value;
            //}

            if (e.RowIndex >= 0) // Asegúrate de que el clic se hace en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                
                txtBoxID.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;
                txtBoxTitulo.Text = filaSeleccionada.Cells[1].Value?.ToString() ?? string.Empty;
                txtBoxAutor.Text = filaSeleccionada.Cells[2].Value?.ToString() ?? string.Empty;
                txtBoxEditorial.Text = filaSeleccionada.Cells[3].Value?.ToString() ?? string.Empty;
                fechaPublicacionPicker.Value = DateTime.Parse(filaSeleccionada.Cells[4].Value?.ToString() ?? string.Empty);
                txtBoxImagen.Text = filaSeleccionada.Cells[5].Value?.ToString() ?? string.Empty;
                txtBoxDescripcion.Text = filaSeleccionada.Cells[6].Value?.ToString() ?? string.Empty;
                txtBoxPrecio.Text = filaSeleccionada.Cells[7].Value?.ToString() ?? string.Empty;
                txtBoxUnidades.Text = filaSeleccionada.Cells[8].Value?.ToString() ?? string.Empty;
                if (filaSeleccionada.Cells[9].Value.ToString().Equals("True"))
                {
                    checkBoxEnVenta.Checked = true;
                }
                else
                {
                    checkBoxEnVenta.Checked = false;
                }
            }
        }
    }
}
