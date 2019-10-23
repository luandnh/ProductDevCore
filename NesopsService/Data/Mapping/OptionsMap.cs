using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class OptionsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.Options>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.Options> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("options", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.OptionName)
                .IsRequired()
                .HasColumnName("option_name")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.OptionGroupId)
                .IsRequired()
                .HasColumnName("option_group_id")
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
            builder.HasOne(t => t.OptionGroupOptiongroups)
                .WithMany(t => t.OptionGroupOptions)
                .HasForeignKey(d => d.OptionGroupId)
                .HasConstraintName("FK__options__option___625A9A57");

            #endregion
        }

    }
}
