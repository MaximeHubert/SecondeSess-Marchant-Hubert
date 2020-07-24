using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Comment
    {
        #region membres

        public enum cote
        {
         mediocre=1,
         mauvais=2,
         passable=3,
         bon=4,
         excellent=5
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public cote Rate { get; set; }
        public long IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }
        #endregion


        #region constructeurs

        public Comment()
        {
        }

        public Comment(long id, string name, cote rate, long idActor, string avatar)
        {
            Id = id;
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;
            Date = DateTime.Today.ToString();
        }
        #endregion

    }
}
