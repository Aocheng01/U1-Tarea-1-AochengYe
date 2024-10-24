﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_Tarea_1___AochengYe.dto
{
    internal class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public DateTime fecha_publicacion { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int unidades { get; set; }
        public Boolean enventa { get; set; }

        public Libro(string titulo, string autor, string editorial, DateTime fecha_publicacion, string imagen, string descripcion, float precio, int unidades, bool enventa)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.fecha_publicacion = fecha_publicacion;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.precio = precio;
            this.unidades = unidades;
            this.enventa = enventa;
        }

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
