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
                Console.WriteLine($"\t\t\t\tWelcome to the world of tomorrow!\n\n" +
                              $"\tOn this adventure you will be knows as {CharacterName}.  He is a {CharacterAge} year old\n" +
                              $"\tman from the Planet Earth.  He has {CharacterMoney} in coins, and a spaceship named \n" +
                              $"\t{ShipName}.  His ship has {ShipCargo} units of cargo space.\n\n" +
                              $"\tHe's ready to hit the galaxy and make his forture!\n\n" +
                              $"\tThe point of this game is to make it to 1,000,000 coins by buying and selling goods\n" +
                              $"\taround the galaxy before you die at the  of age 70.(Space travel takes time)\n\n" +
                              $"\tIf you run out of money you lose! If you don't make the money before 70 you lose!\n\n" +
                              $"\tAt any point in the game you can type \"stats\" to see your current situation.\n\n" +
                              $"\tAre you ready to play?(Yes or No)\n");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "yes":
                        Nexus();
                        break;
                    case "no":
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
