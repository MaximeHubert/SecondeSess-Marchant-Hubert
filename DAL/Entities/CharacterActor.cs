using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CharacterActor
    {
        #region membres
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Character Character { get; set; }
        public virtual Film Film { get; set; }
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
