﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airbag.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirbagEntities : DbContext
    {
        public AirbagEntities()
            : base("name=AirbagEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAdministrador> tblAdministrador { get; set; }
        public virtual DbSet<tblCat_Carrito> tblCat_Carrito { get; set; }
        public virtual DbSet<tblCat_Categoria> tblCat_Categoria { get; set; }
        public virtual DbSet<tblCat_Producto> tblCat_Producto { get; set; }
        public virtual DbSet<tblCompra> tblCompra { get; set; }
        public virtual DbSet<tblDetallesCompra> tblDetallesCompra { get; set; }
        public virtual DbSet<tblDireccion> tblDireccion { get; set; }
        public virtual DbSet<tblTarjeta> tblTarjeta { get; set; }
        public virtual DbSet<tblUsuario> tblUsuario { get; set; }
    }
}
