using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Fact
    {
        [Key]

        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public virtual List<FactDetalle> LFD { get; set; }

        public Fact()
        {
            FacturaId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Observaciones = string.Empty;
            LFD = new List<FactDetalle>();
        }

        public Fact(int FacturaId, int ClienteId, DateTime Fecha, decimal Monto, string Observaciones, List<FactDetalle> LFD)
        {
            this.FacturaId = FacturaId;
            this.ClienteId = ClienteId;
            this.Fecha = Fecha;
            this.Monto = Monto;
            this.Observaciones = Observaciones;
            this.LFD = LFD; 
        }
    }
}
