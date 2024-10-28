using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U1_Tarea_1___AochengYe.dto;


namespace U1_Tarea_1___AochengYe.dao
{
    internal class DaoLibro
    {
        public void insertarLibro(Libro libro) {

            try
            {
                string query = "INSERT INTO catalogo (titulo, autor, editorial, fecha_publicacion, imagen, descripcion, precio, unidades, enventa) " +

                "VALUES (@titulo, @autor, @editorial, @fecha_publicacion, @imagen, @descripcion, @precio, @unidades, @enventa)";

                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                myCommand.Parameters.AddWithValue("@titulo", libro.titulo);

                myCommand.Parameters.AddWithValue("@autor", libro.autor);

                myCommand.Parameters.AddWithValue("@editorial", libro.editorial);

                myCommand.Parameters.AddWithValue("@fecha_publicacion", libro.fecha_publicacion);

                myCommand.Parameters.AddWithValue("@imagen", libro.imagen);

                myCommand.Parameters.AddWithValue("@descripcion", libro.descripcion);

                myCommand.Parameters.AddWithValue("@precio", libro.precio);

                myCommand.Parameters.AddWithValue("@unidades", libro.unidades);

                myCommand.Parameters.AddWithValue("@enventa", libro.enventa);

                MySqlDataReader reader = myCommand.ExecuteReader();

                MessageBox.Show("¡Libro registrado exitosamente!");

                while (reader.Read()) { }

                objetoConexion.cerrarConexion();
            }

            catch (Exception ex)

            {
                MessageBox.Show("No se pudo guardar el libro. Error: " + ex.ToString());
            }
        }

        public List<Libro> listarLibros()
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                string query = "Select * from catalogo";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    Libro libro = new Libro(reader.GetString(1), 
                                            reader.GetString(2), 
                                            reader.GetString(3),
                                            reader.GetDateTime(4),
                                            reader.GetString(5),
                                            reader.GetString(6),
                                            reader.GetFloat(7),
                                            reader.GetInt16(8),
                                            reader.GetBoolean(9)
                                            );
                    libros.Add(libro);
                }
                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar los lbros.");
            }

            return libros;
        }


        private void updateLibro()
        {
            List<Libro> libros = new List<Libro>();

            try
            {
                string query = "Update catalogo set libro ";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                MySqlDataReader reader = myCommand.ExecuteReader();

      

     
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }





    }
}
