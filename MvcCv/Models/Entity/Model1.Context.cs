﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcCvEntities : DbContext
    {
        public DbMvcCvEntities()
            : base("name=DbMvcCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLAdmin> TBLAdmin { get; set; }
        public virtual DbSet<TBLDeneyimlerim> TBLDeneyimlerim { get; set; }
        public virtual DbSet<TBLEgitimlerim> TBLEgitimlerim { get; set; }
        public virtual DbSet<TBLHakkimda> TBLHakkimda { get; set; }
        public virtual DbSet<TBLHobilerim> TBLHobilerim { get; set; }
        public virtual DbSet<TBLİletisim> TBLİletisim { get; set; }
        public virtual DbSet<TBLSertifikalarım> TBLSertifikalarım { get; set; }
        public virtual DbSet<TBLSosyalMedya> TBLSosyalMedya { get; set; }
        public virtual DbSet<TBLYeteneklerim> TBLYeteneklerim { get; set; }
    }
}
