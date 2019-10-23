using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class StoresMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.Stores>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.Stores> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("stores", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.StoreName)
                .IsRequired()
                .HasColumnName("store_name")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

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
            #endregion
        }

    }
}
