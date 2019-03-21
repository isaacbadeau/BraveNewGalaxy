using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    public class GalaxyClass:PlanetClass
    {
        public void PlanetEarth()
        {
            Console.Clear();
            Stats();
            bool test = true;
            while(test)
            
            {
                string earthName = EarthName();
                string earthDesc = EarthDesc();
                Console.WriteLine($"{earthName}\n\n" +
                                  $"{earthDesc}");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "west":
                    case "w":
                        EarthShop();
                        break;
                    case "leave":
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\tAlpha\n\tObicrom\n");
                        var destination = Console.ReadLine();
                        switch (destination)
                        {
                            case "obicrom":
                                CharacterAge += 5;
                                PlanetProxima();
                                break;
                            case "alpha":
                                CharacterAge += 5;
                                PlanetAlpha();
                                break;
                        }
                        break;
                    default:
                        PlanetEarth();
                        break;
                }
            }
            
        }

        public void EarthShop()
        {
            Console.Clear();
            Stats();
            string shopOne = EarthShopDesc();
            Console.WriteLine($"An Old Wizened Woman's Odds and Ends\n\n" +
                              $"{shopOne}");
            bool test = true;
            while(test)
            
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "list":
                        for (int x = 0; x < shopOneInv.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {shopOneInv[x]}");
                        }
                        break;
                    case "east":
                    case "e":
                        PlanetEarth();
                        break;
                    case "buy 1":
                        if (playerInv.Count<=9)
                        {
                            playerInv.Add(shopOneInv[0]);
                            CharacterMoney = CharacterMoney - 5000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "buy 2":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopOneInv[1]);
                            CharacterMoney = CharacterMoney - 8000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "buy 3":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopOneInv[2]);
                            CharacterMoney = CharacterMoney - 10000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "sell":

                        Console.WriteLine("sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell(sell food, antique, precious metal)");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Alloy"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Adamantium"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Liquid"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Cow"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Pig"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Geese"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique"))
                            {
                                Console.WriteLine("I don't want that");
                            }
                            
                        }
                        catch (Exception)
                        {
                            EarthShop();
                        }
                        break;
                    default:
                        EarthShop();
                        break;
                }
            } 
            
        }

        public void PlanetProxima()
        {
            Console.Clear();
            Stats();
            bool test = true;
            while (test)
            
            {
                string proximaName = ObicromPersei8Name();
                string proximaDesc = ObicromPersei8Desc();
                Console.WriteLine($"{proximaName}\n\n" +
                                  $"{proximaDesc}");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "north":
                    case "n":
                        ProximaShop();
                        break;
                    case "leave":
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\tAlpha\n\tEarth\n");
                        var destination = Console.ReadLine();
                        switch (destination)
                        {
                            case "earth":
                                CharacterAge += 5;
                                PlanetEarth();
                                break;
                            case "alpha":
                                CharacterAge += 3;
                                PlanetAlpha();
                                break;
                        }
                        break;

                    default:
                        PlanetProxima();
                        break;
                }
            } 

        }

        public void ProximaShop()
        {
            Console.Clear();
            Stats();
            string shopOne = ProximaShopDesc();
            Console.WriteLine($"Jasper's Prescious Metals\n\n" +
                              $"{shopOne}");
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();
                switch (input)
                {

                    case "list":
                        for (int x = 0; x < shopTwoInv.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {shopTwoInv[x]}");
                        }
                        break;
                    case "south":
                    case "s":
                        PlanetProxima();
                        break;
                    case "buy 1":
                        if (playerInv.Count<=9)
                        {
                            playerInv.Add(shopTwoInv[0]);
                            CharacterMoney = CharacterMoney - 5000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ProximaShop();
                        break;
                    case "buy 2":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopTwoInv[1]);
                            CharacterMoney = CharacterMoney - 7000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ProximaShop();
                        break;
                    case "buy 3":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopTwoInv[2]);
                            CharacterMoney = CharacterMoney - 10000;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ProximaShop();
                        break;
                    case "sell":

                        Console.WriteLine("sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell(sell food, antique, precious metal)");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Cow"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Pig"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Geese"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("God"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Axe"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Tome"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal"))
                            {
                                Console.WriteLine("I don't want that");
                            }

                        }
                        catch (Exception)
                        {
                            ProximaShop();
                        }
                        break;
                    default:
                        ProximaShop();
                        break;
                }
            }

        }

        public void PlanetAlpha()
        {
            Console.Clear();
            Stats();
            bool test = true;
            while (test)
            
            {
                string alphaName = AlphaName();
                string alphaDesc = AlphaCentauriDesc();
                Console.WriteLine($"{alphaName}\n\n" +
                                  $"{alphaDesc}");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "east":
                    case "e":
                        AlphaShop();
                        break;
                    case "leave":
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\tObicrom\n\tEarth\n");
                        var destination = Console.ReadLine();
                        switch (destination)
                        {
                            case "obicrom":
                                CharacterAge += 5;
                                PlanetProxima();
                                break;
                            case "earth":
                                CharacterAge += 20;
                                PlanetEarth();
                                break;
                        }
                        break;
                    
                    default:
                        PlanetAlpha();
                        break;
                }
            } 

        }

        public void AlphaShop()
        {
            Console.Clear();
            Stats();
            string alphaShop = AlphaShopDesc();
            Console.WriteLine($"Gunther's Butcher Shop\n\n" +
                              $"{alphaShop}");
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "list":
                        for (int x = 0; x < shopThreeInv.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {shopThreeInv[x]}");
                        }
                        break;
                    case "west":
                    case "w":
                        PlanetAlpha();
                        break;
                    case "buy 1":
                        if(playerInv.Count<=9)
                        {
                            playerInv.Add(shopThreeInv[0]);
                            CharacterMoney = CharacterMoney - 5000;
                            ShipCargo -= 1;
                            AlphaShop();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        AlphaShop();
                        break;
                    case "buy 2":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopThreeInv[1]);
                            CharacterMoney = CharacterMoney -7000;
                            ShipCargo -= 1;
                            AlphaShop();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        AlphaShop();
                        break;
                    case "buy 3":
                        if (playerInv.Count <= 9)
                        {
                            playerInv.Add(shopThreeInv[2]);
                            CharacterMoney = CharacterMoney - 10000;
                            ShipCargo -= 1;
                            AlphaShop();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        AlphaShop();
                        break;
                    case "sell":

                        Console.WriteLine("sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell(sell food, antique, precious metal)");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("God"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Axe"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Lore"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Alloy"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 7000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Adamantium"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 10000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Liquid"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney -= 15000;
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food"))
                            {
                                Console.WriteLine("I don't want that");
                            }
                        }
                        catch (Exception)
                        {
                            AlphaShop();
                        }
                        break;
                    default:
                        AlphaShop();
                        break;
                }
            }

        }

        public void Stats()
        {
            Console.WriteLine($"Your name is {CharacterName}. You are {CharacterAge}. You have {CharacterMoney} coins.\n" +
                              $"You fly a {ShipName} spaceship.  It has {ShipCargo} units of cargo space.");
            Console.WriteLine("You have the following in your inventory:");
            for (int x = 0; x < playerInv.Count; x++)
            {
                Console.WriteLine($"{x + 1}: {playerInv[x]}");
            }
            Console.WriteLine();
            if (CharacterAge>70 || CharacterMoney<0)
            {
                Console.Clear();
                Console.WriteLine("You Lost!");
                Environment.Exit(0);
            }
            
        }
    }
}
