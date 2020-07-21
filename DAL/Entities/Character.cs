using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Character
    {
        #region membres
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string CharacterName { get; set; }
        public ICollection<CharacterActor> CharacterActor { get; set; }
        #endregion


        #region constructeurs
        public Character()
        {
            CharacterActor = new List<CharacterActor>();
        }

        public Character(long id, string characterName)
        {
            Id = id;
            CharacterName = characterName;
            CharacterActor = new List<CharacterActor>();
        }
        #endregion

    }
}
