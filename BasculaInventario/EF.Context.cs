﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasculaInventario
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BasculaInventarioEntities : DbContext
    {
        public BasculaInventarioEntities()
            : base("name=BasculaInventarioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aditivos> aditivos { get; set; }
        public virtual DbSet<choferes> choferes { get; set; }
        public virtual DbSet<colores> colores { get; set; }
        public virtual DbSet<maquinas> maquinas { get; set; }
        public virtual DbSet<ordenesDeTrabajo> ordenesDeTrabajo { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<registroDePeso> registroDePeso { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<turnos> turnos { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<vehiculos> vehiculos { get; set; }
    }
}
