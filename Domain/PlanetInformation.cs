namespace Planets_fact_site_API.Domain;

public class PlanetInformation
{
    public string? PlanetName { get; set; }
    public Overviews? Overview { get; set; }
    public Overviews? Structure { get; set; }
    public Overviews? Geology { get; set; }
    public string? Rotation { get; set; }
    public string? Revolution { get; set; }
    public string? Radius { get; set; }
    public string? Temperature { get; set; }
}