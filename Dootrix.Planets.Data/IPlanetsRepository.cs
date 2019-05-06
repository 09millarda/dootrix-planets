using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dootrix.Planets.Data
{
    public interface IPlanetsRepository
    {
        Task<Planet> GetPlanetById(int id);
        Task<IEnumerable<Planet>> GetPlanets();
        Task UpdatePlanet(Planet planet);
        Task CreateExtraInformation(int planetId, IEnumerable<ExtraInformation> extraInformation);
        Task UpdateExtraInformation(ExtraInformation extraInformation);
        Task DeleteExtraInformation(IEnumerable<int> extraInformationIds);
    }
}
