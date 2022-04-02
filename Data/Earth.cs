using Planets_fact_site_API.Domain;

namespace Planets_fact_site_API.Data;

public class Earth
{
   public void EarthBuilder()
   {
      var Earth = new PlanetInformation()
      {
         PlanetName = "Earth",
         Overview = new Overviews()
         {
            Content = "stuff",
            Source = "ssfkskf"
         },
         Geology = new Overviews()
         {
            
         }
      };
   }
}