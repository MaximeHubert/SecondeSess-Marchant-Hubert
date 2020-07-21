using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class Comment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public int IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }

        public Comment()
        {
        }

        public Comment(long id, string name, int rate, int idActor, string avatar, string date)
        {
            Id = id;
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;
            Date = date;
        }

    }
}
