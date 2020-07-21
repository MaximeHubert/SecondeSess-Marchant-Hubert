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
            Comment = new List<Comment>();
        }

        public Actor(long id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Comment = new List<Comment>();
        }
    }
}
