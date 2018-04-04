using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Us
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Pass { get; set; }
        public DateTime Fecha { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Us()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            NombreUsuario = string.Empty;
            Pass = string.Empty;
            Fecha = DateTime.Now;
            Telefono = string.Empty;
            Direccion = string.Empty;        
        }

        public Us(int UsuarioId, string Nombre, string NombreUsuario, string Pass, DateTime Fecha, string Telefono, string Direccion)
        {
            this.UsuarioId = UsuarioId;
            this.Nombre = Nombre;
            this.NombreUsuario = NombreUsuario;
            this.Pass = Pass;
            this.Fecha = Fecha;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
    }
}
