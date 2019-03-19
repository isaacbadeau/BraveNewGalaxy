using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    class ShopClass:ShipClass
    {
        public List<string> shopOneInv = new List<string>() { "Odd Statue of a God", "Huge Ancient Battle Axe", "An Ancient Tome of Lore" };
        public List<string> shopTwoInv = new List<string>() { "Gundanium Alloy", "Adamantium", "Liquid Pollinium" };
        public List<string> shopThreeInv = new List<string>() { "A Fat Cow", "A Succulent Pig", "A Gaggle of Geese" };
        public string ShopDesc { get; set; }
        



        public string EarthShopDesc()
        {
            ShopDesc = "You've enter a rather quaint shop. There are various\n" +
                      "knick knacks adorning the shelves.  You can take a look\n" +
                      "around or simply type \"list\" to view the inventory\n" +
                      "(type buy and the list number or sell things from your inventory)\n\n" +
                      "Exits: East";
            
            return ShopDesc;
        }

        public string ProximaShopDesc()
        {
            ShopDesc = "This appears to be a precious metal shop.  There are all sorts\n" +
                      "rare elements in cases.  Some are extremely expensive. You can\n" +
                      "type \"list\" to view the goods\n" +
                      "(type buy and the list number or sell things from your inventory)\n\n" +
                      "Exits: South";

            return ShopDesc;
        }

        public string AlphaShopDesc()
        {
            ShopDesc = "You've walked into some sort of livestock market.  There are\n" +
                        "all kinds of animals and the smell if overwhelming. You can\n" +
                        "type \"list\" to view the goods\n" +
                        "(type buy and the list number or sell things from your inventory)\n\n" +
                        "Exits: West";

            return ShopDesc;
        }

        
    }
}
