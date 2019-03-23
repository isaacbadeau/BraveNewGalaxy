using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    public class GalaxyClass:PlanetClass
    {
        public double investments;
        public double totalInvest;
        public double withdraw;
        Random shopRdn = new Random(); 
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
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.W:
                        EarthShop();
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\t[A]lpha\t\t4.37 ly\n\t[O]bicrom\t12.34 ly\n");
                        var destination = Console.ReadKey();
                        switch (destination.Key)
                        {
                            case ConsoleKey.O:
                                CharacterAge += 12.34;
                                PlanetObicrom();
                                break;
                            case ConsoleKey.A:
                                CharacterAge += 4.37;
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
                    case "withdraw":
                        Withdraw();
                        break;
                    case "say hi":
                        Console.WriteLine("\nWell hello to you too.  I bet your wondering how I made all my money.\n" +
                                          "I'll tell you what, I'm in a good mood today. I'm not going to tell you\n" +
                                          "how I made my money, but if you invest in my ventures, it will be worth\n" +
                                          "your while.\n" +
                                          "(you can type \"invest\" to take him up on the offer)\n");
                        break;
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
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopOneInv[0]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(3000, 5000));;
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "buy 2":
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopOneInv[1]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(6000,8000));
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "buy 3":
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopOneInv[2]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(9000, 10000));
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        EarthShop();
                        break;
                    case "sell":
                        Console.WriteLine("Sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell?");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Alloy"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(5000,7000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Adamantium"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(7000,9000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Liquid"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(10000, 13000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Cow"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(1000, 2000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Pig"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(2000, 3000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Geese"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(3000, 4000));
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
                    case "invest":
                        Invest();
                        break;
                    default:
                        EarthShop();
                        break;
                }
            } 
            
        }

        public void PlanetObicrom()
        {
            Console.Clear();
            Stats();
            bool test = true;
            while (test)
            
            {
                string obicromName = ObicromPersei8Name();
                string obicromDesc = ObicromPersei8Desc();
                Console.WriteLine($"{obicromName}\n\n" +
                                  $"{obicromDesc}");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.N:
                        ObicromShop();
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\t[A]lpha\t8.4 ly\n\t[E]arth\t12.34 ly\n");
                        var destination = Console.ReadKey();
                        switch (destination.Key)
                        {
                            case ConsoleKey.E:
                                CharacterAge += 10.2;
                                PlanetEarth();
                                break;
                            case ConsoleKey.A:
                                CharacterAge += 5.4;
                                PlanetAlpha();
                                break;
                        }
                        break;

                    default:
                        PlanetObicrom();
                        break;
                }
            } 

        }

        public void ObicromShop()
        {
            Console.Clear();
            Stats();
            string shopOne = ObicromShopDesc();
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
                        PlanetObicrom();
                        break;
                    case "buy 1":
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopTwoInv[0]);
                            CharacterMoney -= (shopRdn.Next(3000,5000));
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ObicromShop();
                        break;
                    case "buy 2":
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopTwoInv[1]);
                            CharacterMoney -= (shopRdn.Next(5000,8000));
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ObicromShop();
                        break;
                    case "buy 3":
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopTwoInv[2]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(8000,10000));
                            ShipCargo -= 1;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough space, sell some stuff!");
                        }
                        ObicromShop();
                        break;
                    case "sell":

                        Console.WriteLine("Sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell?");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Cow"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(10000,15000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Pig"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(15000,20000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("food") && playerInv[Convert.ToInt32(sellItem)].Contains("Geese"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(20000, 28000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("God"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(1000, 2000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Axe"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(2000, 3000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Tome"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(3000, 4000));
                                ShipCargo += 1;
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal"))
                            {
                                Console.WriteLine("I don't want that");
                            }

                        }
                        catch (Exception)
                        {
                            ObicromShop();
                        }
                        break;
                    default:
                        ObicromShop();
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
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.E:
                        AlphaShop();
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        Stats();
                        Console.WriteLine("Where would you like to go?\n\n\t[O]bicrom\t 8.4 ly\n\t[E]arth\t\t4.37 ly\n");
                        var destination = Console.ReadKey();
                        switch (destination.Key)
                        {
                            case ConsoleKey.O:
                                CharacterAge += 8.4;
                                PlanetObicrom();
                                break;
                            case ConsoleKey.E:
                                CharacterAge += 4.37;
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
                        if(playerInv.Count <= 19)
                        {
                            playerInv.Add(shopThreeInv[0]);
                            CharacterMoney -= (shopRdn.Next(3000,5000));
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
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopThreeInv[1]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(6000,8000));
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
                        if (playerInv.Count <= 19)
                        {
                            playerInv.Add(shopThreeInv[2]);
                            CharacterMoney = CharacterMoney - (shopRdn.Next(9000,10000));
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

                        Console.WriteLine("Sell item number from your inventory.");
                        for (int x = 0; x < playerInv.Count; x++)
                        {
                            Console.WriteLine($"{x}: {playerInv[x]}");
                        }
                        Console.WriteLine("What would you like to sell?");
                        var sellItem = Console.ReadLine();
                        try
                        {
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("God"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(5000,8000));
                                ShipCargo += 1;
                                AlphaShop();
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Axe"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(7000,10000));
                                ShipCargo += 1;
                                AlphaShop();
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("antique") && playerInv[Convert.ToInt32(sellItem)].Contains("Lore"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(9000, 14000));
                                ShipCargo += 1;
                                AlphaShop();
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Alloy"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(1000,2000));
                                ShipCargo += 1;
                                AlphaShop();
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Adamantium"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(2000,3000));
                                ShipCargo += 1;
                                AlphaShop();
                            }
                            if (playerInv[Convert.ToInt32(sellItem)].Contains("metal") && playerInv[Convert.ToInt32(sellItem)].Contains("Liquid"))
                            {
                                playerInv.RemoveAt(Convert.ToInt32(sellItem));
                                CharacterMoney += (shopRdn.Next(3000, 4000));
                                ShipCargo += 1;
                                AlphaShop();
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

        public void Withdraw()
        {
            
            Console.WriteLine("Ahh back to reap your rewards huh?  How much would you like?");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw > playerInvestments)
            {
                Console.WriteLine("You didn't make that much!");
            }
            else
            {
                CharacterMoney += withdraw;
            }
            EarthShop();
        }

        public void SetCursor(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }

        public void Stats()
        {
            playerInvestments = investments * Math.Pow(Math.E, (.07 * (CharacterAge - 20)))-withdraw;
            SetCursor(75, 5, $"Name:\t{CharacterName}");
            SetCursor(75, 6, $"Age:\t\t{CharacterAge}");
            SetCursor(75, 7, $"Crs:\t\t{CharacterMoney}");
            SetCursor(75, 8, $"Ship:\t{ShipName}\tCargo: {ShipCargo}");
            SetCursor(75, 9, $"Investments:\t{playerInvestments:f2}crs");

            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\tInventory:\t\t\tType\t\t\tValue\n");
            for (int x = 0; x < playerInv.Count; x++)
            {
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t{playerInv[x]}");
            }
            
            if (CharacterAge>70 || CharacterMoney<0)
            {
                Console.Clear();
                Console.WriteLine("You Lost!");
                Environment.Exit(0);
            }

            if (CharacterMoney>1000000 || CharacterMoney+playerInvestments > 1000000)
            {
                Console.Clear();
                Console.WriteLine("You Won! Time to buy a planet and retire on it!");
                Environment.Exit(0);
            }
        }

        public void Invest()
        {
            Console.WriteLine("\nHow much would you like to invest?\n");
            double invest = Convert.ToDouble(Console.ReadLine());
            investments = invest;
            CharacterMoney -= invest;
            Console.WriteLine("\nThanks for your support! You won't regret it! You can find me here any time\n" +
                                          "to withdraw some of your profits");
            Console.WriteLine("\nPress any key to continue...");
        }
        //\t\t\t\t\t\t\t\t\t\t

    }
}
