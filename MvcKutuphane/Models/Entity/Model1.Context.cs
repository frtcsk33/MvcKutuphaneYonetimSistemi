﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphane.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBKUTUPHANEEntities : DbContext
    {
        public DBKUTUPHANEEntities()
            : base("name=DBKUTUPHANEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLCEZALAR> TBLCEZALAR { get; set; }
        public virtual DbSet<TBLHAREKET> TBLHAREKET { get; set; }
        public virtual DbSet<TBLKASA> TBLKASA { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORI { get; set; }
        public virtual DbSet<TBLKITAP> TBLKITAP { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLUYELER> TBLUYELER { get; set; }
        public virtual DbSet<TBLYAZAR> TBLYAZAR { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLMESAJLAR> TBLMESAJLAR { get; set; }
    
        public virtual ObjectResult<string> EnFazlaKitapYazar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnFazlaKitapYazar");
        }
    
        public virtual ObjectResult<string> EnAktifUye()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnAktifUye");
        }
    
        public virtual ObjectResult<string> EnCokOkunanKitap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnCokOkunanKitap");
        }
    
        public virtual ObjectResult<Nullable<int>> BugunVerilenEmanetKitaplar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("BugunVerilenEmanetKitaplar");
        }
    
        public virtual ObjectResult<string> EnBasariliEleman()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnBasariliEleman");
        }
    }
}
