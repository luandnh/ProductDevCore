using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Nesops.Oauth2.Library.Configs;
using Nesops.Oauth2.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesops.Oauth2.Library.DataContext
{
    public class NesopsDbContext : IdentityDbContext<NesopsUsers, NesopsRoles, Guid>
    {
        public NesopsDbContext(DbContextOptions<NesopsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<NesopsApplications> Applications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
    public class NesopsDbContextFactory : IDesignTimeDbContextFactory<NesopsDbContext>
    {

        public NesopsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NesopsDbContext>();
            optionsBuilder.UseSqlServer(NesopsSqlServerConnection.GetConnectionString());
            return new NesopsDbContext(optionsBuilder.Options);
        }
    }
}

