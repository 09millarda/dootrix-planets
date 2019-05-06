using Dootrix.Planets.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Dootrix.Planets.Data.SQL.Helpers
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddSqlRepositories(this IServiceCollection collection)
        {
            collection.AddDbContext<DbStateContext>(sp => new DbStateContext(CommonConfiguration.Config["Sql:ConnectionString"]));
            collection.AddTransient<IPlanetsRepository, SqlPlanetsRepository>();

            return collection;
        }
    }
}
