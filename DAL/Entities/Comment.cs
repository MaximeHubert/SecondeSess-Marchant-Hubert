using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Comment
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
        


        public long Id { get; set; }
        public string Name { get; set; }
        public cote Rate { get; set; }
        public int IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }
        #endregion


        #region constructeurs

        public Comment()
        {
        }

        public Comment(long id, string name, cote rate, int idActor, string avatar, string date)
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
