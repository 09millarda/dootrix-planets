using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dootrix.Planets.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dootrix.Planets.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IPlanetsRepository _planetsRepository;

        public PlanetsController(IPlanetsRepository planetsRepository)
        {
            _planetsRepository = planetsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var planets = await _planetsRepository.GetPlanets().ConfigureAwait(false);

            return Ok(planets);
        }
    }
}