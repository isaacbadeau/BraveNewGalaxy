using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    public class ShopClass:ShipClass
    {
        public List<string> shopOneInv = new List<string>() { "Odd Statue of a God\t\t(antique)\t5000cr", "Huge Ancient Battle Axe\t(antique)\t8000cr", "An Ancient Tome of Lore\t(antique)\t10000cr" };
        public List<string> shopTwoInv = new List<string>() { "Gundanium Alloy\t(prescious metal)\t5000cr", "Adamantium\t\t(prescious metal)\t8000cr", "Liquid Pollinium\t(prescious metal)\t10000cr" };
        public List<string> shopThreeInv = new List<string>() { "A Fat Cow\t\t(food)\t5000cr", "A Succulent Pig\t(food)\t8000cr", "A Gaggle of Geese\t(food)\t10000cr" };
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
