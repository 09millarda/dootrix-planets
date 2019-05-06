using Dootrix.Planets.Data.SQL.Models;
using Microsoft.EntityFrameworkCore;
using Dootrix.Planets.Data.SQL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dootrix.Planets.Data.SQL
{
    internal class DbStateContext : DbContext
    {
        private readonly string _connectionString;

        public DbStateContext(string connectionString) => _connectionString = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);

        public DbSet<Models.Planet> Planets { get; set; }
        public DbSet<Models.ExtraInformation> ExtraInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePrimaryKey<Models.Planet>(e => e.PlanetId);
            builder.ConfigurePrimaryKey<Models.ExtraInformation>(e => e.ExtraInformationId);
        }
    }
}
