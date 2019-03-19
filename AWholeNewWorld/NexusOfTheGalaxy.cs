using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy

{
    class NexusOfTheGalaxy: GalaxyClass
    {
        public void Nexus()
        {
            Console.Clear();
            string earthName = EarthName();
            string alphaName = AlphaName();
            string proximaName = ProximaName();
            Console.WriteLine($"You stand at the Nexus of the Galaxy! There are several\n" +
                              $"portals before you. Do you dare to travel?\n\n" +
                              $"Earth\n" +
                              $"Proxima B\n" +
                              $"Alpha Centauri\n\n" +
                              $"Select a Destination");
            bool test = true;
            while(test)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "earth":
                        PlanetEarth();
                        break;
                    case "proxima b":
                        PlanetProxima();
                        break;
                    case "alpha centauri":
                        PlanetAlpha();
                        break;
                    default:
                        Nexus();
                        break;
                }
            }
            
        }
    }
}
