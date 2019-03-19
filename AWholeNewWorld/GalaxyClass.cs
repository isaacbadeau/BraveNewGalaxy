using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    class GalaxyClass:PlanetClass
    {
        public void PlanetEarth()
        {
            Console.Clear();
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
                        EarthShop();
                        break;
                    case "leave":
                        Console.WriteLine("Where would you like to go?\n\tAlpha\n\tProxima\n");
                        var destination = Console.ReadLine();
                        switch(destination)
                        {
                            case "proxima":
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
                        PlanetEarth();
                        break;
                    case "stats":
                        Stats();
                        break;
                    case "buy 1":
                        playerInv.Add(shopOneInv[0]);
                        CharacterMoney = CharacterMoney - 1000;
                        ShipCargo -= 1;
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
            bool test = true;
            while (test)
            {
                string proximaName = ProximaName();
                string proximaDesc = ProximaB();
                Console.WriteLine($"{proximaName}\n\n" +
                                  $"{proximaDesc}");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "north":
                        ProximaShop();
                        break;
                    case "leave":
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
                        PlanetProxima();
                        break;
                    case "stats":
                        Stats();
                        break;
                    case "buy 1":
                        playerInv.Add(shopTwoInv[0]);
                        CharacterMoney = CharacterMoney - 1000;
                        ShipCargo -= 1;
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
                        AlphaShop();
                        break;
                    case "leave":
                        Console.WriteLine("Where would you like to go?\n\n\tProxima\n\tEarth\n");
                        var destination = Console.ReadLine();
                        switch (destination)
                        {
                            case "proxima":
                                CharacterAge += 5;
                                PlanetProxima();
                                break;
                            case "earth":
                                CharacterAge += 5;
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
                        PlanetAlpha();
                        break;
                    case "stats":
                        Stats();
                        break;
                    case "buy 1":
                        CharacterMoney = CharacterMoney - 1000;
                        ShipCargo -= 1;
                        playerInv.Add(shopThreeInv[0]);
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
        }
    }
}
