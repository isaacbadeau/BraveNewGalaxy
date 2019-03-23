using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    public class ShopClass:ShipClass
    {
        public List<string> shopOneInv = new List<string>() { "Odd Statue of a God\t\t(antique)\t Current Market Value cr", "Huge Ancient Battle Axe\t\t(antique)\t Current Market Value cr", "An Ancient Tome of Lore\t\t(antique)\t Current Market Value cr" };
        public List<string> shopTwoInv = new List<string>() { "Gundanium Alloy\t\t\t(metal)\t\t Current Market Value cr", "Adamantium\t\t\t(metal)\t\t Current Market Value cr", "Liquid Pollynium\t\t(metal)\t\t Current Market Value cr" };
        public List<string> shopThreeInv = new List<string>() { "A Fat Cow\t\t\t(food)\t\t Current Market Value cr", "A Succulent Pig\t\t\t(food)\t\t Current Market Value cr", "A Gaggle of Geese\t\t(food)\t\t Current Market Value cr" };
        public string ShopDesc { get; set; }
        



        public string EarthShopDesc()
        {
            ShopDesc = "You've entered a rather quaint shop. There are various\n" +
                      "knick knacks adorning the shelves.  There is one other customer\n" +
                      "present.  He is a rather wealthy looking individual, perhaps you\n" +
                      "should \"say hi\". You can take a look around or simply type \"list\"\n" +
                      "to view the inventory.\n" +
                      "(to buy type \"buy #\". To sell type \"sell\" and then enter a number)\n\n" +
                      "Exits: East";
            
            return ShopDesc;
        }

        public string ObicromShopDesc()
        {
            ShopDesc = "This appears to be a precious metal shop.  There are all sorts\n" +
                      "rare elements in cases.  Some are extremely expensive. You can\n" +
                      "type \"list\" to view the goods.\n" +
                      "(to buy type \"buy #\". To sell type \"sell\" and then enter a number)\n\n" +
                      "Exits: South";

            return ShopDesc;
        }

        public string AlphaShopDesc()
        {
            ShopDesc = "You've walked into some sort of livestock market.  There are\n" +
                        "all kinds of animals and the smell is overwhelming. You can\n" +
                        "type \"list\" to view the goods.\n" +
                        "(to buy type \"buy #\". To sell type \"sell\" and then enter a number)\n\n" +
                        "Exits: West";

            return ShopDesc;
        }

        
    }
}
