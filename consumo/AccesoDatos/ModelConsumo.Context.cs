﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumo.AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CERDOSEntities : DbContext
    {
        public CERDOSEntities()
            : base("name=CERDOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BODEGAS> BODEGAS { get; set; }
        public virtual DbSet<Causas_Muertes> Causas_Muertes { get; set; }
        public virtual DbSet<Corrales> Corrales { get; set; }
        public virtual DbSet<Entradas> Entradas { get; set; }
        public virtual DbSet<Etapas> Etapas { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Galerones> Galerones { get; set; }
        public virtual DbSet<Granjas> Granjas { get; set; }
        public virtual DbSet<Lote1> Lote1 { get; set; }
        public virtual DbSet<Lote2> Lote2 { get; set; }
        public virtual DbSet<Mov_Evento> Mov_Evento { get; set; }
        public virtual DbSet<Salida_Muerte> Salida_Muerte { get; set; }
        public virtual DbSet<Salidas> Salidas { get; set; }
        public virtual DbSet<Salidas_Matadero> Salidas_Matadero { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
        public virtual DbSet<CONSUMO> CONSUMO { get; set; }
    }
}
