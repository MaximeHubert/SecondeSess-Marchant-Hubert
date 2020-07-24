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
        public long IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }


        public Comment()
        {
        }

        public Comment( string name, int rate, long idActor, string avatar)
        {
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;

        }

        public Comment(string name, int rate, long idActor, string avatar,string date)
        {
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;
            Date = date;

        }

    }
}
