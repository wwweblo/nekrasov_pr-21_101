using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nekrasov_pr_21_101.model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<Middlename> Middlename { get; set; }
        public virtual DbSet<Name> Name { get; set; }
        public virtual DbSet<PartnerProducts> PartnerProducts { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<Surname> Surname { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Middlename>()
                .HasMany(e => e.Partners)
                .WithOptional(e => e.Middlename1)
                .HasForeignKey(e => e.middlename);

            modelBuilder.Entity<Name>()
                .HasMany(e => e.Partners)
                .WithOptional(e => e.Name1)
                .HasForeignKey(e => e.middlename);

            modelBuilder.Entity<Partners>()
                .HasMany(e => e.PartnerProducts)
                .WithOptional(e => e.Partners)
                .HasForeignKey(e => e.Наименование_партнера);

            modelBuilder.Entity<PartnerType>()
                .HasMany(e => e.Partners)
                .WithOptional(e => e.PartnerType)
                .HasForeignKey(e => e.name);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.PartnerProducts)
                .WithOptional(e => e.Products)
                .HasForeignKey(e => e.Продукция);

            modelBuilder.Entity<ProductTypes>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.ProductTypes)
                .HasForeignKey(e => e.Тип_продукции);

            modelBuilder.Entity<Surname>()
                .HasMany(e => e.Partners)
                .WithOptional(e => e.Surname1)
                .HasForeignKey(e => e.surname);
        }
    }
}
