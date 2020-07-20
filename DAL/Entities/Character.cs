using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Character
    {
        #region membres
        public long Id { get; set; }
        public string CharacterName { get; set; }
        #endregion


        #region constructeurs
        public Character()
        {
        }

        public Character(long id, string characterName)
        {
            Id = id;
            CharacterName = characterName;
        }
        #endregion

    }
}
