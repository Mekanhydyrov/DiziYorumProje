﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbFilimDiziEntities1 : DbContext
    {
        public DbFilimDiziEntities1()
            : base("name=DbFilimDiziEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblBlok> TblBlok { get; set; }
        public virtual DbSet<TblHakkimizda> TblHakkimizda { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblTur> TblTur { get; set; }
        public virtual DbSet<TblYorum> TblYorum { get; set; }
    }
}