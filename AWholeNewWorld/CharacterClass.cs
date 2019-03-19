using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABraveNewGalaxy
{
    class CharacterClass
    {
        //public string CharacterName = "Action Jackson";
        //public int CharacterAge = 20;
        //public int CharacterMoney = 100000;
        public List<string> playerInv = new List<string>();

        public string CharacterName { get; set; }
        public int CharacterAge { get; set; }
        public int CharacterMoney { get; set; }

        public CharacterClass(string characterName, int characterAge, int characterMoney)
        {
            CharacterName = characterName;
            CharacterAge = characterAge;
            CharacterMoney = characterMoney;

        }

        public void CharName()
        {
            CharacterName = "Jessie";
            CharacterAge = 20;
            CharacterMoney = 100000;
        }

        


    }
}
