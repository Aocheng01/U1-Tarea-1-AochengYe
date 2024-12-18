﻿using System;
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DaoLibro daoLibro = new DaoLibro();
            Libro libro = null;


            int? id = string.IsNullOrEmpty(txtBoxID.Text) ? (int?)null : int.Parse(txtBoxID.Text);

            string titulo = string.IsNullOrEmpty(txtBoxTituloBuscar.Text) ? null : txtBoxTituloBuscar.Text;

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxID.Text) || string.IsNullOrWhiteSpace(txtBoxTitulo.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID y título válidos.");
                return;
            }

            DaoLibro daoLibro = new DaoLibro();
            bool enventaEstado = false;
            if (checkBoxEnVenta.Checked)
            {
                enventaEstado = true;
            }
            Libro libroNuevo = new Libro(txtBoxTitulo.Text, txtBoxAutor.Text, txtBoxEditorial.Text, fechaPublicacionPicker.Value, txtBoxImagen.Text, txtBoxDescripcion.Text, float.Parse(txtBoxPrecio.Text), int.Parse(txtBoxUnidades.Text), enventaEstado);

            daoLibro.modificarLibro(int.Parse(txtBoxID.Text), libroNuevo);
        }


    }
}
