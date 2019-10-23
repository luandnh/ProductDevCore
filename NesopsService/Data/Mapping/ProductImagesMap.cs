using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class ProductImagesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.ProductImages>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.ProductImages> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("product_images", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.ProductId)
                .IsRequired()
                .HasColumnName("product_id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.Title)
                .HasColumnName("title")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ThumbnailPath)
                .HasColumnName("thumbnail_path")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Path)
                .IsRequired()
                .HasColumnName("path")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

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
            builder.HasOne(t => t.ProductProducts)
                .WithMany(t => t.ProductProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__product_i__produ__690797E6");

            #endregion
        }

    }
}
