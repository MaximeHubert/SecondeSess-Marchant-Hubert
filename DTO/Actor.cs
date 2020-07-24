using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class Actor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Comment> Comment { get; set; }


        public Actor()
        {
        }

        public Actor(long id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public Actor(long id, string name, string surname,ICollection<Comment> comment)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Comment = comment;
        }
    }
}
