using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dootrix.Planets.Data.SQL
{
    internal class SqlPlanetsRepository : SqlRepositoryBase, IPlanetsRepository
    {
        public SqlPlanetsRepository(DbStateContext context) : base(context) { }

        public async Task CreateExtraInformation(int planetId, IEnumerable<ExtraInformation> extraInformation)
        {
            var sqlPlanet = await Context.Planets.SingleOrDefaultAsync(p => p.PlanetId == planetId);

            var sqlExtraInformation = extraInformation.Select(i => new Models.ExtraInformation
            {
                PlanetId = planetId,
                Text = i.Text,
                Title = i.Title
            });

            await Context.ExtraInformation.AddRangeAsync(sqlExtraInformation);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteExtraInformation(IEnumerable<int> extraInformationIds)
        {
            var extraInformation = await Context.ExtraInformation.Where(i => extraInformationIds.Contains(i.ExtraInformationId)).ToListAsync();
            Context.ExtraInformation.RemoveRange(extraInformation);
            await Context.SaveChangesAsync();
        }

        public async Task<Planet> GetPlanetById(int id)
        {
            var planet = await Context.Planets.Include(p => p.ExtraInformation).SingleOrDefaultAsync(p => p.PlanetId == id);
            if (planet == null) return null;

            return new Planet
            {
                AstronomicalUnits = planet.AstronomicalUnits,
                Description = planet.Description,
                Radius = planet.Radius,
                Mass = decimal.Parse(planet.Mass, NumberStyles.Any, CultureInfo.InvariantCulture),
                Name = planet.Name,
                PlanetId = planet.PlanetId,
                ExtraInformation = planet.ExtraInformation.Select(i => new ExtraInformation
                {
                    ExtraInformationId = i.ExtraInformationId,
                    Text = i.Text,
                    Title = i.Title
                }).ToList()
            };
        }

        public async Task<IEnumerable<Planet>> GetPlanets()
        {
            var planets = await Context.Planets.Include(p => p.ExtraInformation).ToListAsync();

            return planets.Select(planet => new Planet
            {
                AstronomicalUnits = planet.AstronomicalUnits,
                Description = planet.Description,
                Radius = planet.Radius,
                Mass = decimal.Parse(planet.Mass, NumberStyles.Any, CultureInfo.InvariantCulture),
                Name = planet.Name,
                PlanetId = planet.PlanetId,
                ExtraInformation = planet.ExtraInformation.Select(i => new ExtraInformation
                {
                    ExtraInformationId = i.ExtraInformationId,
                    Text = i.Text,
                    Title = i.Title
                }).ToList()
            });
        }

        public async Task UpdateExtraInformation(ExtraInformation extraInformation)
        {
            var sqlExtraInformation = await Context.ExtraInformation.SingleOrDefaultAsync(i => i.ExtraInformationId == extraInformation.ExtraInformationId);
            if (sqlExtraInformation == null) return;

            sqlExtraInformation.Title = extraInformation.Title;
            sqlExtraInformation.Text = extraInformation.Text;

            Context.ExtraInformation.Update(sqlExtraInformation);
            await Context.SaveChangesAsync();
        }

        public async Task UpdatePlanet(Planet planet)
        {
            var sqlPlanet = await Context.Planets.SingleOrDefaultAsync(p => p.PlanetId == planet.PlanetId);
            if (sqlPlanet == null) return;

            sqlPlanet.Name = planet.Name;
            sqlPlanet.Mass = planet.Mass.ToString("E5");
            sqlPlanet.Radius = planet.Radius;
            sqlPlanet.AstronomicalUnits = planet.AstronomicalUnits;

            Context.Planets.Update(sqlPlanet);
            await Context.SaveChangesAsync();
        }
    }
}
