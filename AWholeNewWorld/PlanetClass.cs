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
            
            PlanetDesc = "You've arrived at the main trading port of Earth.\n" +
                         "The variety of humanoid species here is astonishing.\n" +
                         "You can't help but notice the local population looks\n" +
                         "rather affluent based on the rare metallic jewelry\n" +
                         "they adorn. You see a shop to the west.\n\n" +
                         "Exits: [W]est, [L]eave";
            return PlanetDesc;
        }


        public string AlphaName()
        {
            PlanetName = "Alpha Centauri";

            return PlanetName;
        }

        public string AlphaCentauriDesc()
        {
            PlanetDesc = "You've arrived at the main port of a small planet orbitting\n" +
                         "Alpha Centauri. There are beings bustling all around trading\n" +
                         "this and that.  You can't help but notice that there seems\n" +
                         "to be a premium placed on odd trinkets and antiques. You see\n" +
                         "a shop to the east.\n\n" +
                         "Exits: [E]ast, [L]eave";

            return PlanetDesc;
        }


        public string ObicromPersei8Name()
        {
            PlanetName = "Obicrom Persie 8";

            return PlanetName;
        }

        public string ObicromPersei8Desc()
        {
            PlanetDesc = "You have touched down on a rogue planet orbitting Obicrom Persei 8. You\n" +
                         "must say, the company being held here is less than reputable. There\n" +
                         "are shady characters all over. The people look starved. You notice a shop\n" +
                         "to the north.\n\n" +
                         "Exits: [N]orth, [L]eave";

            return PlanetDesc;
        }
    }

    
}
