﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teploset.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutCatalog> AboutCatalog { get; set; }
        public virtual DbSet<NewsCatalog> NewsCatalog { get; set; }
        public virtual DbSet<PostCatalog> PostCatalog { get; set; }
        public virtual DbSet<VacancyCatalog> VacancyCatalog { get; set; }
        public virtual DbSet<LangTypeCatalog> LangTypeCatalogSet { get; set; }
    
        public virtual int getNewGuid(Nullable<System.Guid> param1)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getNewGuid", param1Parameter);
        }
    }
}
