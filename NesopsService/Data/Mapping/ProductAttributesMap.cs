using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class ProductAttributesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.ProductAttributes>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.ProductAttributes> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("product_attributes", "dbo");

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

            builder.Property(t => t.AttributeId)
                .IsRequired()
                .HasColumnName("attribute_id")
                .HasColumnType("uniqueidentifier");

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
                .WithMany(t => t.ProductProductAttributes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__product_a__produ__681373AD");

            #endregion
        }

    }
}
