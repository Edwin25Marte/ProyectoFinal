using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("ConStr")
        { }

        public DbSet<Client> Cliente { get; set; }
        public DbSet<Peli> Pelicula { get; set; }
        public DbSet<Actores> Actor { get; set; }
        public DbSet<Generos> Genero { get; set; }
        public DbSet<GenAct> GA { get; set; }
        public DbSet<Fact> Factura { get; set; }
        public DbSet<FactDetalle> FactDetalle { get; set; }
        public DbSet<Us> Usuario { get; set; }
    }
}
