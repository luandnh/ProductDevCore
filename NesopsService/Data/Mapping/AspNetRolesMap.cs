using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class AspNetRolesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.AspNetRoles>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.AspNetRoles> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetRoles", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NormalizedName)
                .HasColumnName("NormalizedName")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DisplayName)
                .HasColumnName("DisplayName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

    }
}
