using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class OrdersMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.Orders>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.Orders> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("orders", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("user_id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.OrderAmount)
                .IsRequired()
                .HasColumnName("order_amount")
                .HasColumnType("float");

            builder.Property(t => t.ShipPhone)
                .IsRequired()
                .HasColumnName("ship_phone")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ShipAddress)
                .IsRequired()
                .HasColumnName("ship_address")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.ShipCity)
                .IsRequired()
                .HasColumnName("ship_city")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ShipState)
                .IsRequired()
                .HasColumnName("ship_state")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ShipCountry)
                .IsRequired()
                .HasColumnName("ship_country")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ShipStatus)
                .IsRequired()
                .HasColumnName("ship_status")
                .HasColumnType("bit");

            builder.Property(t => t.ShipDate)
                .IsRequired()
                .HasColumnName("ship_date")
                .HasColumnType("date");

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
            builder.HasOne(t => t.UserAspNetUsers)
                .WithMany(t => t.UserOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__orders__user_id__0F2D40CE");

            #endregion
        }

    }
}
