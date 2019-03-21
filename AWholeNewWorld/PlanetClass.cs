using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    public class PlanetClass:ShopClass
    {
        public string PlanetName { get; set; }
        public string PlanetDesc { get; set; }

        public string EarthName()
        {
            PlanetName = "Earth";
            return PlanetName;
        }

        public string EarthDesc()
        {
            
            PlanetDesc = "You've arrived at the main trading port of Earth.  \n" +
                         "The variety of humanoid species here is astonishing. You can't help but notice\n" +
                         "the local population looks rather affluent based on the rare metallic jewelry\n" +
                         "they adorn. You see a shop to the west.\n\n" +
                         "Exits: West, Leave";
            return PlanetDesc;
        }


        public string AlphaName()
        {
            PlanetName = "Alpha Centauri";

            return PlanetName;
        }

        public string AlphaCentauriDesc()
        {
            PlanetDesc = "You've arrived at the main port of a small planet orbitting Alpha Centauri. There are people\n" +
                         "bustling all around trading this and that.  You can't help but notice\n" +
                         "that there seems to be a premium placed on odd trinkets and antiques.\n\n" +
                         "You see a shop to the east." +
                         "Exits: East, Leave";

            return PlanetDesc;
        }


        public string ObicromPersei8Name()
        {
            PlanetName = "Obicrom Persie 8";

            return PlanetName;
        }

        public string ObicromPersei8Desc()
        {
            PlanetDesc = "You have touched down on a planatoid orbitting a rogue planet around Obicrom Persei 8\n" +
                         "You must say, the company being held here is less than reputable. There are\n" +
                         "shady characters all over, and the people look starved. You notice a shop to\n" +
                         "the north.\n\n" +
                         "Exits: North, Leave";

            return PlanetDesc;
        }
    }

    
}
