using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Client
    {
        [Key]
        
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaReg { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Client()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
            FechaReg = DateTime.Now;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
        }
        public Client(int ClienteId, string Nombres, string Apellidos, string Direccion, DateTime FechaNacimiento, DateTime FechaReg, string Telefono, string Celular, string Email)
        {
            this.ClienteId = ClienteId;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
            this.FechaReg = FechaReg;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Email = Email;
        }
    }
}
