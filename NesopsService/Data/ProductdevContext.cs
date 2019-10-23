using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NesopsService.Data
{
    public partial class ProductdevContext : DbContext
    {
        public ProductdevContext(DbContextOptions<ProductdevContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<NesopsService.Data.Entities.AspNetRoleClaims> AspNetRoleClaims { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetRoles> AspNetRoles { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetUserClaims> AspNetUserClaims { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetUserLogins> AspNetUserLogins { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetUserRoles> AspNetUserRoles { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetUsers> AspNetUsers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.AspNetUserTokens> AspNetUserTokens { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Categories> Categories { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Optiongroups> Optiongroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Options> Options { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.OrderDetailProductOptions> OrderDetailProductOptions { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.OrderDetails> OrderDetails { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Orders> Orders { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.ProductAttributes> ProductAttributes { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.ProductImages> ProductImages { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.ProductOptions> ProductOptions { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Products> Products { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.ProductVideos> ProductVideos { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Stores> Stores { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.Subcategories> Subcategories { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetRoleClaimsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetRolesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetUserClaimsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetUserLoginsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetUserRolesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetUsersMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.AspNetUserTokensMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CategoriesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.OptiongroupsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.OptionsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.OrderDetailProductOptionsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.OrderDetailsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.OrdersMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.ProductAttributesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.ProductImagesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.ProductOptionsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.ProductsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.ProductVideosMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.StoresMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.SubcategoriesMap());
            #endregion
        }
    }
}
