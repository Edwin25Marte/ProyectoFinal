using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Actores
    {
        [Key]

        public int ActorID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDebut { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Actores()
        {
            ActorID = 0;
            Nombre = string.Empty;
            FechaDebut = DateTime.Now;
            FechaNacimiento = DateTime.Now;
        }

        public Actores(int ActorID, string Nombre, DateTime FechaDebut, DateTime FechaNacimiento)
        {
            this.ActorID = ActorID;
            this.Nombre = Nombre;
            this.FechaDebut = FechaDebut;
            this.FechaNacimiento = FechaNacimiento;
        }
    }
}
