namespace Planets_fact_site_API.Domain;

public class Planets
{
    private readonly List<PlanetInformation> _planetInformation;


    public Planets(List<PlanetInformation> planetInformation )
    {
        _planetInformation = planetInformation;
    }

    public List<PlanetInformation> AllPlanets() => _planetInformation;

    public PlanetInformation Planet(string planetName)
    {
        foreach (var planet in _planetInformation.Where(planet => planet.PlanetName == planetName))
        {
            return planet;
        }
        throw new Exception("invalided planet name");
    }
}