using Planets_fact_site_API.Data;
using Planets_fact_site_API.Domain;
using Xunit;

namespace Planets_fact_site_API.Tests;

public class PlanetsReposTests
{
    private readonly Planets _planets;

    public PlanetsReposTests()
    {
        var repo = new PlanetsRepo();
        _planets = new Planets(repo.Planets());
    }
    [Fact]
    public void ReturnsAllPlanets()
    {
        //Act
        var result = _planets.AllPlanets();
        //Assert
        Assert.NotNull(result);
    }
    [Fact]
    public void ReturnsEarths()
    {
        //Act
        var result = _planets.Planet("Earth");
        //Assert
        Assert.Equal("Earth", result.PlanetName);

    }
    
    [Fact]
    public void ReturnsMercury()
    {
        //Act
        var result = _planets.Planet("Mercury");
        //Assert
        Assert.Equal("Mercury", result.PlanetName);
    }
    
    [Fact]
    public void ReturnsVenus()
    {
        //Act
        var result = _planets.Planet("Venus");
        //Assert
        Assert.Equal("Venus", result.PlanetName);
    }
    
    [Fact]
    public void ReturnsMars()
    {
        //Act
        var result = _planets.Planet("Mars");
        //Assert
        Assert.Equal("Mars", result.PlanetName);

    }
    
    [Fact]
    public void ReturnsJupiter()
    {
        //Act
        var result = _planets.Planet("Jupiter");
        //Assert
        Assert.Equal("Jupiter", result.PlanetName);
    }

    [Fact]
    public void ReturnsSaturn()
    {
        //Act
        var result = _planets.Planet("Saturn");
        //Assert
        Assert.Equal("Saturn", result.PlanetName);
    }

    [Fact]
    public void ReturnsUranus()
    {
        //Act
        var result = _planets.Planet("Uranus");
        //Assert
        Assert.Equal("Uranus", result.PlanetName);
    }
    
    [Fact]
    public void ReturnsNeptune()
    {
        //Act
        var result = _planets.Planet("Neptune");
        //Assert
        Assert.Equal("Neptune", result.PlanetName);
    }
}