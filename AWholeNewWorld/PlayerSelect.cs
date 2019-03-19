using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {

        public void Player()
        {
            Player Cynthia = new Player("Cynthia", 20, "Earth", "");
            Console.WriteLine(Cynthia.GetInfo());

            Player Jasmine = new Player("Jasmine", 20, "Alpha Centauri", "");
            Console.WriteLine(Jasmine.GetInfo());

            Player FLEX = new Player("FLEX", 20, "Titan AE", "");
            Console.WriteLine(FLEX.GetInfo());

            Player JRON = new Player("JRON", 20, "Proxima B", "");
            Console.WriteLine(JRON.GetInfo());

            Console.WriteLine("Please select a character.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine(Cynthia.GetInfo());
                    break;

                case "2":
                    Console.WriteLine(Jasmine.GetInfo());
                    break;

                case "3":
                    Console.WriteLine(FLEX.GetInfo());
                    break;

                case "4":
                    Console.WriteLine(JRON.GetInfo());
                    break;

                default:
                    {
                        Console.WriteLine("Invalid Input, please enter a valid option.");
                        break;
                    }
            }
        }
    }
}

