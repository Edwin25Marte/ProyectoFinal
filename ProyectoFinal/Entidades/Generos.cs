using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Generos
    {
        [Key]

        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            GeneroId = 0;
            Nombre = string.Empty;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
        }

        public Generos(int GeneroId, string Nombre, DateTime Fecha, string Descripcion)
        {
            this.GeneroId = GeneroId;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
            this.Descripcion = Descripcion;
        }
    }
}
