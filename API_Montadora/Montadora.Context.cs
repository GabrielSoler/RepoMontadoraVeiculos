﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Montadora
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class montadoraEntities : DbContext
    {
        public montadoraEntities()
            : base("name=montadoraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<pedido> pedido { get; set; }
        public virtual DbSet<tbl_cambio> tbl_cambio { get; set; }
        public virtual DbSet<tbl_carroceria> tbl_carroceria { get; set; }
        public virtual DbSet<tbl_carros> tbl_carros { get; set; }
        public virtual DbSet<tbl_motor> tbl_motor { get; set; }
        public virtual DbSet<tbl_series> tbl_series { get; set; }
        public virtual DbSet<tbl_trim> tbl_trim { get; set; }
    }
}
