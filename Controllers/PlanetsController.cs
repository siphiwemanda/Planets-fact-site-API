using Microsoft.AspNetCore.Mvc;
using Planets_fact_site_API.Data;
using Planets_fact_site_API.Domain;

namespace Planets_fact_site_API.Controllers;

public class PlanetsController : BaseApiController
{
    [HttpGet]
    public List<PlanetInformation> GetAllPlanets()
    {
        var repo = new PlanetsRepo();
        var allPlanets = new Planets(repo.Planets());
        return allPlanets.AllPlanets();
        
    }
    
    [HttpGet ("{planetName}")]
    public PlanetInformation GetPlanet(string planetName)
    {
        var repo = new PlanetsRepo();
        var allPlanets = new Planets(repo.Planets());
        return allPlanets.Planet(planetName);
        
    }
}