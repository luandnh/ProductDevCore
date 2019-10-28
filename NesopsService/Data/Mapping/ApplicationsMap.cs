using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class ApplicationsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.Applications>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.Applications> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Applications", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DisplayName)
                .HasColumnName("DisplayName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.RedirectUrl)
                .HasColumnName("RedirectUrl")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.OwnerId)
                .HasColumnName("OwnerId")
                .HasColumnType("uniqueidentifier");

            // relationships
            builder.HasOne(t => t.OwnerAspNetUsers)
                .WithMany(t => t.OwnerApplications)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Applications_AspNetUsers_OwnerId");

            #endregion
        }

    }
}
