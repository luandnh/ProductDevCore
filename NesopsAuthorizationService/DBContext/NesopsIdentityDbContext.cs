using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NesopsAuthorizationService.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService.DBContext
{

    public class NesopsIdentityDbContext : IdentityDbContext<NesopsUser, NesopsRole, Guid>
    {
        public NesopsIdentityDbContext(DbContextOptions<NesopsIdentityDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<NesopsUser>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<NesopsUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            builder.Entity<NesopsUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            builder.Entity<NesopsRole>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<NesopsRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityUserRole<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));

            builder.Entity<IdentityUserRole<Guid>>(entity => entity.Property(m => m.RoleId).HasMaxLength(12));

            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserToken<Guid>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            builder.Entity<IdentityUserClaim<Guid>>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<IdentityUserClaim<Guid>>(entity => entity.Property(m => m.UserId).HasMaxLength(12));
            builder.Entity<IdentityRoleClaim<Guid>>(entity => entity.Property(m => m.Id).HasMaxLength(12));
            builder.Entity<IdentityRoleClaim<Guid>>(entity => entity.Property(m => m.RoleId).HasMaxLength(12));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
    public class NesopsIdentityDbContextFactory : IDesignTimeDbContextFactory<NesopsIdentityDbContext>
    {

        public NesopsIdentityDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NesopsIdentityDbContext>();
            optionsBuilder.UseSqlServer(NesopsSqlServerConnection.GetConnectionString());
            return new NesopsIdentityDbContext(optionsBuilder.Options);
        }
    }
}
