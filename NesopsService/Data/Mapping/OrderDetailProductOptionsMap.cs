using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class OrderDetailProductOptionsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.OrderDetailProductOptions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.OrderDetailProductOptions> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("order_detail_product_options", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.OrderDetailId)
                .IsRequired()
                .HasColumnName("order_detail_id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ProductOptionId)
                .IsRequired()
                .HasColumnName("product_option_id")
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
            builder.HasOne(t => t.OrderDetailOrderDetails)
                .WithMany(t => t.OrderDetailOrderDetailProductOptions)
                .HasForeignKey(d => d.OrderDetailId)
                .HasConstraintName("FK__order_det__order__65370702");

            builder.HasOne(t => t.ProductOptionProductOptions)
                .WithMany(t => t.ProductOptionOrderDetailProductOptions)
                .HasForeignKey(d => d.ProductOptionId)
                .HasConstraintName("FK__order_det__produ__662B2B3B");

            #endregion
        }

    }
}
