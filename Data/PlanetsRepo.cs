using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Planets_fact_site_API.Domain;

namespace Planets_fact_site_API.Data;

public class PlanetsRepo
{
   public List<PlanetInformation> Planets()
   {
      return new List<PlanetInformation>
      {
         new()
         {
            PlanetName = "Earth",
            Overview = new Overviews
            {
               Content =
                  "Third planet from the Sun and the only known planet to harbor life. About 29.2% of Earth's surface is land with remaining 70.8% is covered with water. Earth's distance from the Sun, physical properties and geological history have allowed life to evolve and thrive.",
               Source = "https://en.wikipedia.org/wiki/Earth"
            },
            Structure = new Overviews
            {
               Content =
                  "Earth's interior, like that of the other terrestrial planets, is divided into layers by their chemical or physical (rheological) properties. The outer layer is a chemically distinct silicate solid crust, which is underlain by a highly viscous solid mantle.",
               Source = "https://en.wikipedia.org/wiki/Earth#Internal_structure"
            },
            Geology = new Overviews
            {
               Content =
                  "The total surface area of Earth is about 510 million km2. The continental crust consists of lower density material such as the igneous rocks granite and andesite. Less common is basalt, a denser volcanic rock that is the primary constituent of the ocean floors.",
               Source = "https://en.wikipedia.org/wiki/Earth#Surface"
            },
            Rotation = "0.99 Days",
            Revolution = "365.26 Days",
            Radius = "6,371 KM",
            Temperature = "16°c"
         },
         new PlanetInformation
         {
            PlanetName = "Mercury",
            Overview = new Overviews
            {
               Content =
                  "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. Mercury is one of four terrestrial planets in the Solar System, and is a rocky body like Earth.",
               Source = "https://en.wikipedia.org/wiki/Mercury_(planet)"
            },
            Structure = new Overviews
            {
               Content =
                  "Mercury appears to have a solid silicate crust and mantle overlying a solid, iron sulfide outer core layer, a deeper liquid core layer, and a solid inner core. The planet's density is the second highest in the Solar System at 5.427 g/cm3 , only slightly less than Earth's density.",
               Source = "https://en.wikipedia.org/wiki/Mercury_(planet)#Internal_structure"
            },
            Geology = new Overviews
            {
               Content =
                  "Mercury's surface is similar in appearance to that of the Moon, showing extensive mare-like plains and heavy cratering, indicating that it has been geologically inactive for billions of years. It is more heterogeneous than either Mars's or the Moon’s.",
               Source = "https://en.wikipedia.org/wiki/Mercury_(planet)#Surface_geology"
            },
            Rotation = "58.6 Days",
            Revolution = "87.97 Days",
            Radius = "2,439.7 KM",
            Temperature = "430°c",
         }

      };
   }

}