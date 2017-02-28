namespace Teploset.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AboutCatalog> AboutCatalog { get; set; }
        public virtual DbSet<LangCatalog> LangCatalog { get; set; }
        public virtual DbSet<NewsCatalog> NewsCatalog { get; set; }
        public virtual DbSet<PostCatalog> PostCatalog { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VacancyCatalog> VacancyCatalog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutCatalog>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<LangCatalog>()
                .Property(e => e.LangTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<NewsCatalog>()
                .Property(e => e.NewsTitle)
                .IsUnicode(false);

            modelBuilder.Entity<NewsCatalog>()
                .Property(e => e.NewsBody)
                .IsUnicode(false);

            modelBuilder.Entity<PostCatalog>()
                .Property(e => e.PostTitle)
                .IsUnicode(false);

            modelBuilder.Entity<PostCatalog>()
                .Property(e => e.PostBody)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<VacancyCatalog>()
                .Property(e => e.VacancyName)
                .IsUnicode(false);

            modelBuilder.Entity<VacancyCatalog>()
                .Property(e => e.Comment)
                .IsUnicode(false);
        }
    }
}
