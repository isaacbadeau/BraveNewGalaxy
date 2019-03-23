using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    class IntroToTheGame:NexusOfTheGalaxy
    {

        
        public void GameIntro()
        {
            Console.Clear();
            bool test = true;
            while(test)
            {
                Console.WriteLine($"\n\n\t\t\t\tWelcome to the world of tomorrow!\n\n" +
                              $"\tOn this adventure you will be known as {CharacterName}.  He is a {CharacterAge} year old\n" +
                              $"\tman from the Planet Earth.  He has {CharacterMoney} crs, and a spaceship named \n" +
                              $"\t{ShipName}.  His ship has {ShipCargo} units of cargo space.\n\n" +
                              $"\tHe's ready to hit the galaxy and make his forture.\n\n" +
                              $"\tThe point of this game is to make it to 1,000,000 crs any way you can (mostly buying and selling stuff).\n\n" +
                              $"\tIf you run out of money, game over man.\n\n" +
                              $"\tIf you don't reach 1,000,000 crs before 70, game over man.\n\n" +
                              $"\tIf you do make 1,000,000 crs, you beat the game and...game over man.\n\n" +
                              $"\tAre you ready to play?\n");
                              
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.Y:
                        Nexus();
                        break;
                    case ConsoleKey.N:
                        test = false;
                        break;
                    default:
                        GameIntro();
                        break;
                }
            }

        }
    }
}
