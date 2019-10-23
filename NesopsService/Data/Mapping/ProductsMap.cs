using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class ProductsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.Products>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.Products> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("products", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.ProductName)
                .IsRequired()
                .HasColumnName("product_name")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ProductSku)
                .IsRequired()
                .HasColumnName("product_sku")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ShortDesc)
                .HasColumnName("short_desc")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.LongDesc)
                .HasColumnName("long_desc")
                .HasColumnType("text");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int");

            builder.Property(t => t.SubcategoryId)
                .IsRequired()
                .HasColumnName("subcategory_id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.CurrentPrice)
                .IsRequired()
                .HasColumnName("current_price")
                .HasColumnType("float");

            builder.Property(t => t.OldPrice)
                .HasColumnName("old_price")
                .HasColumnType("float");

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("active")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.CreateAt)
                .IsRequired()
                .HasColumnName("createAt")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.UpdateAt)
                .IsRequired()
                .HasColumnName("updateAt")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.SubcategorySubcategories)
                .WithMany(t => t.SubcategoryProducts)
                .HasForeignKey(d => d.SubcategoryId)
                .HasConstraintName("FK__products__subcat__671F4F74");

            #endregion
        }

    }
}
