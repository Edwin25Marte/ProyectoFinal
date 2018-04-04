using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class GenAct
    {
        [Key]

        public int GAId { get; set; }
        public int ActorId { get; set; }
        public int GeneroId { get; set; }
        public string Actor { get; set; }
        public string Genero { get; set; }

        public GenAct()
        {
            GAId = 0;
            ActorId = 0;
            GeneroId = 0;
            Actor = string.Empty;
            Genero = string.Empty;
        }

        public GenAct(int GAId, int ActorId, int GeneroId, string Actor, string Genero)
        {
            this.GAId = GAId;
            this.ActorId = ActorId;
            this.GeneroId = GeneroId;
            this.Actor = Actor;
            this.Genero = Genero;
        }
    }
}
