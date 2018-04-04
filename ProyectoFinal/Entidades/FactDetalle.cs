using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class FactDetalle
    {
        [Key]

        public int FactDetalleId { get; set; }
        public int FacturaId { get; set; }
        public int PeliculaId { get; set; }
        public string Cliente { get; set; }
        public string Pelicula { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public FactDetalle()
        {
            FactDetalleId = 0;
            FacturaId = 0;
            PeliculaId = 0;
            Cliente = string.Empty;
            Pelicula = string.Empty;
            Cantidad = 0;
            Importe = 0;
        }

        public FactDetalle(int FactDetalleId, int FacturaId, int PeliculaId, string Cliente, string Pelicula, int Cantidad, decimal Precio, decimal Importe)
        {
            this.FactDetalleId = FactDetalleId;
            this.FacturaId = FacturaId;
            this.PeliculaId = PeliculaId;
            this.Cliente = Cliente;
            this.Pelicula = Pelicula;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = Importe;
        }
    }
}
