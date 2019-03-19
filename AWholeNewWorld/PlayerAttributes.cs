using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Player
    {
        public string Name;
        public int Age;
        public string Planet;
        public string Bio;

        public Player(string Name, int Age, string Planet, string Bio)
        {
            this.Name = Name;
            this.Age = Age;
            this.Planet = Planet;
            this.Bio = Bio;
        }

        public string GetInfo()
        {
            string output = Name + " " + Age + " " + Planet + " \n" + Bio;
            return output;


        }
    }


}
