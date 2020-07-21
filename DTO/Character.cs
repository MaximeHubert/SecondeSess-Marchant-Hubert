using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class Character
    {

        public string CharacterName { get; set; }

        public Character()
        {
        }

        public Character(string characterName)
        {
            CharacterName = characterName;
        }
    }
}
