using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Peli
    {
        [Key]

        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Sipnosis { get; set; }
        public virtual List<GenAct> LGA { get; set; }

        public Peli()
        {
            PeliculaId = 0;
            Nombre = string.Empty;
            Precio = 0;
            FechaSalida = DateTime.Now;
            Sipnosis = string.Empty;
            LGA = new List<GenAct>();
        }
        public Peli(int PeliculaId, string Nombre, decimal Precio, DateTime FechaSalida, string Sipnosis, List<GenAct> LGA)
        {
            this.PeliculaId = PeliculaId;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.FechaSalida = FechaSalida;
            this.Sipnosis = Sipnosis;
            this.LGA = LGA;
        }
    }
}
