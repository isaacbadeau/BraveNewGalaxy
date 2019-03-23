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
            string proximaName = ObicromPersei8Name();
            Console.WriteLine("\n\n\t\t\t\t\tNexus of the Galaxy\n");
            Console.WriteLine($"\t\t\tYou stand at the Nexus of the Galaxy. There are several\n" +
                              $"\t\t\tportals before you. Do you dare to travel?\n\n"+
                              $"\t\t\t\t[E]arth\n" +
                              $"\t\t\t\t[O]bicrom Persei 8\n" +
                              $"\t\t\t\t[A]lpha Centauri\n\n");
            bool test = true;
            while (test)
            {
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.E:
                        PlanetEarth();
                        break;
                    case ConsoleKey.O:
                        PlanetObicrom();
                        break;
                    case ConsoleKey.A:
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
