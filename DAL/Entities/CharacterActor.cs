using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class CharacterActor
    {
        #region membres

        public virtual Actor Actor { get; set; }
        public virtual Character Character { get; set; }
        #endregion


        #region constructeurs
        public CharacterActor()
        {
        }

        public CharacterActor(Actor actor, Character character)
        {
            Actor = actor;
            Character = character;
        }
        #endregion

    }
}
