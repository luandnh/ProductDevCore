using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class ProductOptionsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.ProductOptions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.ProductOptions> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("product_options", "dbo");

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

            builder.Property(t => t.OptionId)
                .IsRequired()
                .HasColumnName("option_id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.PriceIncrement)
                .IsRequired()
                .HasColumnName("price_increment")
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
            builder.HasOne(t => t.OptionOptions)
                .WithMany(t => t.OptionProductOptions)
                .HasForeignKey(d => d.OptionId)
                .HasConstraintName("FK__product_o__optio__6AEFE058");

            builder.HasOne(t => t.ProductProducts)
                .WithMany(t => t.ProductProductOptions)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__product_o__produ__69FBBC1F");

            #endregion
        }

    }
}
