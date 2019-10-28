using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class AspNetUsersMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.AspNetUsers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.AspNetUsers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetUsers", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.UserName)
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NormalizedUserName)
                .HasColumnName("NormalizedUserName")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NormalizedEmail)
                .HasColumnName("NormalizedEmail")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.EmailConfirmed)
                .IsRequired()
                .HasColumnName("EmailConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.SecurityStamp)
                .HasColumnName("SecurityStamp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ConcurrencyStamp)
                .HasColumnName("ConcurrencyStamp")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.PhoneNumberConfirmed)
                .IsRequired()
                .HasColumnName("PhoneNumberConfirmed")
                .HasColumnType("bit");

            builder.Property(t => t.TwoFactorEnabled)
                .IsRequired()
                .HasColumnName("TwoFactorEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.LockoutEnd)
                .HasColumnName("LockoutEnd")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.LockoutEnabled)
                .IsRequired()
                .HasColumnName("LockoutEnabled")
                .HasColumnType("bit");

            builder.Property(t => t.AccessFailedCount)
                .IsRequired()
                .HasColumnName("AccessFailedCount")
                .HasColumnType("int");

            builder.Property(t => t.Fullname)
                .HasColumnName("Fullname")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

    }
}
