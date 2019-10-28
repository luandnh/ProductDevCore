using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class AspNetUserLoginsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.AspNetUserLogins>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.AspNetUserLogins> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AspNetUserLogins", "dbo");

            // key
            builder.HasKey(t => new { t.LoginProvider, t.ProviderKey });

            // properties
            builder.Property(t => t.LoginProvider)
                .IsRequired()
                .HasColumnName("LoginProvider")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.ProviderKey)
                .IsRequired()
                .HasColumnName("ProviderKey")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450);

            builder.Property(t => t.ProviderDisplayName)
                .HasColumnName("ProviderDisplayName")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier");

            // relationships
            builder.HasOne(t => t.UserAspNetUsers)
                .WithMany(t => t.UserAspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");

            #endregion
        }

    }
}
