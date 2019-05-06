using Dootrix.Planets.Common;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dootrix.Planets.Data.SQL
{
    internal class StateContextFactory : IDesignTimeDbContextFactory<DbStateContext>
    {
        public DbStateContext CreateDbContext(string[] args)
        {
            return new DbStateContext(CommonConfiguration.Config["Sql:ConnectionString"]);
        }
    }
}
