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

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("Active")
                .HasColumnType("bit")
                .HasDefaultValueSql("(CONVERT([bit],(1)))");

            builder.Property(t => t.CreateAt)
                .IsRequired()
                .HasColumnName("createAt")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            builder.Property(t => t.UpdateAt)
                .IsRequired()
                .HasColumnName("updateAt")
                .HasColumnType("datetime2")
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            // relationships
            builder.HasOne(t => t.OwnerAspNetUsers)
                .WithMany(t => t.OwnerApplications)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Applications_AspNetUsers_OwnerId");

            #endregion
        }

    }
}
