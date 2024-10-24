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


            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Título", 150);
            listView1.Columns.Add("Autor", 150);
            listView1.Columns.Add("Editorial", 150);
                  
            foreach (Libro libro in listaLibros)
            {
                ListViewItem item = new ListViewItem(libro.titulo);
                item.SubItems.Add(libro.autor);
                item.SubItems.Add(libro.editorial);

                listView1.Items.Add(item);
            }


        }

    }
}
