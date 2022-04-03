using Planets_fact_site_API.Data;
using Planets_fact_site_API.Domain;
using Xunit;

namespace Planets_fact_site_API.Tests;

public class PlanetsReposTests
{
    [Fact]
    public void test1()
    {
        //Arrange
        var repo = new PlanetsRepo();
        var pla = new Planets(repo.Planets());
        //Act
        pla.Planet("Earth");

        //Assert

    }
}