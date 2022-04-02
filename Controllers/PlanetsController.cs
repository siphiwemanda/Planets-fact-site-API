using Microsoft.AspNetCore.Mvc;
using Planets_fact_site_API.Data;
using Planets_fact_site_API.Domain;

namespace Planets_fact_site_API.Controllers;

public class PlanetsController : BaseApiController
{
    [HttpGet]
    [Route("Earth")]
    public PlanetInformation Earth()
    {
        var earth = new PlanetsRepo();
        return earth.GetEarth();
    }
    
    [HttpGet]
    [Route("[Mercury]")]
    public PlanetInformation Mercury()
    {
        var earth = new PlanetsRepo();
        return earth.GetEarth();
    }
}