﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplomska.Properties.DataSources
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BazaDiplomskaNovaEntities : DbContext
    {
        public BazaDiplomskaNovaEntities()
            : base("name=BazaDiplomskaNovaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kontrolne_Naloge> Kontrolne_Naloge { get; set; }
        public virtual DbSet<Kriterij> Kriterij { get; set; }
        public virtual DbSet<Letnik> Letnik { get; set; }
        public virtual DbSet<Poglavje> Poglavje { get; set; }
        public virtual DbSet<Predmeti> Predmeti { get; set; }
        public virtual DbSet<Rešitve> Rešitve { get; set; }
        public virtual DbSet<Stopnja_Težavnosti> Stopnja_Težavnosti { get; set; }
    }
}
